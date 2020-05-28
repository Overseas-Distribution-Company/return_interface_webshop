using System;
using System.IO;
using System.Net;
using System.Text;

namespace Shopify_to_Nav
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new WebServer();
            server.start();
        }
    }
}