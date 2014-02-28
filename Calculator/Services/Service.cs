using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;

namespace Calculator.Services
{
    public class Service : IService
    {
        Repository _repository;

        public Service()
        {
            _repository = new Repository();
        }

        public object AddResult(Model model)
        {
            return _repository.AddRes(model);
        }

        public object ReplaceMemory(Model model)
        {
            return _repository.ReplaceMemory(model);
        }

        public object GetMemory()
        {
            return _repository.GetMemory();
        }

        public object AddToMemory(Model model)
        {
            return _repository.AddToMemory(model);
        }

        public object MinusRes(Model model)
        {
            return _repository.MinusRes(model);
        }

        public object Division(Model model)
        {
            return _repository.DivisionRes(model);
        }

        public object Multiplication(Model model)
        {
            return _repository.MultiRes(model);
        }

        public object Clear()
        {
            return _repository.Clear();
        }
    }
}