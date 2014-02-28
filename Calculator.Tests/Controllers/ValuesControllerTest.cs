using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Controllers;
using Calculator.Models;
using Moq;

namespace Calculator.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void SendSumTest()
        {
            var controller = new ValuesController();
            Model modelTest = new Model { Current = 10, Memory = 0, Result = 0 };
            modelTest = (Model)controller.PostSum(modelTest);
            Assert.AreEqual(10, modelTest.Result);
        }

        [TestMethod]
        public void GetMemoryTest()
        {
            var controller = new ValuesController();
            Assert.IsNotNull(controller.GetMemory());
        }

        [TestMethod]
        public void Clear()
        {
            var controller = new ValuesController();
            Model model = (Model)controller.GetClearAll();
            var result = model.Result + model.Memory + model.Current;
            Assert.AreEqual(0, result);
        }
    }
}
