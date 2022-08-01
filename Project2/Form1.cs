using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 데이터그리드 뷰 데이터 공급
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DBAccess.Instance.InsertUser(txtUid.Text, txtName.Text,txtHp.Text,nAge.Text);

            MessageBox.Show("데이터가 추가 되었습니다.", "입력");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();

            MessageBox.Show("데이터를 호출하였습니다.", "조회");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridViewRow dataRow = dataGrid.Rows[row];

            txtUid.Text = dataRow.Cells[0].Value.ToString();
            txtName.Text = dataRow.Cells[1].Value.ToString();
            txtHp.Text = dataRow.Cells[2].Value.ToString();
            nAge.Text = dataRow.Cells[3].Value.ToString();


            Console.WriteLine(dataRow.Cells[0].Value.ToString());
            Console.WriteLine(dataRow.Cells[1].Value.ToString());
            Console.WriteLine(dataRow.Cells[2].Value.ToString());
            Console.WriteLine(dataRow.Cells[3].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBAccess.Instance.UpdateUser(txtUid.Text, txtName.Text, txtHp.Text, nAge.Text);

            MessageBox.Show("데이터가 업데이트 되었습니다.", "업데이트");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("정말 데이터를 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                MessageBox.Show("데이터를 삭제하였습니다", "삭제 완료");
                DBAccess.Instance.DeleteUser(txtUid.Text);
            }
            else
            {
                MessageBox.Show("데이터 삭제를 취소하였습니다", "삭제 취소");
            }
        }
    }
}