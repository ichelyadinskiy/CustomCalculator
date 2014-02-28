using Calculator.Models;
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
        public static Model serverModel = new Model
        {
            Current = 0,
            Memory = 0,
            Result = 0
        };

        [HttpPost]
        public object PostSum(Model model)
        {
            serverModel.Result += model.Current;
            return serverModel;
        }

        [HttpPost]
        public object PostMemory(Model model)
        {
            serverModel.Memory = model.Current;
            return serverModel;
        }

        [HttpGet]
        public object GetMemory()
        {
            return serverModel;
        }

        [HttpPut]
        public object PutMemory(Model model)
        {
            serverModel.Memory += model.Current;
            serverModel.Current = 0;
            return serverModel;
        }
    }
}
