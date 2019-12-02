using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _191202
{
    public partial class FrmMain : Form
    {
        SqlConnection connection;

        public FrmMain()
        {
            connection = new SqlConnection(
                @"Server = (localdb)\MSSQLLocalDB;" + "Database=Ceg;");

            InitializeComponent();
        }

        private void Ceg_Load(object sender, EventArgs e)
        {
            connection.Open();

            //var r = new SqlCommand("SELECT * FROM epuletek;", connection).ExecuteReader();  Zoli szerint ez gyorsabb, de nem a legmegfelelőbb
            var sql = new SqlCommand("SELECT * FROM epuletek;", connection);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                object[] adatok = { reader[0], reader[1], reader[2]};

                dGV.Rows.Add(adatok);
            }

            connection.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var f = new FrmDolgozok(connection);
            f.ShowDialog();
        }
    }
}
