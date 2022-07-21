using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnonApi_CSharp.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnonApi anonApi = new AnonApi();
            Console.WriteLine(anonApi.sendFile(@"").Data.file.url.full);
            Thread.Sleep(5000);
        }
    }
}
