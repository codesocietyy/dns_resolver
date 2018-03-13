using System;
using System.Net;

namespace dns_resolver
{
    class init_dns
    {

        public static void dns_resolv()
        {
            Console.WriteLine("Type in the domain:" );
            string hostname = Console.ReadLine(); //enter the domain to resolve
            IPHostEntry ip;
            ip = Dns.GetHostEntry(hostname);


            Console.WriteLine(ip);

            foreach (IPAddress host in ip.AddressList)
            {
                Console.WriteLine("    {0}", host);
            }
        }
    }
   
}
