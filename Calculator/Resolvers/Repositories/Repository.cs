using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Resolvers.Repositories
{
    public class Repository : IRepository
    {
        public static Model serverModel = new Model
        {
            Current = 0,
            Memory = 0,
            Result = 0
        };

        public Model AddRes(Model model)
        {
            serverModel.Result += model.Current;
            return serverModel;
        }

        public Model ReplaceMemory(Model model)
        {
            serverModel.Memory = model.Current;
            return serverModel;
        }

        public Model GetMemory()
        {
            serverModel.Current = serverModel.Memory;
            return serverModel;
        }

        public Model AddToMemory(Model model)
        {
            serverModel.Memory += model.Current;
            serverModel.Current = 0;
            return serverModel;
        }

        public Model MinusRes(Model model)
        {
            serverModel.Result -= model.Current;
            return serverModel;
        }

        public Model DivisionRes(Model model)
        {
            serverModel.Result /= model.Current;
            return serverModel;
        }

        public Model MultiRes(Model model)
        {
            serverModel.Result *= model.Current;
            return serverModel;
        }

        public Model Clear()
        {
            serverModel.Current = 0;
            return serverModel;
        }

        public Model ClearAll()
        {
            serverModel.Current = 0;
            serverModel.Memory = 0;
            serverModel.Result = 0;
            return serverModel;
        }
    }
}