using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TScreen screen = new TScreen(15,15);
            Block NewBlock = new Block(screen);
            Random random = new Random();
            int minoValue = 0; // 1 : I, 2: o, 3 : z, 4 : s, 5 : j, 6: l , 7:T 
            bool nextBlock = true;

            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine();
                
                screen.Reset(15, 15);
                NewBlock.Move(info);
             
                if (nextBlock)
                {
                    minoValue = random.Next(1, 8);
                    nextBlock = false;
                }
                switch (minoValue)
                {
                    case 1:
                        NewBlock.I_mino();
                        break;
                    case 2:
                        NewBlock.O_mino();
                        break;
                    case 3:
                        NewBlock.Z_mino();
                        break;
                    case 4:
                        NewBlock.S_mino();
                        break;
                    case 5:
                        NewBlock.J_mino();
                        break;
                    case 6:
                        NewBlock.L_mino();
                        break;
                    case 7:
                        NewBlock.T_mino();
                        break;
                    default:
                        break;
                }
                if (NewBlock.isGround)
                {
                    nextBlock = true;
                }
                screen.checkTetris(15, 15);
                NewBlock.ResetPos();
                screen.Render();
            }
        }
    }
}
