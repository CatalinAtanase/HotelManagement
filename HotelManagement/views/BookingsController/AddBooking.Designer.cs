namespace HotelManagement.views.BookingsController
{
    partial class AddBooking
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
            this.components = new System.ComponentModel.Container();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Btn_Add_Booking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Select_user = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.select_checkIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.select_checkOut = new System.Windows.Forms.DateTimePicker();
            this.select_camera = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.Red;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel_Button.Location = new System.Drawing.Point(452, 488);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(121, 35);
            this.Cancel_Button.TabIndex = 46;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Btn_Add_Booking
            // 
            this.Btn_Add_Booking.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Add_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add_Booking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Booking.Location = new System.Drawing.Point(312, 488);
            this.Btn_Add_Booking.Name = "Btn_Add_Booking";
            this.Btn_Add_Booking.Size = new System.Drawing.Size(121, 35);
            this.Btn_Add_Booking.TabIndex = 45;
            this.Btn_Add_Booking.Text = "&Adauga";
            this.Btn_Add_Booking.UseVisualStyleBackColor = true;
            this.Btn_Add_Booking.Click += new System.EventHandler(this.Btn_Add_Booking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 34);
            this.label1.TabIndex = 47;
            this.label1.Text = "Adauga Rezervare";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(308, 121);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 23);
            this.label.TabIndex = 48;
            this.label.Text = "Client";
            // 
            // Select_user
            // 
            this.Select_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_user.FormattingEnabled = true;
            this.Select_user.Location = new System.Drawing.Point(312, 159);
            this.Select_user.Name = "Select_user";
            this.Select_user.Size = new System.Drawing.Size(261, 33);
            this.Select_user.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(594, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 50;
            this.button1.Text = "Adauga Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // select_checkIn
            // 
            this.select_checkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.select_checkIn.Location = new System.Drawing.Point(312, 249);
            this.select_checkIn.Name = "select_checkIn";
            this.select_checkIn.Size = new System.Drawing.Size(261, 30);
            this.select_checkIn.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Check Out";
            // 
            // select_checkOut
            // 
            this.select_checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.select_checkOut.Location = new System.Drawing.Point(312, 331);
            this.select_checkOut.Name = "select_checkOut";
            this.select_checkOut.Size = new System.Drawing.Size(261, 30);
            this.select_checkOut.TabIndex = 53;
            this.select_checkOut.Value = new System.DateTime(2021, 4, 4, 0, 0, 0, 0);
            // 
            // select_camera
            // 
            this.select_camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_camera.FormattingEnabled = true;
            this.select_camera.Location = new System.Drawing.Point(312, 419);
            this.select_camera.Name = "select_camera";
            this.select_camera.Size = new System.Drawing.Size(261, 33);
            this.select_camera.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Camera";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 28);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.menuToolStripMenuItem.Text = "Sterge campuri";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(878, 595);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.select_camera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.select_checkOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.select_checkIn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Select_user);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Btn_Add_Booking);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBooking";
            this.Text = "AddBooking";
            this.Load += new System.EventHandler(this.AddBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Btn_Add_Booking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox Select_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker select_checkIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker select_checkOut;
        private System.Windows.Forms.ComboBox select_camera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}