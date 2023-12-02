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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AEN1R2O;Initial Catalog=db21SA1251;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();

        }

        private void ShowData() {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer";

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "customer");

            dgvCustomer.DataSource = ds;

            dgvCustomer.DataMember = "customer";

            dgvCustomer.ReadOnly = true;
        }
    }
}
