using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceInjection;
namespace DI_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementResult obj = new ImplementResult();
            string resultValue = obj.getResult();
            string resultProduct = obj.getResultFromProduct();
        }
    }
}
