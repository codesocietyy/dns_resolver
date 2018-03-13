using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dns_resolver
{
    class Program
    {
        static void Main(string[] args)
        {
            init_dns init_dns = new init_dns();
            Console.WriteLine("Initializing DNS resolver...");
            init_dns.dns_resolv();
            Console.ReadKey();

        }
    }
}
