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
    public partial class PaymentForm : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
       // int grandTotal;
        int balanceAmount;
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tid_TextChanged(object sender, EventArgs e)
        {}

        private void tid_Enter(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                int balance = Convert.ToInt32(balancelbl.Text);
                int id = Convert.ToInt32(tid.Text);
                cmd.CommandText = "update Bookings set balance_amount='"+balance+"' where booking_id="+id+" ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                tid.Text = "";
                tamountPayable.Text = "";
                custnamelbl.Text = "";
                categorylbl.Text = "";
                namelbl.Text = "";
                propertylbl.Text = "";
                meallbl.Text = "";
                musiclbl.Text = "";
                decorationlbl.Text = "";
                grandtoallbl.Text = "";
                balancelbl.Text = "";

            }
            catch
            {
                MessageBox.Show("Transaction Failed", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {/*
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
   
                cmd.CommandText = "select * from Bookings where booking_id=" + tid.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    custnamelbl.Text = reader["customer_name"].ToString();
                    categorylbl.Text = reader["category"].ToString();
                    namelbl.Text = reader["customer_name"].ToString();
                    propertylbl.Text = reader["property_price"].ToString();
                    meallbl.Text = reader["meal_amount"].ToString();
                    musiclbl.Text = reader["music"].ToString();
                    decorationlbl.Text = reader["decoration"].ToString();
                    grandtoallbl.Text = reader["total"].ToString();
                    balancelbl.Text = reader["balance_amount"].ToString();
                    
                }
                con.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Search Fail " + ae);
            }*/

        }

        private void tamountPayable_TextChanged(object sender, EventArgs e)
        { }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tamountPayable.Text = "";
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                // cmd.CommandText = "select property_price,meal_amount,music,decoration,total,amount_payable,balance_amount from Bookings where booking_id=" + tid.Text + "";
                cmd.CommandText = "select * from Bookings where booking_id=" + tid.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    custnamelbl.Text = reader["customer_name"].ToString();
                    categorylbl.Text = reader["category"].ToString();
                    namelbl.Text = reader["property_name"].ToString();
                    propertylbl.Text = reader["property_price"].ToString();
                    meallbl.Text = reader["meal_amount"].ToString();
                    musiclbl.Text = reader["music"].ToString();
                    decorationlbl.Text = reader["decoration"].ToString();
                    grandtoallbl.Text = reader["total"].ToString();


                    balancelbl.Text = reader["balance_amount"].ToString();
                    balanceAmount = Convert.ToInt32(balancelbl.Text);
                   


                }
                else
                {
                    MessageBox.Show("Search Fail ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tid.Text = "";
                    tamountPayable.Text = "";
                    custnamelbl.Text = "";
                    categorylbl.Text = "";
                    namelbl.Text = "";
                    propertylbl.Text = "";
                    meallbl.Text = "";
                    musiclbl.Text = "";
                    decorationlbl.Text = "";
                    grandtoallbl.Text = "";
                    balancelbl.Text = "";

                }
                con.Close();
            }
            catch
            {
                //MessageBox.Show("DFD" + ae);
                MessageBox.Show("Please Enter Id", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tid.Text = "";
                tamountPayable.Text = "";
                custnamelbl.Text = "";
                categorylbl.Text = "";
                namelbl.Text = "";
                propertylbl.Text = "";
                meallbl.Text = "";
                musiclbl.Text = "";
                decorationlbl.Text = "";
                grandtoallbl.Text = "";
                balancelbl.Text = "";
                con.Close();
            }
        }

        public void display() 
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
              
                cmd.CommandText = "select * from Bookings where booking_id=" + tid.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    balancelbl.Text = reader["balance_amount"].ToString();
                    balanceAmount = Convert.ToInt32(balancelbl.Text);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please Enter amount", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                display();
                int value = Convert.ToInt32(balancelbl.Text);
                if (value == 0)
                {
                    MessageBox.Show("Your Balance Amount Is Nill", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    try
                    {
                        int amountPayable = Convert.ToInt32(tamountPayable.Text);


                        balanceAmount = balanceAmount - amountPayable;
                        balancelbl.Text = Convert.ToString(balanceAmount);
                    }
                    catch
                    {
                        MessageBox.Show("Please Enter Amount", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
