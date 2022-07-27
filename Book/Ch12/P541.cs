using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Book.Ch12
{
    internal class P541
    {
        static void Main1(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);
            var output = from item in xElement.Descendants("data")
                         select new
                         {
                             Hour = item.Element("hour").Value,
                             Day = item.Element("day").Value,
                             Temp = item.Element("temp").Value,
                             WdKor = item.Element("wdKor").Value,
                             WfKor = item.Element("wfKor").Value,
                             Tmn = item.Element("tmn").Value,
                             Tmx = item.Element("tmx").Value,
                         };
            foreach(var item in output)
            {
                Console.Write(item.Hour + "\t");
                Console.Write(item.Day + "\t");
                Console.Write(item.Temp + "\t");
                Console.Write(item.WdKor + "\t");
                Console.Write(item.WfKor + "\t");
                Console.Write(item.Tmn + "\t");
                Console.Write(item.Tmx + "\t");
                Console.WriteLine();
            }
        }
    }
}
