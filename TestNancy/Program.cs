using System;
using Nancy;
using Nancy.Hosting.Self;

namespace TestNancy
{
    public class Program : NancyModule
    {
        static void Main(string[] args)
        {
            HostConfiguration hostConfigs = new HostConfiguration()
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };

            var uri = new Uri("http://localhost:5001");
            var nHost = new NancyHost(hostConfigs, uri);
            Console.Write("Nancy listening..." + uri);
            Console.Write("\nPress any key to exit");
            nHost.Start();
            Console.Read();
            nHost.Stop();
        }
    }
}
