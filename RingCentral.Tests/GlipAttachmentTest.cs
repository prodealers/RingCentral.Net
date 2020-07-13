using System;
using Xunit;

namespace RingCentral.Tests
{
    public class GlipAttachmentTest
    {
        [Fact]
        public async void PostAttachment()
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );
                var groupId = (await rc.Restapi().Glip().Chats().List()).records[0].id;
                rc.AfterHttpCall += (sender, args) =>
                {
                    var request = args.ToString();
                };
                var postInfo = await rc.Restapi().Glip().Chats(groupId).Posts().Post(new GlipPostPostBody
                {
                    attachments = new[]
                    {
                        new GlipAttachmentInfoRequest
                        {
                            type = "Card",
                            fallback = "fallback",
                            color = "#000000",
                            intro = "intro",
                            text = "text",
                            title = "title",
                            imageUri = "https://www.baidu.com/img/bd_logo1.png"
                        }
                    }
                });
                Assert.Equal("https://www.baidu.com/img/bd_logo1.png", postInfo.attachments[0].imageUri);
            }
        }
    }
}