using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EMSPROJECT
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb;Persist Security Info=False;";

                connection.Open();
                OleDbCommand commannd = new OleDbCommand();
                commannd.Connection = connection;
                commannd.CommandText = "select * from admin where username='" + tuser.Text + "' and password='" + tpassword.Text + "' ";
                OleDbDataReader reader = commannd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Log in Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Main_form mn = new Main_form();
                    mn.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicte Username And Password ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Invalid Username And Password", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void adminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
