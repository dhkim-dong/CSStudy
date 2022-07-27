using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Book.Ch12
{
    internal class P539
    {
        static void Main1(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);
            var output = from item in xElement.Descendants("data")
                         select item;

            foreach (var item in output)
            {
                Console.Write(item.Element("hour").Value + "\t");
                Console.Write(item.Element("day").Value + "\t");
                Console.Write(item.Element("temp").Value + "\t");
                Console.Write(item.Element("wdKor").Value + "\t");
                Console.Write(item.Element("wfKor").Value + "\t");
                Console.Write(item.Element("tmn").Value + "\t");
                Console.Write(item.Element("tmx").Value + "\t");
                Console.WriteLine();
            }
        }
    }
}
