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
    public partial class Addcustomer : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
        public Addcustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* if (tname.TextLength < 1) label5.Text = " Please Enter Customer Name";
            if (taddress.TextLength <1) vaddresslbl.Text = "Please Enter Address ";
            if (temail.TextLength < 1) vemaillbl.Text = "Please Enter Email ";
            if (tmobno.TextLength < 1) mobValidationlbl.Text = "Please Enter Address ";*/
              





           try
            {
               /* if (tname.TextLength < 1) label5.Text = " Please Enter Customer Name";
                if (taddress.TextLength < 1) vaddresslbl.Text = "Please Enter Address ";
                if (temail.TextLength < 1) vemaillbl.Text = "Please Enter Email ";
                if (tmobno.TextLength < 1) mobValidationlbl.Text = "Please Enter Mobile Number ";
              */
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //MessageBox.Show("dfd---" + tname.Text + taddress.Text + temail.Text + tmobno.TextLength);
                cmd.CommandText = "insert into customers(customer_name,address,email,mob_no) values('"+tname.Text+"','"+taddress.Text+"','"+temail.Text+"','"+tmobno.Text+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully"," ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getid();

                con.Close();
                tname.Text = "";
                taddress.Text = "";
                temail.Text = "";
                tmobno.Text = "";

                label5.Text = "";
                vaddresslbl.Text = "";
                vemaillbl.Text = "";
                mobValidationlbl.Text = "";


              }
            catch
            {
                con.Close();
                MessageBox.Show("Please Enter Above Fields First", "Oop's", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        public void getid()
        {
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Max(customer_id) from customers";
            int id = (int)cmd.ExecuteScalar();

            MessageBox.Show("Your Id Is : " + id, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tname_TextChanged(object sender, EventArgs e)
        {
           /* if (tname.TextLength > 0) label5.Text = " ";
            else label5.Text = "Please Enter Customer Name ";*/
        }

        private void temail_TextChanged(object sender, EventArgs e)
        {
            /*if (temail.TextLength > 0) vemaillbl.Text = " ";
            else vemaillbl.Text = "Please Enter Email ";*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void taddress_TextChanged(object sender, EventArgs e)
        {
           /* if (taddress.TextLength > 0) vaddresslbl.Text = " ";
            else vaddresslbl.Text = "Please Enter Customer Name ";*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tmobno_TextChanged(object sender, EventArgs e)
        {
            
                if (tmobno.TextLength > 10)
                {
                    mobValidationlbl.Text = "Mobile Number Are Only Of 10 Digits ";
                }
                else if(tmobno.TextLength>0) {
                    mobValidationlbl.Text = " ";
                }
                else if (tmobno.TextLength < 1)
                {
                    mobValidationlbl.Text = "Please Enter Mobile Number";

                }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addcustomer_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
