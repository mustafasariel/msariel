using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
      
            ServiceReference1.CalculatorSoapClient client = new ServiceReference1.CalculatorSoapClient();
            var result = client.Add(6, 5);

            Console.WriteLine(result);

        }
    }
}
