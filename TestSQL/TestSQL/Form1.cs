using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(local)\RUSSENSERVER;Initial Catalog=master;Integrated Security=SSPI;Trusted_Connection=True;";
            string sql = "SELECT * FROM Justingay";
            SqlCommand cmd = new SqlCommand(sql, con);
            
            con.Open();
            using (con)
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        textBox1.Text += dr["Name"].ToString() + Environment.NewLine;
                    }
                }
            }
        }
    }
}