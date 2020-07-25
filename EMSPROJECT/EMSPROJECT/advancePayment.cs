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
    public partial class advancePayment : Form
    {

       int total;
        //int amountPayable;
        int balanceAmount;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
        public advancePayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void advancePayment_Load(object sender, EventArgs e)
        {
            tamountPayable.Text = "";
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                //MessageBox.Show(bookPackage.bookingId);
                // cmd.CommandText = "select property_price,meal_amount,music,decoration,total,amount_payable,balance_amount from Bookings where booking_id=" + tid.Text + "";
                cmd.CommandText = "select * from Bookings where booking_id=" + bookPackage.bookingId + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    custidlbl.Text = reader["booking_id"].ToString();
                    custnamelbl.Text = reader["customer_name"].ToString();
                    categorylbl.Text = reader["category"].ToString();
                    namelbl.Text = reader["property_name"].ToString();
                    propertylbl.Text = reader["property_price"].ToString();
                    meallbl.Text = reader["meal_amount"].ToString();
                    musiclbl.Text = reader["music"].ToString();
                    decorationlbl.Text = reader["decoration"].ToString();
                    grandtoallbl.Text = reader["total"].ToString();


                    balancelbl.Text = reader["balance_amount"].ToString();
                    total = Convert.ToInt32(grandtoallbl.Text);



                }
                con.Close();
            }
            catch
            {
                //MessageBox.Show("Please Enter Id");
            }
        }

        private void tamountPayable_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int amountPayable = Convert.ToInt32(tamountPayable.Text);


                balanceAmount = total - amountPayable;
                balancelbl.Text = Convert.ToString(balanceAmount);
            }
            catch
            {
                MessageBox.Show("Please Enter Amount", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int amountPayable1 = Convert.ToInt32(tamountPayable.Text);

            if (amountPayable1 < 30000)
            {
                MessageBox.Show("You Must Have To Pay Atleast Rs.30,000 For Booking","OOps",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    int balance = Convert.ToInt32(balancelbl.Text);
                   // int id = Convert.ToInt32(tid.Text);
                    cmd.CommandText = "update Bookings set balance_amount='" + balanceAmount + "' where booking_id=" + bookPackage.bookingId + " ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your Booking Is Approved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    con.Close();
                    custidlbl.Text = "";
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If You dont Make Transaction Your Booking Will be Cancelled ? Do You Want to Cancel This Booking ? ", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "delete from Bookings where booking_id=" + bookPackage.bookingId + "  ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Booking Is Cancelled ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    this.Close();

                 

                }
                catch
                {
                    con.Close();
                    MessageBox.Show("Problem In Cancelling Booking, Please Enter All Fields Correctly", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {MessageBox.Show("Problem In Cancelling Booking, Please Enter All Fields Correctly", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

        }
       
    }
}
