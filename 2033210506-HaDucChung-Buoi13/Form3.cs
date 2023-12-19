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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2033210506_HaDucChung_Buoi13
{
    public partial class Form3 : Form
    {

        string abc = "Data Source=Admin-PC;Initial Catalog=QL_GiaoVien;Integrated Security=True";
        private SqlConnection connect;
        public Form3()
        {
            InitializeComponent();
        }

        private void Show()
        {
            connect = new SqlConnection(abc);
            connect.Open();
            string ShowString = "SELECT DV.tenDonVi,DV.maCoSo,GV.maGiaoVien,GV.hoTen,GV.sdt,GV.ghiChu FROM GV JOIN DV ON GV.maDonVi = DV.maDonVi";
            SqlDataAdapter adapter = new SqlDataAdapter(ShowString, connect);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter("SELECT DV.tenDonVi,DV.maCoSo,GV.maGiaoVien,GV.hoTen,GV.sdt,GV.ghiChu FROM GV,DV WHERE GV.maDonVi=DV.DV.maDonVi", "server = Admin-PC; database =QL_GiaoVien; UID = sa; password =1");
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrrow;
            numrrow = e.RowIndex;
            comboBox1.Text = dataGridView1.Rows[numrrow].Cells[0].Value.ToString();

            comboBox2.Text = dataGridView1.Rows[numrrow].Cells[1].Value.ToString();
           // comboBox1.Text=dataGridView1
                

            //txtHoTen.Text = Convert.ToString(row.Cells["ten"].Value);
            //txtLop.Text = Convert.ToString(row.Cells["lop"].Value);
            //txtTruong.Text = Convert.ToString(row.Cells["truong"].Value);
        }
    }
}
