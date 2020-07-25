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
    public partial class bookPackage : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
        OleDbDataAdapter adapter;
        int meal_amount;
        int grandTotal;
        DataTable table = new DataTable();
        int pos;
        public static string bookingId=customerId.id;
        
        public bookPackage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pos = 0;
            showdata(pos);
         }
        private void bookPackage_Load(object sender, EventArgs e)
        {
            label19.Text = customerId.name;
            adapter = new OleDbDataAdapter("select * from Venue", con);
            adapter.Fill(table);
            showdata(pos);
         }
        public void showdata(int indec)
        {
   
            cmbcategory.Text = table.Rows[indec]["category"].ToString();
            tname.Text = table.Rows[indec]["property_name"].ToString();
            taddress.Text = table.Rows[indec]["address"].ToString();
            tcity.Text = table.Rows[indec]["city"].ToString();
            tproperty.Text = table.Rows[indec]["property_price"].ToString();
           /* tnormal.Text = table.Rows[indec]["meal_normal"].ToString();
            tdeluc.Text = table.Rows[indec]["meal_deluc"].ToString();
            tpremium.Text = table.Rows[indec]["meal_premium"].ToString();*/
            tmusic.Text = table.Rows[indec]["music"].ToString();
           /* tdeconormal.Text = table.Rows[indec]["decoration_normal"].ToString();
            tdecodeluc.Text = table.Rows[indec]["decoration_deluc"].ToString();
            tdecopremium.Text = table.Rows[indec]["decoration_premium"].ToString(); */
         }

        private void button5_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos < table.Rows.Count)
            {
                showdata(pos);
                
            }
            else {
                MessageBox.Show("End");
                pos = table.Rows.Count - 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos >= 0)
            {
                showdata(pos);
            }
            else {
                MessageBox.Show("End");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pos = table.Rows.Count - 1;
            showdata(pos);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = "select * from Venue where property_name='" + tname.Text + "' ";
                cmd.CommandText = query;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add(reader["meal_normal"].ToString());
                    comboBox2.Items.Add(reader["meal_deluc"].ToString() );
                    comboBox2.Items.Add(reader["meal_premium"].ToString());
                }
                con.Close();
               
                }
            catch 
            {
                con.Close();
               // MessageBox.Show("Error" + ae);
            } 
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = "select * from Venue where property_name='" + tname.Text + "' ";
                cmd.CommandText = query;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbdeco.Items.Clear();
                    cmbdeco.Items.Add(reader["decoration_normal"].ToString());
                    cmbdeco.Items.Add( reader["decoration_deluc"].ToString());
                    cmbdeco.Items.Add(reader["decoration_premium"].ToString());
                }
                con.Close();

            }
            catch 
            {
                con.Close();
                //MessageBox.Show("Error" + ae);
            }

        }

        private void ttickets_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int mamount = Convert.ToInt32(comboBox2.Text);
                int tickets = Convert.ToInt32(ttickets.Text);
                meal_amount = mamount * tickets;
                tmealTotalAmount.Text = Convert.ToString(meal_amount);
            }
            catch
            {
               // MessageBox.Show("Please Enter Tickets");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int propertyPrice = Convert.ToInt32(tproperty.Text);
                
                int deco = Convert.ToInt32(cmbdeco.Text);
                

               grandTotal = propertyPrice + deco+ meal_amount;
                tgrandTotal.Text = Convert.ToString(grandTotal);

                if (radioButton1.Checked)
                {
                    int musicPrice = Convert.ToInt32(tmusic.Text);
                    grandTotal += musicPrice;
                    tgrandTotal.Text = Convert.ToString(grandTotal);
                }
            }   
            catch
            {
                MessageBox.Show("Please Select Decoration ","Oops",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand commannd = new OleDbCommand();
                commannd.Connection = con;
                String temp = Convert.ToString(dateTimePicker1.Text);
                commannd.CommandText = "select * from Bookings where event_date='" + temp + "' and property_name='" + tname.Text + "' ";
                OleDbDataReader reader = commannd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                   
                }
                if (count > 0)
                {
                    MessageBox.Show("Already Booked For This Date Please Select Another Date", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // Can Book code
                    if (radioButton2.Checked)
                    {

                        try
                        {
                            int music = 0;
                           // con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            int balance = Convert.ToInt32(tgrandTotal.Text);
                            String temp1 = Convert.ToString(dateTimePicker1.Text);
                           // bookingId = tid.Text;
                            cmd.CommandText = "insert into Bookings(booking_id,customer_name,category,property_name,city,address,event_date,property_price,mealPerPerson,mealTickets,meal_amount,music,decoration,total,balance_amount) values('" + customerId.id + "','" + customerId.name + "','" + cmbcategory.Text + "','" + tname.Text + "','" + tcity.Text + "','" + taddress.Text + "','" + temp1 + "','" + tproperty.Text + "','" + comboBox2.Text + "','" + ttickets.Text + "','" + tmealTotalAmount.Text + "','" + music + "','" + cmbdeco.Text + "','" + tgrandTotal.Text + "','" + balance + "')";
                            cmd.ExecuteNonQuery();
                            con.Close();

                            paymentProcessing pp = new paymentProcessing();
                            this.Hide();
                            pp.Show();

                           
                            cmbcategory.Text = "";
                            tname.Text = "";
                            tcity.Text = "";
                            taddress.Text = "";
                            tproperty.Text = "";
                            tmealTotalAmount.Text = "";
                            tmusic.Text = "";
                            cmbdeco.Text = "";
                            tgrandTotal.Text = "";
                            dateTimePicker1.Text = "";
                            comboBox2.Text = "";
                            ttickets.Text = "";
                           

                        }
                        catch
                        {
                            MessageBox.Show("Please Enter All Fields", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        try
                        {
                           // con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            int balance = Convert.ToInt32(tgrandTotal.Text);
                            String temp2 = Convert.ToString(dateTimePicker1.Text);
                           // bookingId = tid.Text;
                            cmd.CommandText = "insert into Bookings(booking_id,customer_name,category,property_name,city,address,event_date,property_price,mealPerPerson,mealTickets,meal_amount,music,decoration,total,balance_amount) values('" + customerId.id + "','" + customerId.name + "','" + cmbcategory.Text + "','" + tname.Text + "','" + tcity.Text + "','" + taddress.Text + "','" + temp2 + "','" + tproperty.Text + "','" + comboBox2.Text + "','" + ttickets.Text + "','" + tmealTotalAmount.Text + "','" + tmusic.Text + "','" + cmbdeco.Text + "','" + tgrandTotal.Text + "','" + balance + "')";
                            cmd.ExecuteNonQuery();
                            
                            con.Close();

                            paymentProcessing pp = new paymentProcessing();
                            this.Hide();
                            pp.Show();

                           
                            cmbcategory.Text = "";
                            tname.Text = "";
                            tcity.Text = "";
                            taddress.Text = "";
                            tproperty.Text = "";
                            tmealTotalAmount.Text = "";
                            tmusic.Text = "";
                            cmbdeco.Text = "";
                            tgrandTotal.Text = "";
                            dateTimePicker1.Text = "";
                            comboBox2.Text = "";
                            ttickets.Text = "";

                            


                        }
                        catch 
                        {
                            MessageBox.Show("Please Enter All Fields", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }

                con.Close();
            }

            catch 
            {
               
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Bookings where booking_id=" + customerId.id + "";
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
                    
                   getByCustomers();
                }
            }
            catch 
            {
                MessageBox.Show("Please Enter Valid Id ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

      public void  getByCustomers()
        {
          /* try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from customers where customer_id=" + customerId.id + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tcustname.Text = reader["customer_name"].ToString();

                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Please Enter Valid Id ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          */
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand commannd = new OleDbCommand();
                commannd.Connection = con;
                String temp = Convert.ToString(dateTimePicker1.Text);
                commannd.CommandText = "select * from Bookings where event_date='" + temp + "' and property_name='" + tname.Text + "' ";
                OleDbDataReader reader = commannd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                   
                }
                if (count > 0)
                {
                    datevalidlbl.Text = "Oop's ! Already Booked Please Select Another Date";
                }
                else 
                {
                    datevalidlbl.Text = "";
                }
                

                con.Close();
            }

            catch 
            {
            }
        }

        private void cmbdeco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
