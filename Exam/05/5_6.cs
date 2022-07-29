using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{
    [Serializable]
    class orange
    {
        private string country;
        private int price;

        public orange(string country, int price)
        {
            this.country = country;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("원산지 : " + country);
            Console.WriteLine("가격   : " + price);
        }
    }

    internal class _5_6
    {
        static void Main1(string[] args)
        {
            string path = "C:\\Users\\502\\Desktop\\Orange.dat";

            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                orange orange = new orange("캘리포니아", 5000);
                serializer.Serialize(fs, orange);
            }

            using(FileStream fs = new FileStream(path,FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter deserializer = new BinaryFormatter();

                orange orange = (orange)deserializer.Deserialize(fs);
                orange.Show();
            }
        }
    }
}
