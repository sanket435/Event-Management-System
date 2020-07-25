namespace EMSPROJECT
{
    partial class Main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.venuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 6, 0, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.venueToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.viewStatusToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.manageAdminToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(1187, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(183, 750);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.customerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.addToolStripMenuItem.Text = "Register";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // venueToolStripMenuItem
            // 
            this.venueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVenueToolStripMenuItem,
            this.editVenueToolStripMenuItem,
            this.deleteVenueToolStripMenuItem});
            this.venueToolStripMenuItem.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.venueToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.venueToolStripMenuItem.Name = "venueToolStripMenuItem";
            this.venueToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.venueToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.venueToolStripMenuItem.Text = "Venue";
            // 
            // addVenueToolStripMenuItem
            // 
            this.addVenueToolStripMenuItem.Name = "addVenueToolStripMenuItem";
            this.addVenueToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.addVenueToolStripMenuItem.Text = "Add Venue";
            this.addVenueToolStripMenuItem.Click += new System.EventHandler(this.addVenueToolStripMenuItem_Click);
            // 
            // editVenueToolStripMenuItem
            // 
            this.editVenueToolStripMenuItem.Name = "editVenueToolStripMenuItem";
            this.editVenueToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.editVenueToolStripMenuItem.Text = "Edit Venue";
            this.editVenueToolStripMenuItem.Click += new System.EventHandler(this.editVenueToolStripMenuItem_Click);
            // 
            // deleteVenueToolStripMenuItem
            // 
            this.deleteVenueToolStripMenuItem.Name = "deleteVenueToolStripMenuItem";
            this.deleteVenueToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.deleteVenueToolStripMenuItem.Text = "Delete Venue";
            this.deleteVenueToolStripMenuItem.Click += new System.EventHandler(this.deleteVenueToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookingToolStripMenuItem,
            this.cancelBookingToolStripMenuItem,
            this.editBookingsToolStripMenuItem});
            this.bookToolStripMenuItem.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.bookToolStripMenuItem.Text = "Bookings";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // newBookingToolStripMenuItem
            // 
            this.newBookingToolStripMenuItem.Name = "newBookingToolStripMenuItem";
            this.newBookingToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.newBookingToolStripMenuItem.Text = "New Booking";
            this.newBookingToolStripMenuItem.Click += new System.EventHandler(this.newBookingToolStripMenuItem_Click);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            this.cancelBookingToolStripMenuItem.Click += new System.EventHandler(this.cancelBookingToolStripMenuItem_Click);
            // 
            // editBookingsToolStripMenuItem
            // 
            this.editBookingsToolStripMenuItem.Name = "editBookingsToolStripMenuItem";
            this.editBookingsToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.editBookingsToolStripMenuItem.Text = "Edit Booking";
            this.editBookingsToolStripMenuItem.Click += new System.EventHandler(this.editBookingsToolStripMenuItem_Click);
            // 
            // viewStatusToolStripMenuItem
            // 
            this.viewStatusToolStripMenuItem.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStatusToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.viewStatusToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.viewStatusToolStripMenuItem.Name = "viewStatusToolStripMenuItem";
            this.viewStatusToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewStatusToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.viewStatusToolStripMenuItem.Text = "Payments";
            this.viewStatusToolStripMenuItem.Click += new System.EventHandler(this.viewStatusToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem1,
            this.venuesToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.logoutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.logoutToolStripMenuItem.Text = "View Status";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(279, 28);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click);
            // 
            // venuesToolStripMenuItem
            // 
            this.venuesToolStripMenuItem.Name = "venuesToolStripMenuItem";
            this.venuesToolStripMenuItem.Size = new System.Drawing.Size(279, 28);
            this.venuesToolStripMenuItem.Text = "Venues";
            this.venuesToolStripMenuItem.Click += new System.EventHandler(this.venuesToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(279, 28);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            this.bookingsToolStripMenuItem.Click += new System.EventHandler(this.bookingsToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(279, 28);
            this.paymentsToolStripMenuItem.Text = "Payment Receivable";
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // manageAdminToolStripMenuItem
            // 
            this.manageAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdminToolStripMenuItem,
            this.deleteAdminToolStripMenuItem});
            this.manageAdminToolStripMenuItem.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAdminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.manageAdminToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.manageAdminToolStripMenuItem.Name = "manageAdminToolStripMenuItem";
            this.manageAdminToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.manageAdminToolStripMenuItem.Text = "Manage admin";
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(215, 28);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            this.addAdminToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click);
            // 
            // deleteAdminToolStripMenuItem
            // 
            this.deleteAdminToolStripMenuItem.Name = "deleteAdminToolStripMenuItem";
            this.deleteAdminToolStripMenuItem.Size = new System.Drawing.Size(215, 28);
            this.deleteAdminToolStripMenuItem.Text = "Delete Admin";
            this.deleteAdminToolStripMenuItem.Click += new System.EventHandler(this.deleteAdminToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.logOutToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(152, 27);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(527, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.Name = "Main_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem venuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
    }
}