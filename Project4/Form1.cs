namespace Project4
{
    public partial class Form1 : Form
    {
        // 그래픽 객체 선언
        Graphics g;
        Brush rackBrush = new SolidBrush(Color.Red);
        Brush blockBrush = new SolidBrush(Color.Orange);
        Brush ballBrush = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        Rectangle racket = new Rectangle();
        List<Rectangle> blockList = new List<Rectangle>();
        //Rectangle[] blocks = new Rectangle[100];
        Rectangle ball = new Rectangle();

        int nBlock = 20;
        int racketW = 50;
        int racketH = 10;
        int racketY = 480;

        int blockW = 30;
        int blockH = 20;
        int blockY = 60;

        int ballW = 10;
        int ballH = 10;

        double slope = 0; // 공 기울기
        double dir = 0;   // -1 : 위로 1: 아래로

        bool[] blockVisible = new bool[100];

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // 폼 사이즈
            this.ClientSize = new Size(300, 500);
            this.Text = "벽돌깨기 v1.0";

            // 그래픽 객체 생성
            g = this.CreateGraphics();

            // 블럭 초기화
            InitBlock();

            // 라켓 초기화
            InitRacket();

            // 공 초기화
            InitBall();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 벽돌 그리기
            for (int i = 0; i < nBlock; i++)
            {
                if (blockVisible[i])
                {
                    g.FillRectangle(blockBrush, blockList[i]);
                }
            }
            // 라켓 그리기
            g.FillRectangle(rackBrush, racket);
            // 공 그리기
            g.FillEllipse(ballBrush, ball);
            g.DrawEllipse(pen,ball);
        }

        public void InitBlock()
        {
            for (int i = 0; i < nBlock; i++)
            {
                blockList.Add(new Rectangle(blockW * (i % 10),
                    blockY + blockH * (i / 10),  // nBlock이 100보다 작아야 한다.
                    blockW - 1,
                    blockH - 1));  

                blockVisible[i] = true;
            }
        }
        public void InitRacket()
        {
            racket.X = this.Width / 2 - racketW/2; // Form Size Width의 절반(중앙) 이동 했더니 라켓의 절반만큼 +되었다. 해당 수치만큼 빼준다.
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }
        public void InitBall()
        {
            ball.X = this.Width / 2 - ballW / 2;
            ball.Y = ballH + blockY * 4;
            ball.Width = ballW;
            ball.Height = ballH;

            //기울기 초기화
            slope = rand.Next(1,20) / 10.0;  // 0.1 ~ 1.9

            if (rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }

            dir = 1;
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("Tick!");
            double dx = ballW / slope;
            double dy = ballH * Math.Abs(slope) * dir;

            int x = (int)dx;
            int y = (int)dy;

            ball.X += x;
            ball.Y += y;

            // ball이 좌우 벽에 충돌 했을 때
            if (ball.X <= 0 || ball.X >= this.Width - ballW)
            {
                slope *= -1;
            }

            // ball이 라켓에 충돌 했을 때
            if(ball.Y <0 || racket.IntersectsWith(ball))
            {
                dir *= -1;
            }

            // ball이 벽돌에 충돌 했을 때
            for (int i = 0; i < nBlock; i++)
            {
                if (ball.IntersectsWith(blockList[i]))
                {
                    dir *= -1;
                    blockVisible[i] = false;
                }
            }

            // GameOver
            if(ball.Y > this.Height)
            {
                myTimer.Stop();

                DialogResult result = MessageBox.Show("다시 시작하시겠습니까?", "확인", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    InitBlock();
                    InitBall();
                    InitRacket();

                    myTimer.Start();
                }
                else
                {
                    this.Close();
                }
            }


            // 공 그리기
            this.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= racket.Width;
            }

            if(e.KeyCode == Keys.Right)
            {
                racket.X += racket.Width;
            }
        }
    }
}