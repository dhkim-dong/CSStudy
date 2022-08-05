using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    enum BLOCKTYPE 
    {
        BT_I,
        BT_O,
        BT_Z,
        BT_S,
        BT_J,
        BT_L,
        BT_T
    }

    internal class Block
    {
        int x = 7;
        int y = 0;
        int stateNum = 1; // 1: 기본 2: 회전 3: 회전2 4: 회전3
        TBLOCK NewTBlock = TBLOCK.BLOCK;

        TScreen Screen = null;

        public bool isGround = false;

        public Block(TScreen Screen)
        {
            this.Screen = Screen;
        }

        public void Move(ConsoleKeyInfo info)
        {
            switch (info.Key)
            {
                case ConsoleKey.A:
                    x -= 1;
                    y += 1;
                    break;
                case ConsoleKey.D:
                    y += 1;
                    x += 1;
                    break;
                case ConsoleKey.S:
                    y += 1;
                    break;
                case ConsoleKey.R:
                    stateNum++;
                    y += 1;
                    break;
                default:
                    break;
            }        
        }

        // 문제점 : 도형 마다 x의 크기가 다르기 때문에 모두 설정 해준다?
        public void Ground_mino(int x, int y)
        {
            if (Screen.BlockList[y + 1][x] != TBLOCK.VOID)
                isGround = true;
        }
        public void Ground_mino(int x1,int x2, int y)
        {
            if (Screen.BlockList[y + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y + 1][x2] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Zmino(int x1,int x2, int x3, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 2][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 2][x3] != TBLOCK.VOID)
                isGround = true;
        }
        public void Ground_Smino(int x1, int x2, int x3, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 2][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y1 + 2][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x3] != TBLOCK.VOID)
                isGround = true;
        }
        public void Ground_Tmino(int x1, int x2, int x3, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 2][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y1 + 1][x3] != TBLOCK.VOID)
                isGround = true;
        }
        public void Ground_mino(int x1,int x2, int x3, int x4, int y)
        {
            if (Screen.BlockList[y + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y + 1][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y + 1][x3] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y + 1][x4] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_mino_R(int x1, int x2, int x3,int x4,int y)
        {
            if (Screen.BlockList[y + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y + 1][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y + 1][x3] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y + 1][x4] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Zmino_R(int x1, int x2, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x2] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Smino_R(int x1, int x2, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x2] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Jmino_R1(int x1, int x2, int x3, int y)
        {
            if (Screen.BlockList[y + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y + 1][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y + 1][x3] != TBLOCK.VOID)
                isGround = true;
        }
        
        public void Ground_Jmino_R2(int x1, int x2, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x2] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Jmino_R3(int x1, int x2, int x3, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y1 + 1][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x3] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Lmino_R1(int x1, int x2, int x3, int y1, int y2) 
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x3] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Lmino_R2(int x1, int x2, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x2] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Lmino_R3(int x1, int x2, int x3, int y1)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y1 + 1][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y1 + 1][x3] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Tmino_R1(int x1, int x2, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x2] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Tmino_R2(int x1, int x2, int x3, int y1)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y1 + 1][x2] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y1 + 1][x3] != TBLOCK.VOID)
                isGround = true;
        }

        public void Ground_Tmino_R3(int x1, int x2, int y1, int y2)
        {
            if (Screen.BlockList[y1 + 1][x1] != TBLOCK.VOID)
                isGround = true;
            if (Screen.BlockList[y2 + 1][x2] != TBLOCK.VOID)
                isGround = true;
        }

        public void ResetPos()
        {
            if (isGround)
            {
                x = 7;
                y = 0;
                isGround = false;
            }
        }

        public void I_mino()
        {
            if (stateNum > 2)
                stateNum = 1;

            if(stateNum == 1)
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 2, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 3, x, TBLOCK.BLOCK);
                Ground_mino(x, y + 3);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 3, x, TBLOCK.DUMMY);
                }
            }
            else
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y, x + 1, TBLOCK.BLOCK);
                Screen.SetBlock(y, x + 2, TBLOCK.BLOCK);
                Screen.SetBlock(y, x + 3, TBLOCK.BLOCK);
                Ground_mino_R(x, x + 1, x + 2, x + 3, y);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 2, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 3, TBLOCK.DUMMY);
                }
            }

        }


        public void O_mino()
        {
            Screen.SetBlock(y, x, TBLOCK.BLOCK);
            Screen.SetBlock(y, x+1, TBLOCK.BLOCK);
            Screen.SetBlock(y+1, x, TBLOCK.BLOCK);
            Screen.SetBlock(y+1, x+1, TBLOCK.BLOCK);

            Ground_mino(x + 1, y + 1);
            if (isGround)
            {
                Screen.SetBlock(y, x, TBLOCK.DUMMY);
                Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
            }
        }

        public void Z_mino()
        {
            if (stateNum > 2)
                stateNum = 1;

            if (stateNum == 1)
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y, x + 1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x + 1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x + 2, TBLOCK.BLOCK);

                Ground_Zmino(x, x + 1, x + 2, y, y);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 2, TBLOCK.DUMMY);
                }
            }
            else
            {
                Screen.SetBlock(y, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y+2, x, TBLOCK.BLOCK);

                Ground_Zmino_R(x, x + 1, y + 2, y + 1);
                if (isGround)
                {
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x, TBLOCK.DUMMY);
                }          
            }
        }

        public void S_mino()
        {
            if (stateNum > 2)
                stateNum = 1;

            if (stateNum == 1)
            {
                Screen.SetBlock(y, x + 1, TBLOCK.BLOCK);
                Screen.SetBlock(y, x + 2, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x + 1, TBLOCK.BLOCK);

                Ground_Smino(x, x + 1, x + 2, y, y);
                if (isGround)
                {
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 2, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                }
            }
            else
            {
                Screen.SetBlock(y, x , TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x , TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x+1 , TBLOCK.BLOCK);
                Screen.SetBlock(y+2, x+1 , TBLOCK.BLOCK);

                Ground_Smino_R(x, x + 1, y + 1, y + 2);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x + 1, TBLOCK.DUMMY);
                }

            }

        }

        public void J_mino()
        {
            if (stateNum > 4)
                stateNum = 1;

            if(stateNum == 1)
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 2, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 2, x - 1, TBLOCK.BLOCK);

                Ground_mino(x - 1, x, y + 2);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x - 1, TBLOCK.DUMMY);
                }
            }

            if(stateNum == 2) 
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x+2, TBLOCK.BLOCK);

                Ground_Jmino_R1(x, x + 1, x + 2, y + 1);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 2, TBLOCK.DUMMY);
                }
            }

            if(stateNum == 3) 
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 2, x, TBLOCK.BLOCK);

                Ground_Jmino_R2(x, x + 1, y + 2, y);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x, TBLOCK.DUMMY);
                }
            }
            if(stateNum == 4)
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y, x+2, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x+2, TBLOCK.BLOCK);

                Ground_Jmino_R3(x, x + 1, x + 2, y, y + 1);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 2, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 2, TBLOCK.DUMMY);
                }
            }
            
        }

        public void L_mino()
        {
            if (stateNum > 4)
                stateNum = 1;


            if(stateNum == 1) 
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 2, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 2, x + 1, TBLOCK.BLOCK);

                Ground_mino(x, x + 1, y + 2);

                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x + 1, TBLOCK.DUMMY);
                }
            }

            if(stateNum ==2) 
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y, x+2, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x, TBLOCK.BLOCK);

                Ground_Lmino_R1(x, x + 1, x + 2, y + 1, y);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 2, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                }
            }

            if (stateNum == 3)
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 2, x + 1, TBLOCK.BLOCK);

                Ground_Lmino_R2(x, x+1, y, y+2);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x + 1, TBLOCK.DUMMY);
                }
            }
            if (stateNum == 4)
            {
                Screen.SetBlock(y, x+2, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x + 2, TBLOCK.BLOCK);

                Ground_Lmino_R3(x, x+1, x+2, y+1);
                if (isGround)
                {
                    Screen.SetBlock(y, x + 2, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 2, TBLOCK.DUMMY);
                }
            }

        }

        public void T_mino()
        {
            if (stateNum > 4)
                stateNum = 1;

            if(stateNum == 1)
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y, x - 1, TBLOCK.BLOCK);
                Screen.SetBlock(y, x + 1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x, TBLOCK.BLOCK);

                Ground_Tmino(x - 1, x, x + 1, y, y);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x - 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                }
            }       
            
            if(stateNum == 2)
            {
                Screen.SetBlock(y, x, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x + 1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 2, x, TBLOCK.BLOCK);

                Ground_Tmino_R1(x, x+1, y+2, y+1);
                if (isGround)
                {
                    Screen.SetBlock(y, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x, TBLOCK.DUMMY);
                }
            }
            if(stateNum == 3)
            {
                Screen.SetBlock(y, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x + 1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 1, x+2, TBLOCK.BLOCK);

                Ground_Tmino_R2(x,x+1,x+2,y+1);
                if (isGround)
                {
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 2, TBLOCK.DUMMY);
                }

            }
            if(stateNum == 4)
            {
                Screen.SetBlock(y, x+1, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x, TBLOCK.BLOCK);
                Screen.SetBlock(y+1, x + 1, TBLOCK.BLOCK);
                Screen.SetBlock(y + 2, x+1, TBLOCK.BLOCK);

                Ground_Tmino_R3(x,x+1,y+1,y+2);
                if (isGround)
                {
                    Screen.SetBlock(y, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 1, x + 1, TBLOCK.DUMMY);
                    Screen.SetBlock(y + 2, x + 1, TBLOCK.DUMMY);
                }
            }
        }
    }
}
