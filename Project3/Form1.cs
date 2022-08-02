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