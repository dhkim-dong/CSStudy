namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼1 입니다.");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 2 입니다.", "버튼2");
        }

        private void btnChkFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chkFruits = {chkFruit1,chkFruit2,chkFruit3,chkFruit4,chkFruit5};
            List<string> fruits = new List<string>();

            foreach(CheckBox chk in chkFruits)
            {
                if (chk.Checked)
                {
                    fruits.Add(chk.Text);
                }
            }

            lbFruitResult.Text = "결과 : " + String.Join(" , ", fruits);
        }



        private void btnchkColor_Click(object sender, EventArgs e)
        {
            CheckBox[] chkColors = { chkColor1, chkColor2, chkColor3, chkColor4, chkColor5 };
            List<string> colors = new List<string>();

            foreach(CheckBox chk in chkColors)
            {
                if (chk.Checked)
                {
                    colors.Add(chk.Text);
                }
            }

            lbColorResult.Text = "결과 : " + String.Join(" , ", colors);
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            lbUid.Text = "결과 : " + txtUid.Text; 
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text = "결과 : " + txtName.Text;
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            lbHP.Text = "결과 : " + txtHP.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("메시지 박스안의 메시지 박스", "버튼3", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes 클릭!");
            }
            else
            {
                MessageBox.Show("No 클릭!");
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}