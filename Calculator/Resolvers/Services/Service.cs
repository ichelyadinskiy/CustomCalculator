using Autofac;
using Calculator.Resolvers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Resolvers.Services
{
    public class Service : IService
    {
        IContainer container;
        ContainerBuilder builder;

        public Service()
        {
            builder = new ContainerBuilder();
            builder.RegisterType<Repository>().As<IRepository>();
            container = builder.Build();
        }

        public Models.Model AddRes(Models.Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IRepository>();
                return caller.AddRes(model);
            }
        }

        public Models.Model ReplaceMemory(Models.Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IRepository>();
                return caller.ReplaceMemory(model);
            }
        }

        public Models.Model GetMemory()
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IRepository>();
                return caller.GetMemory();
            }
        }

        public Models.Model AddToMemory(Models.Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IRepository>();
                return caller.AddToMemory(model);
            }
        }

        public Models.Model MinusRes(Models.Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IRepository>();
                return caller.MinusRes(model);
            }
        }

        public Models.Model DivisionRes(Models.Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IRepository>();
                return caller.DivisionRes(model);
            }
        }

        public Models.Model MultiRes(Models.Model model)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IRepository>();
                return caller.MultiRes(model);
            }
        }

        public Models.Model Clear()
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IRepository>();
                return caller.Clear();
            }
        }

        public Models.Model ClearAll()
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var caller = scope.Resolve<IRepository>();
                return caller.ClearAll();
            }
        }
    }
}