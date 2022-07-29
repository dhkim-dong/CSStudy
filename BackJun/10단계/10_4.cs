using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._10단계
{
    internal class _10_4
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            // 모든 체스판을 검정과 흰색의 데이터로 표현하시오.
            // 체스판을 8개로 짜른 다음 모든 8*8의 데이터를 비교해서 최솟값을 출력하세요. (브루트 포스)

            int[][] board = new int[N][];

            // 입력
            for (int y = 0; y < N; y++)
            {
                board[y] = new int[M];
                string input = Console.ReadLine();

                for (int x = 0; x < M; x++)
                {                    
                    if (input[x] == 'W')
                    {
                        board[y][x] = 0;
                    }
                    else 
                        board[y][x] = 1;
                }
            }

            // 8개를 어디서 부터 시작해서 끝낼까?
            // 0부터 ~ 8까지 ->  M-8 부터   M까지 
            // 즉 시작이 0인 것 부터 M-8일 때 까지 전부 돌리면된다.
            // 높이 역시 0부터 N-8까지 전부 돌리면 된다.

            // 시작이 W일때
            int answer = 0;
            int a = 0;
            int MaxCount = 64;
            for (int y = 0; y < N - 7; y++)
            {
                for (int x = 0; x < M - 7; x++)
                {
                    answer = 0;
                    a = 0;
                    for (int k = y; k < y + 8; k++)
                    {
                        for (int j = x; j < x + 8; j++)
                        {
                            if (board[k][j] != a % 2 ) // 흰색이 아닐때
                            {
                                answer++;
                            }
                            a++;
                        }
                        a++;
                    }
                    if (MaxCount > answer)
                        MaxCount = answer;


                    answer = 0;
                    a = 1;
                    for (int k = y; k < y + 8; k++)
                    {
                        for (int j = x; j < x + 8; j++)
                        {
                            if (board[k][j] != a % 2) // 흰색이 아닐때
                            {
                                answer++;
                            }
                            a++;
                        }
                        a++;
                    }
                    if (MaxCount > answer)
                        MaxCount = answer;
                }
            }

            Console.WriteLine(MaxCount);
            // 바깥 x,y의 반복문을 통해 모든 경우의 8x8 보드판을 검사한다.

            // 내부 코드 = 8byb에서 얼마나 바꿔야 하는지?
        }
    }
}
