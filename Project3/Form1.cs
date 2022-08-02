namespace Project3
{
    public partial class Form1 : Form
    {
        int margin = 40;
        int gridSize = 30;
        int stoneSize = 28;
        int flowerSize = 10;

        bool isWhite = true;
        bool isBlack = false;
        enum STONE { NONE, BLACK, WHITE}

        STONE[,] dataSet = new STONE[19, 19];


        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        public Form1()
        {
            InitializeComponent();

            this.Text = "오목";
            this.BackColor = Color.Orange;

            pen = new Pen(Color.Black);
            bBrush = new SolidBrush(Color.Black);
            wBrush = new SolidBrush(Color.White);

            this.ClientSize = new Size(2 * margin + 18 * gridSize,
                2 * margin + 18 + menuStrip1.Height);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + gridSize/2)/ gridSize;
            int y = (e.Y - margin + gridSize/2)/ gridSize;
            //Console.WriteLine($"x :{x}, y : {y}");

            Rectangle stone = new Rectangle(margin + gridSize * x - gridSize /2,
                margin + gridSize * y - gridSize /2,
                stoneSize,
                stoneSize);
            // 돌이 놓여있는지 확인
            if (dataSet[x,y] != STONE.NONE)
            {
                MessageBox.Show("이미 돌이 놓여있습니다.", "에러");
                return;
            }

            // 돌 그리기
            if (isWhite)
            {
                g.FillEllipse(wBrush, stone);
                dataSet[x, y] = STONE.WHITE;
                isWhite = false;
                isBlack = true;
            }
            else
            {
                g.FillEllipse(bBrush, stone);
                dataSet[x, y] = STONE.BLACK;
                isWhite = true;
                isBlack = false;
            }

            // 오목 판정
            CheckOmok(x,y);
        }

        public void CheckOmok(int x, int y)
        {

            // 왼쪽(오른쪽 검사)
            int count = 1;

            for (int i = x+1; i < 19; i++)
            {
                if (dataSet[x, y] == dataSet[i, y])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            CheckCountResult(count);



            // 오른쪽(왼쪽 검사)
            count = 1;

            for (int i = x - 1; i >= 0; i--)
            {
                if (dataSet[x, y] == dataSet[i, y])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            CheckCountResult(count);

            // 위쪽(아래쪽 검사)

            count = 1;

            for (int i = y + 1; i < 19; i++)
            {
                if (dataSet[x, y] == dataSet[x, i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            CheckCountResult(count);

            // 아래쪽(위쪽 검사)

            count = 1;

            for (int i = y - 1; i >= 0; i--)
            {
                if (dataSet[x, y] == dataSet[x, i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);
            // 11시 (11시 방향위 검사)
            count = 1;

            for (int i = x-1, j = y-1; i >=0 && j>=0 ; i--,j--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            CheckCountResult(count);

            // 16시

            count = 1;

            for (int i = x + 1, j = y + 1; i < 19 && j < 19; i++, j++)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);

            // 13시

            count = 1;

            for (int i = x + 1, j = y - 1; i < 19 && j >= 0; i++, j--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);

            // 19시

            count = 1;

            for (int i = x - 1, j = y + 1; i >= 0 && j < 19; i--, j++)
            {
                if (dataSet[x , y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);
        }

        public void CheckCountResult(int count)
        {
            if(count >= 5)
            {
                DialogResult result = MessageBox.Show("오목 입니다! 새로운 게임을 시작 할까요?",
                    "확인",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    NewGame();
                    return;
                }
                else
                    this.Close();
            }
        }

        public void NewGame()
        {
            // 화면 갱신
            this.Invalidate();
           

            // dataset 초기화

            for (int y = 0; y < 19; y++)
            {
                for (int x = 0; x < 19; x++)
                {
                    dataSet[x, y] = STONE.NONE;
                }
            }

            // 흰돌 시작
            isWhite = true;
        }


        private void DrawBoard()
        {
            g = panel1.CreateGraphics();


            //세로선 19개
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + i * gridSize, margin),
                    new Point(margin + i * gridSize, margin + 18 * gridSize));
            }

            //가로줄
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin, margin + i * gridSize),
                    new Point(margin + 18 * gridSize, margin + i * gridSize));
            }

            // 화점 그리기
            for (int x = 3; x <= 15; x+=6)
                for (int y = 3; y <= 15; y +=6)
                {
                    g.FillEllipse(bBrush,
                        margin + gridSize * x - flowerSize / 2,
                        margin + gridSize * y - flowerSize / 2,
                        flowerSize, flowerSize);
                }

            

        }
    }
}