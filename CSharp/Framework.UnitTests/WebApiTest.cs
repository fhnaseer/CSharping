using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace Framework.UnitTests
{
    [TestClass]
    public class WebApiTest
    {
        [TestMethod]
        public void WebApi_Test()
        {
            var request = (HttpWebRequest)HttpWebRequest.Create("http://localhost/Framework.WebApi");
            request.GetResponse();
        }
    }
}
