using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Services
{
    public class Repository : IRepository
    {
        public static Model serverModel = new Model
        {
            Current = 0,
            Memory = 0,
            Result = 0
        };

        public object AddRes(Model model)
        {
            serverModel.Result += model.Current;
            return serverModel;
        }

        public object ReplaceMemory(Model model)
        {
            serverModel.Memory = model.Current;
            return serverModel;
        }

        public object GetMemory()
        {
            return serverModel;
        }

        public object AddToMemory(Model model)
        {
            serverModel.Memory += model.Current;
            serverModel.Current = 0;
            return serverModel;
        }

        public object MinusRes(Model model)
        {
            serverModel.Result -= model.Current;
            return serverModel;
        }

        public object DivisionRes(Model model)
        {
            serverModel.Result /= model.Current;
            return serverModel;
        }

        public object MultiRes(Model model)
        {
            serverModel.Result *= model.Current;
            return serverModel;
        }

        public object Clear()
        {
            serverModel.Current = 0;
            return serverModel;
        }
    }
}