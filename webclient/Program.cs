using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webclient
{
    class Program
    {
        static void Main(string[] args)
        {


            var client = new RestClient("http://www.dneonline.com/calculator.asmx?op=Multiply");
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "78a13b9f-54fe-38f7-d4a0-005259deec26");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("soapaction", "\"http://tempuri.org/Multiply\"");
            request.AddHeader("content-type", "text/xml; charset=utf-8");
            request.AddParameter("text/xml; charset=utf-8", "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">\r\n  <soap:Body>\r\n    <Multiply xmlns=\"http://tempuri.org/\">\r\n      <intA>3</intA>\r\n      <intB>51</intB>\r\n    </Multiply>\r\n  </soap:Body>\r\n</soap:Envelope>", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

        }
    }
}
