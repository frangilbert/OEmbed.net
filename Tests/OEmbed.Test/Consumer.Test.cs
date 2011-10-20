using Moq;
using NUnit.Framework;
using OEmbed.Net;
using OEmbed.Net.Domain;
using OEmbed.Net.Utilities;

namespace OEmbed.Test
{
    [TestFixture]
    public class Consumer
    {
        private Mock<IRestCall> _restCall;
        
        [SetUp]
        public void SetUp()
        {
            _restCall = new Mock<IRestCall>();
        }

        private void MockFeed(string embeddedFile)
        {
            var fakeStream = Util.GetEmbeddedResource(embeddedFile);
            _restCall.Setup(rest => rest.Call("")).Returns(fakeStream);
        }

        [Test]
        public void Consumer_WhenFlickrJson_ReturnsPhotoData()
        {
            MockFeed("OEmbed.Test.FakeData.Flickr.json");
            var _consumer = new Consumer<Photo>(_restCall.Object);
            
            Photo photo = _consumer.GetObject("");
            Assert.AreEqual("ZB8T0193", photo.Title);
        }

        [Test]
        public void Consumer_WhenYoutube_ReturnsVideoData()
        {
            MockFeed("OEmbed.Test.FakeData.Youtube.json");
            var _consumer = new Consumer<Video>(_restCall.Object);
            
            Video video = _consumer.GetObject("");
            Assert.AreEqual("Jude Law:  My Take On Peace Video Contest", video.Title);
        }

        [Test]
        public void Consumer_WhenViddler_ReturnsVideoData()
        {
            MockFeed("OEmbed.Test.FakeData.Viddler.json");
            var _consumer = new Consumer<Video>(_restCall.Object);

            Video video = _consumer.GetObject("");
            Assert.AreEqual("iPhone macro lens demonstration", video.Title);
        }

        [Test]
        public void Consumer_WhenQik_ReturnsVideoData()
        {
            MockFeed("OEmbed.Test.FakeData.Qik.json");
            var _consumer = new Consumer<Video>(_restCall.Object);

            Video video = _consumer.GetObject("");
            Assert.AreEqual("iPhone macro lens demonstration", video.Title);
        }
    }
}
