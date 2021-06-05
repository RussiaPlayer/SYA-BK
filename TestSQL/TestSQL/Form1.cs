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
using MySqlConnector;

namespace TestSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            MySQL_ToDatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        
        private void MySQL_ToDatagridview()
        {
            //VarribleKeeper.MySQLConnectionString = your connection string
            //info being your table name
            MySqlConnection mysqlCon = new MySqlConnection("server=localhost;uid=root;pwd=root;database=test1;");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from reactionroles";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
        }
    }
}