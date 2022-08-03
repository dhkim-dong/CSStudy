namespace Project4
{
    public partial class Form1 : Form
    {
        // �׷��� ��ü ����
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

        double slope = 0; // �� ����
        double dir = 0;   // -1 : ���� 1: �Ʒ���

        bool[] blockVisible = new bool[100];

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // �� ������
            this.ClientSize = new Size(300, 500);
            this.Text = "�������� v1.0";

            // �׷��� ��ü ����
            g = this.CreateGraphics();

            // �� �ʱ�ȭ
            InitBlock();

            // ���� �ʱ�ȭ
            InitRacket();

            // �� �ʱ�ȭ
            InitBall();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // ���� �׸���
            for (int i = 0; i < nBlock; i++)
            {
                if (blockVisible[i])
                {
                    g.FillRectangle(blockBrush, blockList[i]);
                }
            }
            // ���� �׸���
            g.FillRectangle(rackBrush, racket);
            // �� �׸���
            g.FillEllipse(ballBrush, ball);
            g.DrawEllipse(pen,ball);
        }

        public void InitBlock()
        {
            for (int i = 0; i < nBlock; i++)
            {
                blockList.Add(new Rectangle(blockW * (i % 10),
                    blockY + blockH * (i / 10),  // nBlock�� 100���� �۾ƾ� �Ѵ�.
                    blockW - 1,
                    blockH - 1));  

                blockVisible[i] = true;
            }
        }
        public void InitRacket()
        {
            racket.X = this.Width / 2 - racketW/2; // Form Size Width�� ����(�߾�) �̵� �ߴ��� ������ ���ݸ�ŭ +�Ǿ���. �ش� ��ġ��ŭ ���ش�.
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

            //���� �ʱ�ȭ
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

            // ball�� �¿� ���� �浹 ���� ��
            if (ball.X <= 0 || ball.X >= this.Width - ballW)
            {
                slope *= -1;
            }

            // ball�� ���Ͽ� �浹 ���� ��
            if(ball.Y <0 || racket.IntersectsWith(ball))
            {
                dir *= -1;
            }

            // ball�� ������ �浹 ���� ��
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

                DialogResult result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?", "Ȯ��", MessageBoxButtons.YesNo);

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


            // �� �׸���
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