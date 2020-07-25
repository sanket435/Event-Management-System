using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMSPROJECT
{
    public partial class paymentProcessing : Form
    {
        public paymentProcessing()
        {
            InitializeComponent();
        }

        private void paymentProcessing_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value=progressBar1.Value+1;
            if (progressBar1.Value==100)
            {
                advancePayment ad = new advancePayment();
                this.Close();
                ad.Show();
                timer1.Enabled = false;
               
          }
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
