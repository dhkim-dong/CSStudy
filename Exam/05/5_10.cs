using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{
    internal class _5_10
    {
        static void Main1(string[] args)
        {
            string[] arrNames = new string[5];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";

            var output = from item in arrNames
                        orderby item ascending
                        select item;

            Console.WriteLine("배열");
            foreach(string name in output)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            List<string> lstNames = new List<string>();
            lstNames.Add("dog");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");

            var r2 = from item in lstNames
                         orderby item ascending
                         select item;
            Console.WriteLine("리스트");
            foreach(string item in r2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
