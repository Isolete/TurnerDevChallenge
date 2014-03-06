using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurnerDevChallenge.Web;
using TurnerDevChallenge.Web.Controllers;
using Rhino.Mocks;

namespace TurnerDevChallenge.Web.Tests.Controllers
{
    [TestClass]
    public class TitleControllerTest
    {
       
        [TestMethod]
        [Ignore]
        public void Index()
        {
            // Arrange
        //    var controller = new MockRepository.GenerateStub;


            // Act
            //ViewResult result = controller.Index() as ViewResult;

            // Assert
           // Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }

        [TestMethod]
        [Ignore]
        public void Details()
        {
            // Arrange
            TitleController controller = new TitleController();

            // Act
            ViewResult result = controller.Details(610) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [Ignore]
        public void SearchForTitles()
        {
            // Arrange
            TitleController controller = new TitleController();

            // Act
            ViewResult result = controller.SearchForTitles("Casablanca") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
