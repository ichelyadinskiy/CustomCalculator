using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public interface IRepository
    {
        object AddRes(Model model);
        object ReplaceMemory(Model model);
        object GetMemory();
        object AddToMemory(Model model);
        object MinusRes(Model model);
        object DivisionRes(Model model);
        object MultiRes(Model model);
        object Clear();
    }
}
