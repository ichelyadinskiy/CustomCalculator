using Calculator.Models;
using Calculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calculator.Controllers
{
    public class ValuesController : ApiController
    {
        Service calcService = new Service();

        [HttpPost]
        public object PostSum(Model model)
        {
            return calcService.AddResult(model);
        }

        [HttpPost]
        public object PostMemory(Model model)
        {
            return calcService.ReplaceMemory(model);
        }

        [HttpGet]
        public object GetMemory()
        {
            return calcService.GetMemory();
        }

        [HttpPut]
        public object PutMemory(Model model)
        {
            return calcService.AddToMemory(model);
        }

        [HttpPost]
        public object PostMinus(Model model)
        {
            return calcService.MinusRes(model);
        }

        [HttpPost]
        public object PostDivision(Model model)
        {
            return calcService.Division(model);
        }

        [HttpPost]
        public object PostMultiplication(Model model)
        {
            return calcService.Multiplication(model);
        }

        [HttpGet]
        public object GetClear()
        {
            return calcService.Clear();
        }
    }
}
