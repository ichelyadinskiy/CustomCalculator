using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Resolvers.Repositories;
using Calculator.Models;
using Moq;

namespace Calculator.Tests.Repositories
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public void objCreate()
        {
            Model model = new Model();
            Assert.IsNotNull(model);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddResult()
        {
            var repository = new Repository();
            repository.AddRes(null);
        }

        [TestMethod]
        public void AddMemory()
        {
            var repository = new Repository();
            Model model = repository.GetMemory();
            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void Division()
        {
            var model = new Model { Current = 10, Result = 40 };
            IRepository repDep = Mock.Of<IRepository>(x => x.DivisionRes(model) == new Model { Result = 4, Current = 0 });
            var div = repDep.DivisionRes(model);
            Assert.AreEqual(4, div.Result);
        }
    }
}
