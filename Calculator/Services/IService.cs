using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public interface IService
    {
        object AddResult(Model model);
        object ReplaceMemory(Model model);
        object GetMemory();
        object AddToMemory(Model model);
        object MinusRes(Model model);
        object Division(Model model);
        object Multiplication(Model model);
        object Clear();
    }
}
