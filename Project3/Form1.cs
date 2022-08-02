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

            this.Text = "����";
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
            // ���� �����ִ��� Ȯ��
            if (dataSet[x,y] != STONE.NONE)
            {
                MessageBox.Show("�̹� ���� �����ֽ��ϴ�.", "����");
                return;
            }

            // �� �׸���
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

            // ���� ����
            CheckOmok(x,y);
        }

        public void CheckOmok(int x, int y)
        {

            // ����(������ �˻�)
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



            // ������(���� �˻�)
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

            // ����(�Ʒ��� �˻�)

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

            // �Ʒ���(���� �˻�)

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
            // 11�� (11�� ������ �˻�)
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

            // 16��

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

            // 13��

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

            // 19��

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
                DialogResult result = MessageBox.Show("���� �Դϴ�! ���ο� ������ ���� �ұ��?",
                    "Ȯ��",
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
            // ȭ�� ����
            this.Invalidate();
           

            // dataset �ʱ�ȭ

            for (int y = 0; y < 19; y++)
            {
                for (int x = 0; x < 19; x++)
                {
                    dataSet[x, y] = STONE.NONE;
                }
            }

            // �� ����
            isWhite = true;
        }


        private void DrawBoard()
        {
            g = panel1.CreateGraphics();


            //���μ� 19��
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + i * gridSize, margin),
                    new Point(margin + i * gridSize, margin + 18 * gridSize));
            }

            //������
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin, margin + i * gridSize),
                    new Point(margin + 18 * gridSize, margin + i * gridSize));
            }

            // ȭ�� �׸���
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