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
    public partial class customerId : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
       //public static int id;
       public static string id,name;
      
        public customerId()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = tid.Text;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Bookings where booking_id=" + id + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                    //tcustname.Text = reader["customer_name"].ToString();

                }
                con.Close();

                if (count > 0)
                {

                    MessageBox.Show(" Customer With This Id Is Alredy Booked ", "Oop's", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    gobooking();
                 }
            }
            catch
            {
                MessageBox.Show("Please Enter Valid Id ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
            
            
            
            
            
            /* try
            {
                id = tid.Text;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                // cmd.CommandText = "select property_price,meal_amount,music,decoration,total,amount_payable,balance_amount from Bookings where booking_id=" + tid.Text + "";
                cmd.CommandText = "select * from customers where customer_id=" + tid.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name = reader["customer_name"].ToString();
                    bookPackage bp=new bookPackage();
                    bp.Show();
                  
                }
                
                else
                {
                    MessageBox.Show("Enter Valid ID ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
            catch (Exception ae)
            {
                //MessageBox.Show("DFD" + ae);
                MessageBox.Show("Please Enter Id", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
            */
}
        public void gobooking()
        {
            try
            {
                id = tid.Text;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                // cmd.CommandText = "select property_price,meal_amount,music,decoration,total,amount_payable,balance_amount from Bookings where booking_id=" + tid.Text + "";
                cmd.CommandText = "select * from customers where customer_id=" + id + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name = reader["customer_name"].ToString();
                    bookPackage bp = new bookPackage();
                    this.Close();
                    bp.Show();

                }

                else
                {
                    MessageBox.Show("Enter Valid ID ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
            catch 
            {
                //MessageBox.Show("DFD" + ae);
                MessageBox.Show("Please Enter Id", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }

        }

        private void customerId_Load(object sender, EventArgs e)
        {

        }
    }

 

}
