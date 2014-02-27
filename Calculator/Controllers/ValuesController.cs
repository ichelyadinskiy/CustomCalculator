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
            Result = 0,
            Memory = 0
        };
        public object PostSum(dynamic model)
        {
            serverModel.Result += model.current;
            return serverModel;
        }
    }
}
