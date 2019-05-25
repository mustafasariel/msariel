using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman
{
    class Program
    {
        static void Main(string[] args)
        {

            Serializer serializer = new Serializer();
            var result = serializer.Deserialize<Postman.Multiple.Envelope>(Multiply(3, 5));

            Console.WriteLine(result.Body.MultiplyResponse.MultiplyResult);
        }

       static string getMultiplyXmlContent()
        {
            StreamReader read = new StreamReader(@"C:\Users\MSARIEL\source\repos\havadurumu\Postman\Multiply.xml");
            string xmlContent = read.ReadToEnd();
            read.Close();
            return xmlContent;
        }
        static string Multiply(int number1, int number2)
        {
            string xmlContent = getMultiplyXmlContent();

            xmlContent= xmlContent.Replace("{number1}", number1.ToString()).Replace("{number2}", number2.ToString());
   
            var client = new RestClient("http://www.dneonline.com/calculator.asmx?op=Multiply");
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "78a13b9f-54fe-38f7-d4a0-005259deec26");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("soapaction", "\"http://tempuri.org/Multiply\"");
            request.AddHeader("content-type", "text/xml; charset=utf-8");
            request.AddParameter("text / xml; charset = utf - 8", xmlContent, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.Content;
        }

    }
}
