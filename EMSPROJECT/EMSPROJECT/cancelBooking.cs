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
    public partial class cancelBooking : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");

        public cancelBooking()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Bookings where booking_id=" + tid.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tcustname.Text = reader["customer_name"].ToString();
                    tcategory.Text = reader["category"].ToString();
                    tpropname.Text = reader["property_name"].ToString();
                    tcity.Text = reader["city"].ToString();
                    taddress.Text = reader["address"].ToString();
                }
                else
                {
                    MessageBox.Show("Search Fail ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
            catch 
            {
                MessageBox.Show("Please Enter Valid Id", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do You Want To Cancel Booking ?", "Cancel Booking", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "delete from Bookings where booking_id=" + tid.Text + "  ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Booking Is Cancelled ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
