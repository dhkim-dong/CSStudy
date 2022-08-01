namespace Project1
{
    public partial class Form1 : Form
    {
        private int savedNum = 0;
        private int result = 0;
        private int operate = 0; // Plus : 1 Minus : 2 Mulit :3 Div : 4
        private string saveString;

        public Form1()
        {
            InitializeComponent();

        }


       
        private void btnEql_Click(object sender, EventArgs e)
        {

            switch (operate)
            {
                case 1: result = savedNum + int.Parse(txtResult.Text);
                break;
                case 2: result = savedNum - int.Parse(txtResult.Text);
                break;
                case 3: result = savedNum * int.Parse(txtResult.Text);
                break;
                case 4: result = savedNum / int.Parse(txtResult.Text);
                break;
            }

            txtResult.Text = result.ToString();
            saveString = null;
        }

        private void btnNum_Click_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            
            saveString += btn.Tag.ToString();
            if (saveString[0] == '0')
            {          
                saveString = null;
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text = saveString;
            }
        }

        private void btnOpearate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Console.WriteLine(btn.Tag);

            operate = int.Parse(btn.Tag.ToString());

            savedNum = int.Parse(txtResult.Text);

            saveString = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            saveString = null;
        }
    }
}