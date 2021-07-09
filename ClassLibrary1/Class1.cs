using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bic DevOps Demo!");
             var url = HttpContext.Current.Request.Url.AbsoluteUri;
                            Uri myUri = new Uri(url);
                            var realIpAddress = Dns.GetHostAddresses(myUri.Host)[0].ToString();

        }
    }
    
}
