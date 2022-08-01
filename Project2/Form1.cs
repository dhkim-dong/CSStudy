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
            // �����ͱ׸��� �� ������ ����
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DBAccess.Instance.InsertUser(txtUid.Text, txtName.Text,txtHp.Text,nAge.Text);

            MessageBox.Show("�����Ͱ� �߰� �Ǿ����ϴ�.", "�Է�");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();

            MessageBox.Show("�����͸� ȣ���Ͽ����ϴ�.", "��ȸ");
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

            MessageBox.Show("�����Ͱ� ������Ʈ �Ǿ����ϴ�.", "������Ʈ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("���� �����͸� �����Ͻðڽ��ϱ�?", "����", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                MessageBox.Show("�����͸� �����Ͽ����ϴ�", "���� �Ϸ�");
                DBAccess.Instance.DeleteUser(txtUid.Text);
            }
            else
            {
                MessageBox.Show("������ ������ ����Ͽ����ϴ�", "���� ���");
            }
        }
    }
}