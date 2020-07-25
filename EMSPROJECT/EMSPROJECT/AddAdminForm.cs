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
    public partial class AddAdminForm : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sanket\Desktop\Practice\C# practice\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
        public AddAdminForm()
        {
            InitializeComponent();
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
                cmd.CommandText = "insert into admin(username,password) values('" + tuser.Text + "','" + tpass.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                tuser.Text = "";
                tpass.Text = "";
              }
            catch(Exception ar)
            {
                MessageBox.Show("dbfj"+ar);
                con.Close();
                MessageBox.Show("Please Enter Above Fields First", "Oop's", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
