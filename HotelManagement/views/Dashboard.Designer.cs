namespace HotelManagement.views
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_subMenu_clienti_btns = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_show_clients = new System.Windows.Forms.Button();
            this.btn_add_client = new System.Windows.Forms.Button();
            this.btn_user_dropdown = new System.Windows.Forms.Button();
            this.panel_subMenu_rezervari_btns = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_show_bookings = new System.Windows.Forms.Button();
            this.btn_add_booking = new System.Windows.Forms.Button();
            this.btn_bookings_dropdown = new System.Windows.Forms.Button();
            this.panel_subMenu_camere_btns = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_show_camere = new System.Windows.Forms.Button();
            this.btn_add_camere = new System.Windows.Forms.Button();
            this.btn_camere_dropdown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_subMenu_clienti_btns.SuspendLayout();
            this.panel_subMenu_rezervari_btns.SuspendLayout();
            this.panel_subMenu_camere_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_subMenu_clienti_btns);
            this.panel1.Controls.Add(this.btn_user_dropdown);
            this.panel1.Controls.Add(this.panel_subMenu_rezervari_btns);
            this.panel1.Controls.Add(this.btn_bookings_dropdown);
            this.panel1.Controls.Add(this.panel_subMenu_camere_btns);
            this.panel1.Controls.Add(this.btn_camere_dropdown);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 689);
            this.panel1.TabIndex = 0;
            // 
            // panel_subMenu_clienti_btns
            // 
            this.panel_subMenu_clienti_btns.BackColor = System.Drawing.Color.Lime;
            this.panel_subMenu_clienti_btns.Controls.Add(this.button9);
            this.panel_subMenu_clienti_btns.Controls.Add(this.btn_show_clients);
            this.panel_subMenu_clienti_btns.Controls.Add(this.btn_add_client);
            this.panel_subMenu_clienti_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_subMenu_clienti_btns.Location = new System.Drawing.Point(0, 546);
            this.panel_subMenu_clienti_btns.Name = "panel_subMenu_clienti_btns";
            this.panel_subMenu_clienti_btns.Size = new System.Drawing.Size(235, 109);
            this.panel_subMenu_clienti_btns.TabIndex = 8;
            this.panel_subMenu_clienti_btns.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(0, 60);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(235, 30);
            this.button9.TabIndex = 6;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btn_show_clients
            // 
            this.btn_show_clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_show_clients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_clients.FlatAppearance.BorderSize = 0;
            this.btn_show_clients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_show_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_clients.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_clients.ForeColor = System.Drawing.Color.Black;
            this.btn_show_clients.Location = new System.Drawing.Point(0, 30);
            this.btn_show_clients.Name = "btn_show_clients";
            this.btn_show_clients.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_show_clients.Size = new System.Drawing.Size(235, 30);
            this.btn_show_clients.TabIndex = 5;
            this.btn_show_clients.Text = "Afiseaza clienti";
            this.btn_show_clients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show_clients.UseVisualStyleBackColor = false;
            this.btn_show_clients.Click += new System.EventHandler(this.btn_show_clients_Click);
            // 
            // btn_add_client
            // 
            this.btn_add_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_add_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add_client.FlatAppearance.BorderSize = 0;
            this.btn_add_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_add_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_client.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_client.ForeColor = System.Drawing.Color.Black;
            this.btn_add_client.Location = new System.Drawing.Point(0, 0);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_add_client.Size = new System.Drawing.Size(235, 30);
            this.btn_add_client.TabIndex = 4;
            this.btn_add_client.Text = "Adauga client";
            this.btn_add_client.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_client.UseVisualStyleBackColor = false;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // btn_user_dropdown
            // 
            this.btn_user_dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_user_dropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_user_dropdown.FlatAppearance.BorderSize = 0;
            this.btn_user_dropdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_user_dropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_dropdown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_dropdown.ForeColor = System.Drawing.Color.Black;
            this.btn_user_dropdown.Location = new System.Drawing.Point(0, 488);
            this.btn_user_dropdown.Name = "btn_user_dropdown";
            this.btn_user_dropdown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_user_dropdown.Size = new System.Drawing.Size(235, 58);
            this.btn_user_dropdown.TabIndex = 9;
            this.btn_user_dropdown.Text = "Clienti";
            this.btn_user_dropdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_dropdown.UseVisualStyleBackColor = false;
            this.btn_user_dropdown.Click += new System.EventHandler(this.btn_user_dropdown_Click);
            // 
            // panel_subMenu_rezervari_btns
            // 
            this.panel_subMenu_rezervari_btns.BackColor = System.Drawing.Color.Lime;
            this.panel_subMenu_rezervari_btns.Controls.Add(this.button5);
            this.panel_subMenu_rezervari_btns.Controls.Add(this.btn_show_bookings);
            this.panel_subMenu_rezervari_btns.Controls.Add(this.btn_add_booking);
            this.panel_subMenu_rezervari_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_subMenu_rezervari_btns.Location = new System.Drawing.Point(0, 379);
            this.panel_subMenu_rezervari_btns.Name = "panel_subMenu_rezervari_btns";
            this.panel_subMenu_rezervari_btns.Size = new System.Drawing.Size(235, 109);
            this.panel_subMenu_rezervari_btns.TabIndex = 6;
            this.panel_subMenu_rezervari_btns.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 60);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(235, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btn_show_bookings
            // 
            this.btn_show_bookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_show_bookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_bookings.FlatAppearance.BorderSize = 0;
            this.btn_show_bookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_show_bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_bookings.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_bookings.ForeColor = System.Drawing.Color.Black;
            this.btn_show_bookings.Location = new System.Drawing.Point(0, 30);
            this.btn_show_bookings.Name = "btn_show_bookings";
            this.btn_show_bookings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_show_bookings.Size = new System.Drawing.Size(235, 30);
            this.btn_show_bookings.TabIndex = 5;
            this.btn_show_bookings.Text = "Afiseaza rezervari";
            this.btn_show_bookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show_bookings.UseVisualStyleBackColor = false;
            this.btn_show_bookings.Click += new System.EventHandler(this.btn_show_bookings_Click);
            // 
            // btn_add_booking
            // 
            this.btn_add_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_add_booking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add_booking.FlatAppearance.BorderSize = 0;
            this.btn_add_booking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_add_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_booking.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_booking.ForeColor = System.Drawing.Color.Black;
            this.btn_add_booking.Location = new System.Drawing.Point(0, 0);
            this.btn_add_booking.Name = "btn_add_booking";
            this.btn_add_booking.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_add_booking.Size = new System.Drawing.Size(235, 30);
            this.btn_add_booking.TabIndex = 4;
            this.btn_add_booking.Text = "Adauga rezervare";
            this.btn_add_booking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_booking.UseVisualStyleBackColor = false;
            this.btn_add_booking.Click += new System.EventHandler(this.btn_add_booking_Click);
            // 
            // btn_bookings_dropdown
            // 
            this.btn_bookings_dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_bookings_dropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bookings_dropdown.FlatAppearance.BorderSize = 0;
            this.btn_bookings_dropdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_bookings_dropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bookings_dropdown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookings_dropdown.ForeColor = System.Drawing.Color.Black;
            this.btn_bookings_dropdown.Location = new System.Drawing.Point(0, 321);
            this.btn_bookings_dropdown.Name = "btn_bookings_dropdown";
            this.btn_bookings_dropdown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_bookings_dropdown.Size = new System.Drawing.Size(235, 58);
            this.btn_bookings_dropdown.TabIndex = 7;
            this.btn_bookings_dropdown.Text = "Rezervari";
            this.btn_bookings_dropdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bookings_dropdown.UseVisualStyleBackColor = false;
            this.btn_bookings_dropdown.Click += new System.EventHandler(this.btn_bookings_dropdown_Click);
            // 
            // panel_subMenu_camere_btns
            // 
            this.panel_subMenu_camere_btns.BackColor = System.Drawing.Color.Lime;
            this.panel_subMenu_camere_btns.Controls.Add(this.button4);
            this.panel_subMenu_camere_btns.Controls.Add(this.btn_show_camere);
            this.panel_subMenu_camere_btns.Controls.Add(this.btn_add_camere);
            this.panel_subMenu_camere_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_subMenu_camere_btns.Location = new System.Drawing.Point(0, 216);
            this.panel_subMenu_camere_btns.Name = "panel_subMenu_camere_btns";
            this.panel_subMenu_camere_btns.Size = new System.Drawing.Size(235, 105);
            this.panel_subMenu_camere_btns.TabIndex = 4;
            this.panel_subMenu_camere_btns.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, 60);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(235, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_show_camere
            // 
            this.btn_show_camere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_show_camere.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_camere.FlatAppearance.BorderSize = 0;
            this.btn_show_camere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_show_camere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_camere.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_camere.ForeColor = System.Drawing.Color.Black;
            this.btn_show_camere.Location = new System.Drawing.Point(0, 30);
            this.btn_show_camere.Name = "btn_show_camere";
            this.btn_show_camere.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_show_camere.Size = new System.Drawing.Size(235, 30);
            this.btn_show_camere.TabIndex = 5;
            this.btn_show_camere.Text = "Afiseaza camere";
            this.btn_show_camere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show_camere.UseVisualStyleBackColor = false;
            this.btn_show_camere.Click += new System.EventHandler(this.btn_show_camere_Click);
            // 
            // btn_add_camere
            // 
            this.btn_add_camere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_add_camere.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add_camere.FlatAppearance.BorderSize = 0;
            this.btn_add_camere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_add_camere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_camere.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_camere.ForeColor = System.Drawing.Color.Black;
            this.btn_add_camere.Location = new System.Drawing.Point(0, 0);
            this.btn_add_camere.Name = "btn_add_camere";
            this.btn_add_camere.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_add_camere.Size = new System.Drawing.Size(235, 30);
            this.btn_add_camere.TabIndex = 4;
            this.btn_add_camere.Text = "Adauga camere";
            this.btn_add_camere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_camere.UseVisualStyleBackColor = false;
            this.btn_add_camere.Click += new System.EventHandler(this.btn_add_camere_Click);
            // 
            // btn_camere_dropdown
            // 
            this.btn_camere_dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_camere_dropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_camere_dropdown.FlatAppearance.BorderSize = 0;
            this.btn_camere_dropdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_camere_dropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_camere_dropdown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_camere_dropdown.ForeColor = System.Drawing.Color.Black;
            this.btn_camere_dropdown.Location = new System.Drawing.Point(0, 158);
            this.btn_camere_dropdown.Name = "btn_camere_dropdown";
            this.btn_camere_dropdown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_camere_dropdown.Size = new System.Drawing.Size(235, 58);
            this.btn_camere_dropdown.TabIndex = 5;
            this.btn_camere_dropdown.Text = "Camere";
            this.btn_camere_dropdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_camere_dropdown.UseVisualStyleBackColor = false;
            this.btn_camere_dropdown.Click += new System.EventHandler(this.btn_camere_dropdown_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 158);
            this.panel2.TabIndex = 1;
            // 
            // panel_childForm
            // 
            this.panel_childForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Location = new System.Drawing.Point(235, 0);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Padding = new System.Windows.Forms.Padding(30);
            this.panel_childForm.Size = new System.Drawing.Size(1050, 689);
            this.panel_childForm.TabIndex = 1;
            this.panel_childForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_childForm_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1285, 689);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel_subMenu_clienti_btns.ResumeLayout(false);
            this.panel_subMenu_rezervari_btns.ResumeLayout(false);
            this.panel_subMenu_camere_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_subMenu_clienti_btns;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_show_clients;
        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.Button btn_user_dropdown;
        private System.Windows.Forms.Panel panel_subMenu_rezervari_btns;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_show_bookings;
        private System.Windows.Forms.Button btn_add_booking;
        private System.Windows.Forms.Button btn_bookings_dropdown;
        private System.Windows.Forms.Panel panel_subMenu_camere_btns;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_show_camere;
        private System.Windows.Forms.Button btn_add_camere;
        private System.Windows.Forms.Button btn_camere_dropdown;
        private System.Windows.Forms.Panel panel_childForm;
    }
}