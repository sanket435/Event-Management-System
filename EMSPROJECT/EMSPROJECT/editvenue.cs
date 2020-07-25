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
    public partial class editvenue : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
        public editvenue()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Venue where ID=" + tid.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string propertyPrice = reader["property_price"].ToString();
                    string mealNormal = reader["meal_normal"].ToString();
                    string mealDeluc = reader["meal_deluc"].ToString();
                    string mealpremium = reader["meal_premium"].ToString();
                    string music = reader["music"].ToString();
                    string deconormal = reader["decoration_normal"].ToString();
                    string decodeluc = reader["decoration_deluc"].ToString();
                    string decopremium = reader["decoration_premium"].ToString();
                    // Code to Show Data
                    cmbcategory.Text = reader["category"].ToString();
                    tname.Text = reader["property_name"].ToString();
                    taddress.Text = reader["address"].ToString();
                    tcity.Text = reader["city"].ToString();
                    tproperty.Text = propertyPrice;
                    tnormal.Text = mealNormal;
                    tdeluc.Text = mealDeluc;
                    tpremium.Text = mealpremium;
                    tmusic.Text = music;
                    tdeconormal.Text = deconormal;
                    tdecodeluc.Text = decodeluc;
                    tdecopremium.Text = decopremium;

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

                cmd.CommandText = "update Venue set category='" + cmbcategory.Text + "',property_name='" + tname.Text + "',address='" + taddress.Text + "',property_price='" + tproperty.Text + "',meal_normal='" + tnormal.Text + "',meal_deluc='" + tdeluc.Text + "',meal_premium='" + tpremium.Text + "',music='" + tmusic.Text + "',decoration_normal='" + tdeconormal.Text + "',decoration_deluc='" + tdecodeluc.Text + "',decoration_premium='" + tdecopremium.Text + "' where ID=" + tid.Text + "  ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                tid.Text = "";
                cmbcategory.Text = "";
                tname.Text = "";
                taddress.Text = "";
                tcity.Text = "";
                tproperty.Text = "";
                tnormal.Text = "";
                tdeluc.Text = "";
                tpremium.Text = "";
                tmusic.Text = "";
                tdeconormal.Text = "";
                tdecodeluc.Text = "";
                tdecopremium.Text = "";
               
            }
            catch 
            {
                con.Close();
                MessageBox.Show("Problem in Saving Changes, Please Enter All Fields Correctly", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
