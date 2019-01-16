using System;
using System.Collections.Generic;
using System.Text;
// using Websocket.Client;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RingCentral.Net
{
    public class Subscription
    {
        public string[] eventFilters;
        public RingClient rc;
        public Action<string> callback;
        // public IDisposable subscription; // from Websocket.Client
        public EventHandler<MessageReceivedEventArgs> handler;

        private SubscriptionInfo _subscriptionInfo; // from RingCentral spec
        private bool renewScheduled = false;
        public SubscriptionInfo subscriptionInfo
        {
            get
            {
                return _subscriptionInfo;
            }
            set
            {
                _subscriptionInfo = value;
                if (value != null && !renewScheduled)
                {
                    Task.Delay((int)(_subscriptionInfo.expiresIn.Value - 120) * 1000).ContinueWith(async (action) =>
                    { // 2 minutes before expiration
                        renewScheduled = false;
                        await Refresh();
                    });
                    renewScheduled = true;
                }
            }
        }

        public Subscription(RingClient rc, string[] eventFilters, Action<string> callback)
        {
            this.rc = rc;
            this.eventFilters = eventFilters;
            this.callback = callback;
            this.handler = (sender, args) =>
            {
                var message = args.text;
                if (message != null && message.Contains($"\"subscriptionId\":\"{subscriptionInfo.id}\""))
                {
                    callback(message);
                }
            };
        }

        public async Task<Response<SubscriptionInfo>> Subscribe()
        {
            var createSubscriptionRequest = new CreateSubscriptionRequest
            {
                eventFilters = this.eventFilters,
                deliveryMode = new NotificationDeliveryModeRequest
                {
                    transportType = "WebSocket"
                }
            };
            var r = await this.rc.Post<SubscriptionInfo>("/restapi/v1.0/subscription", createSubscriptionRequest);
            subscriptionInfo = r.body;
            this.rc.MessageReceivedEventHandler += this.handler;
            // subscription = this.rc.wsClient.MessageReceived.Subscribe(message =>
            // {
            //     if (message.Contains($"\"subscriptionId\":\"{subscriptionInfo.id}\""))
            //     {
            //         var messages = JArray.Parse(message);
            //         callback(messages[1].ToString()); // message[0] is some metadata
            //     }
            // });
            return r;
        }

        public async Task<Response> Revoke()
        {
            var r = await rc.Delete($"/restapi/v1.0/subscription/{subscriptionInfo.id}");
            // subscription.Dispose();
            subscriptionInfo = null;
            this.rc.MessageReceivedEventHandler -= this.handler;
            return r;
        }

        public async Task<Response<SubscriptionInfo>> Refresh()
        {
            var r = await rc.Post<SubscriptionInfo>($"/restapi/v1.0/subscription/{subscriptionInfo.id}/renew");
            subscriptionInfo = r.body;
            return r;
        }
    }
}
