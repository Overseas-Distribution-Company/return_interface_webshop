using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Shopify_to_Nav
{
    public class WebServer
    {
        private HttpListener _listener = new HttpListener();

        public WebServer()
        {
            const string prefix = "http://*:8080/";
            _listener.Prefixes.Add(prefix);
        }
        
        public void start()
        {
            Console.WriteLine("Server listening");
            _listener.Start();
            while (_listener.IsListening)
            {

                var context = _listener.GetContext();
                var body = new StreamReader(context.Request.InputStream).ReadToEnd();
                dynamic stuff = JObject.Parse(body);
                Console.WriteLine(stuff);
                Console.WriteLine("Awaiting next message");
            }
        }

        private void callback(string response)
        {
            
        }
    }
    

}