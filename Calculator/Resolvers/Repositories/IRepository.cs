using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Resolvers.Repositories
{
    public interface IRepository
    {
        Model AddRes(Model model);
        Model ReplaceMemory(Model model);
        Model GetMemory();
        Model AddToMemory(Model model);
        Model MinusRes(Model model);
        Model DivisionRes(Model model);
        Model MultiRes(Model model);
        Model Clear();
        Model ClearAll();
    }
}
