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
    public partial class Editcustomer : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
        public Editcustomer()
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
               // int mobno = Convert.ToInt32(tmobno.Text);
                cmd.CommandText = "update customers set customer_name='" + tname.Text + "',address='" + taddress.Text + "',email='" + temail.Text + "',mob_no='" + tmobno.Text + "' where customer_id="+tid.Text+"  ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                tid.Text = "";
                tname.Text = "";
                taddress.Text = "";
                temail.Text = "";
                tmobno.Text = "";
            }
            catch 
            {
                con.Close();
                MessageBox.Show("Problem n Registering Customer, Please Enter All Fields Correctly", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from customers where customer_id=" + tid.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tname.Text = reader["customer_name"].ToString();
                    taddress.Text = reader["address"].ToString();
                    temail.Text = reader["email"].ToString();
                    string a = reader["mob_no"].ToString();
                    tmobno.Text = a;

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

        private void Editcustomer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        }
    }

