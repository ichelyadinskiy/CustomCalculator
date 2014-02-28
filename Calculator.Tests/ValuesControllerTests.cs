using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Controllers;
using Calculator.Models;
using Calculator.Services;

namespace Calculator.Tests
{
    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        public void TestDetailsView()
        {
            ValuesController controller = new ValuesController();
            var request = controller.PostSum(new Model() { Current = 10 });
            Assert.AreEqual(Repository.serverModel.Result, request);
        }
    }
}
