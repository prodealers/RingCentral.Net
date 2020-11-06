﻿namespace RingCentral.Net.AutoRefresh
{
    public class AutoRefreshExtension : SdkExtension
    {
        private RestClient _rc;
        private System.Timers.Timer _autoRefreshTimer;
        private readonly AutoRefreshOptions _autoRefreshOptions;

        public AutoRefreshExtension(AutoRefreshOptions autoRefreshOptions = null)
        {
            _autoRefreshOptions = autoRefreshOptions ?? AutoRefreshOptions.DefaultInstance;
        }

        public override void Install(RestClient rc)
        {
            this._rc = rc;
        }

        public void Start()
        {
            Stop(); // stop existing
            _autoRefreshTimer = new System.Timers.Timer();
            _autoRefreshTimer.Elapsed += (sender, args) => { this._rc.Refresh(); };
            _autoRefreshTimer.Interval = _autoRefreshOptions.interval;
            _autoRefreshTimer.Start();
        }

        public void Stop()
        {
            if (_autoRefreshTimer != null)
            {
                _autoRefreshTimer.Stop();
                _autoRefreshTimer.Dispose();
                _autoRefreshTimer = null;
            }
        }
    }
}