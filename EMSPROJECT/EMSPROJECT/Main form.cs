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
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addcustomer ac = new Addcustomer();
           // this.Hide();
            ac.Show();
              
            

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editcustomer ec = new Editcustomer();
           // this.Hide();
            ec.Show();
               
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*bookPackage bp = new bookPackage();
           // this.Hide();
            bp.Show();*/
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletecustomer dc = new deletecustomer();
          //  this.Hide();
            dc.Show();

        }

        private void addVenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Venue av = new Add_Venue();
            av.Show();
        }

        private void editVenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editvenue ev = new editvenue();
            ev.Show();
        }

        private void deleteVenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deletevenue dv = new Deletevenue();
            dv.Show();

        }

        private void packgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm pf = new PaymentForm();
            pf.Show();

        }

        private void receiptsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm pf = new PaymentForm();
            pf.Show();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*DialogResult dialogResult = MessageBox.Show("Do You Want To Logout ?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                adminLogin al = new adminLogin();
                this.Hide();
                al.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }*/
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            customerStatus cs = new customerStatus();
            //this.Hide();
            cs.Show();
            
        }

        private void venuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venueStatus vs = new venueStatus();
            vs.Show();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingStatus bs = new bookingStatus();
            bs.Show();
        }

        private void newBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerId ci = new customerId();
           
            ci.Show();




            /*bookPackage bp = new bookPackage();
            // this.Hide();
            bp.Show();*/
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelBooking cb = new cancelBooking();
            cb.Show();

        }

        private void editBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editBooking eb = new editBooking();
            eb.Show();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paymentReceivable1 pr = new paymentReceivable1();
            pr.Show();
        }

        private void logOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Want To Logout ?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                adminLogin al = new adminLogin();
                this.Hide();
                al.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdminForm aa = new AddAdminForm();
            aa.Show();
        }

        private void deleteAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAdmnForm da = new DeleteAdmnForm();
            da.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
