using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _2033210506_HaDucChung_Buoi13
{
    public partial class frmBaiTap1 : Form
    {
        
        private SqlConnection connect;
        public frmBaiTap1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            string _connectectionString = "Data Source=";
            _connectectionString = _connectectionString + textBox1.Text + ";Initial Catalog=" + textBox2.Text + ";User ID=" + textBox3.Text + ";Password=" + textBox4.Text + ";Integrated Security=True";
            connect = new SqlConnection(_connectectionString);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MessageBox.Show("Kết nối database thành công");
                Form3 f = new Form3();
                f.Show();
            }
            else
                MessageBox.Show("Kết nối database thất bại");

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
