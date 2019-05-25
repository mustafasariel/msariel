using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace havadurumu
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.HavaDurumuSoapClient client = new ServiceReference1.HavaDurumuSoapClient();

            Console.WriteLine(client.GetHavaDurumu();
        }
    }
}
