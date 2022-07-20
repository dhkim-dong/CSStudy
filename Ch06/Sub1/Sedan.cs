using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Sedan : Car
    {
        private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public override void SpeedDown(int speed)
        {
            base.speed -= speed;
            Console.WriteLine("Sedan SpeedDown... "  );
        }

        public override void SpeedUp(int speed)
        {
            base.speed += speed;
            Console.WriteLine("Sedan SpeedUp...");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("배기량 : "+ cc);
            Console.WriteLine("-----------------------");
        }
    }
}
