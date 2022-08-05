using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._10
{
    interface IRuunable
    {
        public void Run();
    }

    interface IFlyable
    {
        public void Fly();
    }
    internal class _10_07
    {
        class FlyingCar : IRuunable, IFlyable
        {
            public void Run()
            {
                Console.WriteLine("Car Run!");
            }

            public void Fly()
            {
                Console.WriteLine("Car Fly!");
            }
        }


        static void Main1(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRuunable runable = car as IRuunable;
            IFlyable flyable = car as IFlyable;

            runable.Run();
            flyable.Fly();
        }
    }
}
