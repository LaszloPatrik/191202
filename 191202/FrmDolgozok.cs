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
    public partial class FrmDolgozok : Form
    {
        SqlConnection conn;
        public FrmDolgozok(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();

            tB.TextChanged += Keres;
            nUD.ValueChanged += Keres;
        }

        private void Keres(object sender, EventArgs e)
        {
            Where(tB.Text);
        }

        private void FrmDolgozok_Load(object sender, EventArgs e)
        {
            Where("");
        }

        private void Where(string kerNev)
        {
            dGVdolg.Rows.Clear();
            conn.Open();

            var sql = new SqlCommand(
                "SELECT * FROM dolgozok " +
                $"WHERE nev LIKE '{kerNev}%';", conn);
            var reader = sql.ExecuteReader();

            while (reader.Read())
            {
                object[] adatok = { reader[0], reader[1], reader[2] };

                dGVdolg.Rows.Add(adatok);
            }

            conn.Close();
        }
    }
}
