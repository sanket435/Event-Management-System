using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace EMSPROJECT
{
    public partial class Add_Venue : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Codding 2\Portfolio\EMSPROJECT\EMSPROJECT\Db\EMSDB.accdb");
        public Add_Venue()
        {
            InitializeComponent();
        }

        private void Add_Venue_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string pic = File.ReadAllBytes();
               // byte[] Imagebt = null;
               // FileStream fstream = new FileStream(this.textBox10.Text,FileMode.Open,FileAccess.Read);
               // BinaryReader br = new BinaryReader(fstream);
               // Imagebt = br.ReadBytes((int)fstream.Length);
                // cmd.Parameters.Add("@img",OleDbType.LongVarBinary, Imagebt.Length);

                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Venue(category,property_name,address,city,property_price,meal_normal,meal_deluc,meal_premium,music,decoration_normal,decoration_deluc,decoration_premium) values('" + cmbcategory.Text + "','" + tname.Text + "','" + taddress.Text + "','" + tcity.Text + "','" + tproperty.Text + "','" + tnormal.Text + "','" + tdeluc.Text + "','" + tpremium.Text + "','" + tmusic.Text + "','" + tdeconormal.Text + "','" + tdecodeluc.Text + "','" + tdecopremium.Text + "')";
              

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully", " Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                getid();
                con.Close();

                //Clear
                cmbcategory.Text ="";
                tname.Text ="";
                taddress.Text ="";
                tcity.Text ="";
                tproperty.Text ="";
                tnormal.Text ="";
                tdeluc.Text ="";
                tpremium.Text ="";
                tmusic.Text ="";
                tdeconormal.Text=""; 
                tdecodeluc.Text ="";
                tdecopremium.Text ="";
               

            }
            catch 
            {
                MessageBox.Show("Problem in Adding Packge, Please Enter All fields Correctly", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        public void getid()
        {
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Max(ID) from Venue";
            int id = (int)cmd.ExecuteScalar();

            MessageBox.Show("Venue Id Is : " + id, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {/*
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File(*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                public string pic = ofd.FileName.ToString();
                textBox10.Text = pic;
                pictureBox1.ImageLocation = pic;
            }*/
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tdecopremium_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
