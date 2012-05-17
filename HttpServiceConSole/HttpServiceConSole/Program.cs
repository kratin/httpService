using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace HttpServiceConSole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Test");
            //Console.ReadLine(); 
            WebClient wc = new WebClient();

            string WebURL = @"http://localhost:50316/service.asmx";//@"http://www.google.co.th";
            UTF8Encoding encUTF8 = new UTF8Encoding();
            string returnedData = "";

            try
            {
                Console.WriteLine(WebURL);
                Console.WriteLine("Connecting...");

                returnedData = encUTF8.GetString(wc.DownloadData(WebURL));

                Console.WriteLine(returnedData);
                Console.WriteLine("Download data complete ");

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR :: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
