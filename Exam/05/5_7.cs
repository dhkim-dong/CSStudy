﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{
    internal class _5_7
    {
        static void Main1(string[] args)
        {
            while (true)
            {
                Game();
                Console.WriteLine("-------------------");
                Console.WriteLine("0: 종료, 1: 한번 더하기");
                Console.Write("입력 : ");

                int answer = int.Parse(Console.ReadLine());

                if (answer == 0)
                    break;
            }
            Console.WriteLine("게임종료...");
        }

        public static void Game()
        {
            string[] words = { "가위", "바위", "보" };

            string comword = null;
            string youword = null;

            while (true)
            {
                Console.Write("가위, 바위, 보 입력 : ");

                try
                {
                    youword = Console.ReadLine();

                    if (!words.Contains(youword))
                        throw new Exception("가위, 바위, 보 중에서 하나만 내세요.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            }

            Random random = new Random();
            comword = words[random.Next(3)];

            Console.WriteLine("컴퓨터 결과 : " + comword);

            if(comword == "가위" && youword == "가위")
                Console.WriteLine("무승부");
            else if(comword == "가위" && youword == "바위")
                Console.WriteLine("당신의 승리!");
            else if(comword == "가위" && youword == "보")
                Console.WriteLine("컴퓨터 승리!");
            else if(comword == "바위" & youword == "가위")
                Console.WriteLine("컴퓨터 승리!");
            else if (comword == "바위" & youword == "바위")
                Console.WriteLine("무승부");
            else if (comword == "바위" & youword == "보")
                Console.WriteLine("당신의 승리!");
            else if (comword == "보" & youword == "가위")
                Console.WriteLine("당신의 승리!");
            else if (comword == "보" & youword == "바위")
                Console.WriteLine("컴퓨터 승리!");
            else if (comword == "보" & youword == "보")
                Console.WriteLine("무승부");
        }
    }   
}
