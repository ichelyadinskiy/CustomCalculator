using Calculator.Models;
using Calculator.Resolvers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.Services
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void Multiplication()
        {
            Model model = new Model { Result = 3, Current = 3, Memory = 0};
            IService service = Mock.Of<IService>(x => x.MultiRes(model) == new Model { Result = 9, Current = 0, Memory = 0});
            var mult = service.MultiRes(model);
            Assert.AreEqual(9, mult.Result);
        }
    }
}
