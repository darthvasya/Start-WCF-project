using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyService.CalculatorClient myService = new MyService.CalculatorClient();
            Console.Write(myService.Addition(2.0, 4).ToString());
            Console.ReadLine();
        }
    }
}
