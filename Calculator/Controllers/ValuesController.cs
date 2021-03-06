﻿using Autofac;
using Calculator.Models;
using Calculator.Resolvers.Services;
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
        ContainerBuilder builder;
        IContainer container { get; set; }

        public ValuesController()
        {
            builder = new ContainerBuilder();
            builder.RegisterType<Service>().As<IService>();
            container = builder.Build();
        }

        [HttpPost]
        public object PostSum(Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IService>();
                return caller.AddRes(model);
            }
        }

        [HttpPost]
        public object PostMemory(Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IService>();
                return caller.ReplaceMemory(model);
            }
        }

        [HttpGet]
        public object GetMemory()
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IService>();
                return caller.GetMemory();
            }
        }

        [HttpPut]
        public object PutMemory(Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IService>();
                return caller.AddToMemory(model);
            }
        }

        [HttpPost]
        public object PostMinus(Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IService>();
                return caller.MinusRes(model);
            }
        }

        [HttpPost]
        public object PostDivision(Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IService>();
                return caller.DivisionRes(model);
            }
        }

        [HttpPost]
        public object PostMultiplication(Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IService>();
                return caller.MultiRes(model);
            }
        }

        [HttpGet]
        public object GetClear()
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IService>();
                return caller.Clear();
            }
        }

        [HttpGet]
        public object GetClearAll()
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IService>();
                return caller.ClearAll();
            }
        }
    }
}
