using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;

namespace Tests
{
    [TestFixture]
    public class OutboundRoutingTests
    {
        [Test]
        public void All_Products_Page_1_Is_At_Slash()
        {
            Assert.AreEqual("/", GetOutboundUrl(new
            {
                controller = "Products",
                action = "List",
                category = (string)null,
                page = 1
            }));
        }

        string GetOutboundUrl(object routeValues)
        {
            // Get route configuration and mock request context
            RouteCollection routes = new RouteCollection();
            WebUI.RouteConfig.RegisterRoutes(routes);
            var mockHttpContext = new Moq.Mock<HttpContextBase>();
            var mockRequest = new Moq.Mock<HttpRequestBase>();
            var fakeResponse = new FakeResponse();
            mockHttpContext.Setup(x => x.Request).Returns(mockRequest.Object);
            mockHttpContext.Setup(x => x.Response).Returns(fakeResponse);
            mockRequest.Setup(x => x.ApplicationPath).Returns("/");
            // Generate the outbound URL
            var ctx = new RequestContext(mockHttpContext.Object, new RouteData());
            return routes.GetVirtualPath(ctx, new RouteValueDictionary(routeValues))
            .VirtualPath;
        }
        [Test]
        public void Football_Page1_Is_At_Slash_Football()
        {
            Assert.AreEqual("/Football", GetOutboundUrl(new
            {
                controller = "Products",
                action = "List",
                category = "Football",
                page = 1
            }));
        }
        [Test]
        public void Football_Page101_Is_At_Slash_Football_Slash_Page101()
        {
            Assert.AreEqual("/Football/Page101", GetOutboundUrl(new
            {
                controller = "Products",
                action = "List",
                category = "Football",
                page = 101
            }));
        }
        [Test]
        public void AnythingController_Else_Action_Is_At_Anything_Slash_Else()
        {
            Assert.AreEqual("/Anything/Else", GetOutboundUrl(new
            {
                controller = "Anything",
                action = "Else"
            }));
        }
        private class FakeResponse : HttpResponseBase
        {
            // Routing calls this to account for cookieless sessions
            // It's irrelevant for the test, so just return the path unmodified
            public override string ApplyAppPathModifier(string x) { return x; }

        }
    }
}
