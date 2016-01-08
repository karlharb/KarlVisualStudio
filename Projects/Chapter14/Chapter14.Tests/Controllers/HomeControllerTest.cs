using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter14;
using Chapter14.Controllers;
using System.Web;
using Moq;
using System.Web.Routing;

namespace Chapter14.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            //ViewResult result = controller.Index();
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexShouldAskForDefaultView()
        {
            var controller = new HomeController();
            ViewResult result = controller.Index();

            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewName, "");
        }

        [TestMethod]
        public void SendMeSomwhereElseIssuesRedirect()
        {
            var controller = new HomeController();

            var result = controller.SendMeSomwhereElse();

            Assert.AreEqual("~/Some/Other/Place", result.Url);
        }

        [TestMethod]
        public void RouteForEmbeddedResource()
        {
            //Arrange
            var mockContext = new Mock<HttpContextBase>();

            mockContext.Setup(c =>
                c.Request.AppRelativeCurrentExecutionFilePath).Returns("~/handler.axd");

            var routes = new RouteCollection();

            RouteConfig.RegisterRoutes(routes);

            //Act
            RouteData routeData = routes.GetRouteData(mockContext.Object);

            //Assert
            Assert.IsNotNull(routeData);
            Assert.IsInstanceOfType(routeData.RouteHandler, typeof(StopRoutingHandler));                                             
        }

    }
}
