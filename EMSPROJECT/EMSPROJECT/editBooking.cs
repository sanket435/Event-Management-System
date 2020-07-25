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
    public partial class editBooking : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
        OleDbDataAdapter adapter;
        int meal_amount;
        int grandTotal;
        DataTable table = new DataTable();
    
        int pos=0;
        public editBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton2.Checked)
                    {

                        try
                        {
                            int music = 0;
                            con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            int balance = Convert.ToInt32(tgrandTotal.Text);
                            //String temp1 = Convert.ToString(dateTimePicker1.Text);
                            cmd.CommandText = "update Bookings set category='" + cmbcategory.Text + "',property_name='" + tname.Text + "',city='" + tcity.Text + "',address='" + taddress.Text + "',property_price='" + tproperty.Text + "',mealPerPerson='" + comboBox2.Text + "',mealTickets='" + ttickets.Text + "',meal_amount='" + tmealTotalAmount.Text + "',music='" + music + "',decoration='" + cmbdeco.Text + "' where booking_id=" + tid.Text + "  ";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Changes Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();

                            tid.Text = "";
                            tcustname.Text = "";
                            cmbcategory.Text = "";
                            tname.Text = "";
                            taddress.Text = "";
                            tcity.Text = "";
                            tproperty.Text = "";
                            comboBox2.Text = "";
                            ttickets.Text = "";
                            tmealTotalAmount.Text = "";
                            tmusic.Text = "";
                            cmbdeco.Text = "";
                            tgrandTotal.Text = "";

                        }
                        catch 
                        {
                            MessageBox.Show("Please Enter All Fields", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           // MessageBox.Show("dfd"+ae);
                        }
                    }
                    else
                    {
                        try
                        {
                             con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            int balance = Convert.ToInt32(tgrandTotal.Text);
                            //String temp2 = Convert.ToString(dateTimePicker1.Text);
                            cmd.CommandText = "update Bookings set category='" + cmbcategory.Text + "',property_name='" + tname.Text + "',city='" + tcity.Text + "',address='" + taddress.Text + "',property_price='" + tproperty.Text + "',mealPerPerson='" + comboBox2.Text + "',mealTickets='" + ttickets.Text + "',meal_amount='" + tmealTotalAmount.Text + "',music='" + tmusic.Text + "',decoration='" + cmbdeco.Text + "' where booking_id=" + tid.Text + "  ";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Changes Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();

                            tid.Text = "";
                            tcustname.Text = "";
                            cmbcategory.Text = "";
                            tname.Text = "";
                            taddress.Text = "";
                            tcity.Text = "";
                            tproperty.Text = "";
                            comboBox2.Text = "";
                            ttickets.Text = "";
                            tmealTotalAmount.Text = "";
                            tmusic.Text = "";
                            cmbdeco.Text = "";
                            tgrandTotal.Text = "";


                        }
                        catch
                        {
                           MessageBox.Show("Please Enter All Fields", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //MessageBox.Show("dfd" + ae);
                        }
                    
                }
                con.Close();
            }


            catch
            {

                MessageBox.Show("Problem in Saving Changes, Please Enter All Fields Correctly", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
            
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
                    cmbcategory.Text = reader["category"].ToString();
                    tname.Text = reader["property_name"].ToString();
                    tcity.Text = reader["city"].ToString();
                    taddress.Text = reader["address"].ToString();
                   
                    tproperty.Text = reader["property_price"].ToString();
                    comboBox2.Text = reader["mealPerPerson"].ToString();
                    ttickets.Text = reader["mealTickets"].ToString();
                    tmealTotalAmount.Text = reader["meal_amount"].ToString();
                    tmusic.Text = reader["music"].ToString();
                    cmbdeco.Text = reader["decoration"].ToString();
                    tgrandTotal.Text = reader["total"].ToString();


                }
                else
                {
                    MessageBox.Show("Search Fail ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
            catch 
            {
                MessageBox.Show("Please Enter Valid Id ", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           /* try
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
            }*/

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

        public void button3_Click(object sender, EventArgs e)
        {
           // tid.Text = "";
            cmbcategory.Text = "";
            tname.Text = "";
            taddress.Text = "";
            tcity.Text = "";
            tproperty.Text = "";
            comboBox2.Text = "";
            ttickets.Text = "";
            tmealTotalAmount.Text = "";
            tmusic.Text = "";
            cmbdeco.Text = "";
            tgrandTotal.Text = "";


            pos ++;
            load_data();
            showdata(pos);
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {/*
            pos--;
            if (pos >= 0)
            {
                load_data();
                showdata(pos);
            }
            else
            {
                MessageBox.Show("End");
            }*/
        }

        private void btnnect_Click(object sender, EventArgs e)
        {
          
            
            pos++;

            
            if (pos < table.Rows.Count)
            {
                
                load_data();
                
                
                showdata(pos);

            }
            else
            {
                MessageBox.Show("End");
                pos = table.Rows.Count - 1;
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {/*
            load_data();
            pos = table.Rows.Count - 1;
            showdata(pos);*/
        }

        public void load_data()
        {
            adapter = new OleDbDataAdapter("select * from Venue", con);
            adapter.Fill(table);
            showdata(pos);
        }
        public void first()
        {
            pos = 0;
            load_data();
            showdata(pos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int propertyPrice = Convert.ToInt32(tproperty.Text);

                int deco = Convert.ToInt32(cmbdeco.Text);


                grandTotal = propertyPrice + deco + meal_amount;
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
                MessageBox.Show("please select Decoration", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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
                    comboBox2.Items.Add(reader["meal_deluc"].ToString());
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

        private void cmbdeco_MouseClick(object sender, MouseEventArgs e)
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
                    cmbdeco.Items.Add(reader["decoration_deluc"].ToString());
                    cmbdeco.Items.Add(reader["decoration_premium"].ToString());
                }
                con.Close();

            }
            catch 
            {
                con.Close();
               // MessageBox.Show("Error" + ae);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tcustname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
