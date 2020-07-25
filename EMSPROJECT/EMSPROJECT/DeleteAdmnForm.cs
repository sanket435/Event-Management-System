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
    public partial class DeleteAdmnForm : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
        public DeleteAdmnForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
               
                cmd.CommandText = "update admin set username='" + tuser.Text + "',password='" + tpass.Text + "' where username=" + tuser.Text + "  ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                tuser.Text = "";
                tpass.Text = "";
               
            }
            catch
            {
                con.Close();
                MessageBox.Show("Problem n Registering Admin, Please Enter All Fields Correctly", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from admin where username=" + tuser.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tuser.Text = reader["username"].ToString();
                    tpass.Text = reader["password"].ToString();
                 }
                else
                {
                    MessageBox.Show("Search Fail ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Search Fail ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete from admin where username=" + tuser.Text + "  ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin Deleted Successully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                tuser.Text = "";
                tpass.Text = "";
               
            }
            catch
            {
                con.Close();
                MessageBox.Show("Problem In Deleting Admin, Please Enter All Fields Correctly", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
