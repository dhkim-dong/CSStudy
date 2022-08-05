using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    enum TBLOCK { VOID, WALL, BLOCK, DUMMY}

    internal class TScreen
    {
        public List<List<TBLOCK>> BlockList = new List<List<TBLOCK>>();

        public void SetBlock(int y, int x, TBLOCK type)
        {
            BlockList[y][x] = type;
        }

        public void Render()
        {
            for (int y = 0; y < BlockList.Count; y++)
            {
                for (int x = 0; x < BlockList[y].Count; x++)
                {
                    switch (BlockList[y][x])
                    {
                        case TBLOCK.VOID:
                            Console.Write("□");
                            break;
                        case TBLOCK.WALL:
                            Console.Write("■");
                            break;
                        case TBLOCK.BLOCK:
                            Console.Write("▣");
                            break;
                        case TBLOCK.DUMMY:
                            Console.Write("▦");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

       
        public TScreen(int x, int y)
        {
            for (int i = 0; i < y; i++)
            {
                BlockList.Add(new List<TBLOCK>());
                for (int j = 0; j < x; j++)
                {
                    BlockList[i].Add(TBLOCK.VOID);
                }
            }

            // 맨 아랫줄 벽
            for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
            {
                BlockList[BlockList.Count - 1][i] = TBLOCK.WALL;
            }
        }

        // 이전 테트리스 블록 리셋 (더미 발생 시 리셋에 반영할 것)
        public void Reset(int x, int y)
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (BlockList[i][j] == TBLOCK.BLOCK)
                        BlockList[i][j] = TBLOCK.VOID;
                }
            }
        }

        public void tetrisInfo(int x, int y)
        {
            while(y > 1)
            {
                for (int i = 0; i < x; i++)
                {
                    BlockList[y][i] = BlockList[y - 1][i];
                }
                y--;
            }
        }

        public void checkTetris(int x, int y)
        {
            bool istetris = true;
            for (int i = 0; i < y-1; i++)
            {
                istetris = true;
                for (int j = 0; j < x-1; j++)
                {
                    // 1부터 마지막 벽 -1 만큼의 모든 블럭이 DUMMY 일때 VOID해줄것
                    if (BlockList[i][j] != TBLOCK.DUMMY)
                    {
                        istetris = false;
                    }
                }

                // 테트리스가 시작된 지점부터 위에 있는 정보를 가지고 온다.
                if(istetris)
                    tetrisInfo(15,i);
            }
        }
    }
}
