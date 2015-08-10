using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
1

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpRequestMessage request = new HttpRequestMessage();

            Console.WriteLine(request.ToString());

            string a = "dsfsadf";

            a = null;


            string tokenDetailsString = string.Empty;

            using (StreamReader sr = new StreamReader(""))
            {
                tokenDetailsString = sr.ReadToEnd();
            }
        }
    }
}
