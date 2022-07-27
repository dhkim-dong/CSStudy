using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Book.Ch12
{
    internal class P538
    {
        static void Main1(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);
            var output = from item in xElement.Descendants("data")
                         select item;

            foreach(var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
