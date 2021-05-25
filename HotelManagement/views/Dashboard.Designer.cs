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
            this.btn_saveUsers = new System.Windows.Forms.Button();
            this.btn_show_clients = new System.Windows.Forms.Button();
            this.btn_add_client = new System.Windows.Forms.Button();
            this.btn_user_dropdown = new System.Windows.Forms.Button();
            this.panel_subMenu_rezervari_btns = new System.Windows.Forms.Panel();
            this.btn_saveBookings = new System.Windows.Forms.Button();
            this.btn_show_bookings = new System.Windows.Forms.Button();
            this.btn_add_booking = new System.Windows.Forms.Button();
            this.btn_bookings_dropdown = new System.Windows.Forms.Button();
            this.panel_subMenu_camere_btns = new System.Windows.Forms.Panel();
            this.btn_save_rooms = new System.Windows.Forms.Button();
            this.btn_show_camere = new System.Windows.Forms.Button();
            this.btn_add_camere = new System.Windows.Forms.Button();
            this.btn_camere_dropdown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeUC1 = new HotelManagement.DateTimeUC();
            this.panel1.SuspendLayout();
            this.panel_subMenu_clienti_btns.SuspendLayout();
            this.panel_subMenu_rezervari_btns.SuspendLayout();
            this.panel_subMenu_camere_btns.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimeUC1);
            this.panel1.Controls.Add(this.panel_subMenu_clienti_btns);
            this.panel1.Controls.Add(this.btn_user_dropdown);
            this.panel1.Controls.Add(this.panel_subMenu_rezervari_btns);
            this.panel1.Controls.Add(this.btn_bookings_dropdown);
            this.panel1.Controls.Add(this.panel_subMenu_camere_btns);
            this.panel1.Controls.Add(this.btn_camere_dropdown);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 826);
            this.panel1.TabIndex = 0;
            // 
            // panel_subMenu_clienti_btns
            // 
            this.panel_subMenu_clienti_btns.BackColor = System.Drawing.Color.Lime;
            this.panel_subMenu_clienti_btns.Controls.Add(this.btn_saveUsers);
            this.panel_subMenu_clienti_btns.Controls.Add(this.btn_show_clients);
            this.panel_subMenu_clienti_btns.Controls.Add(this.btn_add_client);
            this.panel_subMenu_clienti_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_subMenu_clienti_btns.Location = new System.Drawing.Point(0, 541);
            this.panel_subMenu_clienti_btns.Name = "panel_subMenu_clienti_btns";
            this.panel_subMenu_clienti_btns.Size = new System.Drawing.Size(235, 109);
            this.panel_subMenu_clienti_btns.TabIndex = 8;
            this.panel_subMenu_clienti_btns.Visible = false;
            // 
            // btn_saveUsers
            // 
            this.btn_saveUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_saveUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_saveUsers.FlatAppearance.BorderSize = 0;
            this.btn_saveUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_saveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveUsers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveUsers.ForeColor = System.Drawing.Color.Black;
            this.btn_saveUsers.Location = new System.Drawing.Point(0, 60);
            this.btn_saveUsers.Name = "btn_saveUsers";
            this.btn_saveUsers.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_saveUsers.Size = new System.Drawing.Size(235, 30);
            this.btn_saveUsers.TabIndex = 6;
            this.btn_saveUsers.Text = "Salveaza clienti";
            this.btn_saveUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveUsers.UseVisualStyleBackColor = false;
            this.btn_saveUsers.Click += new System.EventHandler(this.btn_saveUsers_Click);
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
            this.btn_user_dropdown.Location = new System.Drawing.Point(0, 483);
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
            this.panel_subMenu_rezervari_btns.Controls.Add(this.btn_saveBookings);
            this.panel_subMenu_rezervari_btns.Controls.Add(this.btn_show_bookings);
            this.panel_subMenu_rezervari_btns.Controls.Add(this.btn_add_booking);
            this.panel_subMenu_rezervari_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_subMenu_rezervari_btns.Location = new System.Drawing.Point(0, 374);
            this.panel_subMenu_rezervari_btns.Name = "panel_subMenu_rezervari_btns";
            this.panel_subMenu_rezervari_btns.Size = new System.Drawing.Size(235, 109);
            this.panel_subMenu_rezervari_btns.TabIndex = 6;
            this.panel_subMenu_rezervari_btns.Visible = false;
            // 
            // btn_saveBookings
            // 
            this.btn_saveBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_saveBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_saveBookings.FlatAppearance.BorderSize = 0;
            this.btn_saveBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_saveBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveBookings.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveBookings.ForeColor = System.Drawing.Color.Black;
            this.btn_saveBookings.Location = new System.Drawing.Point(0, 60);
            this.btn_saveBookings.Name = "btn_saveBookings";
            this.btn_saveBookings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_saveBookings.Size = new System.Drawing.Size(235, 30);
            this.btn_saveBookings.TabIndex = 6;
            this.btn_saveBookings.Text = "Sterge rezervari";
            this.btn_saveBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveBookings.UseVisualStyleBackColor = false;
            this.btn_saveBookings.Click += new System.EventHandler(this.btn_saveBookings_Click);
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
            this.btn_bookings_dropdown.Location = new System.Drawing.Point(0, 316);
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
            this.panel_subMenu_camere_btns.Controls.Add(this.btn_save_rooms);
            this.panel_subMenu_camere_btns.Controls.Add(this.btn_show_camere);
            this.panel_subMenu_camere_btns.Controls.Add(this.btn_add_camere);
            this.panel_subMenu_camere_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_subMenu_camere_btns.Location = new System.Drawing.Point(0, 216);
            this.panel_subMenu_camere_btns.Name = "panel_subMenu_camere_btns";
            this.panel_subMenu_camere_btns.Size = new System.Drawing.Size(235, 100);
            this.panel_subMenu_camere_btns.TabIndex = 4;
            this.panel_subMenu_camere_btns.Visible = false;
            // 
            // btn_save_rooms
            // 
            this.btn_save_rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_save_rooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_save_rooms.FlatAppearance.BorderSize = 0;
            this.btn_save_rooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_save_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_rooms.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_rooms.ForeColor = System.Drawing.Color.Black;
            this.btn_save_rooms.Location = new System.Drawing.Point(0, 60);
            this.btn_save_rooms.Name = "btn_save_rooms";
            this.btn_save_rooms.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_save_rooms.Size = new System.Drawing.Size(235, 30);
            this.btn_save_rooms.TabIndex = 6;
            this.btn_save_rooms.Text = "Statistici";
            this.btn_save_rooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_rooms.UseVisualStyleBackColor = false;
            this.btn_save_rooms.Click += new System.EventHandler(this.btn_save_rooms_Click);
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
            this.panel2.BackgroundImage = global::HotelManagement.Properties.Resources.hotel;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.panel_childForm.Location = new System.Drawing.Point(235, 30);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Padding = new System.Windows.Forms.Padding(30);
            this.panel_childForm.Size = new System.Drawing.Size(1050, 826);
            this.panel_childForm.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1285, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.rezervareToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.adaugaToolStripMenuItem.Text = "Menu";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.cameraToolStripMenuItem.Text = "Camera";
            this.cameraToolStripMenuItem.Click += new System.EventHandler(this.cameraToolStripMenuItem_Click);
            // 
            // rezervareToolStripMenuItem
            // 
            this.rezervareToolStripMenuItem.Name = "rezervareToolStripMenuItem";
            this.rezervareToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.rezervareToolStripMenuItem.Text = "Rezervare";
            this.rezervareToolStripMenuItem.Click += new System.EventHandler(this.rezervareToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // dateTimeUC1
            // 
            this.dateTimeUC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimeUC1.Location = new System.Drawing.Point(0, 650);
            this.dateTimeUC1.Name = "dateTimeUC1";
            this.dateTimeUC1.Size = new System.Drawing.Size(235, 42);
            this.dateTimeUC1.TabIndex = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1285, 856);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel_subMenu_clienti_btns.ResumeLayout(false);
            this.panel_subMenu_rezervari_btns.ResumeLayout(false);
            this.panel_subMenu_camere_btns.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_subMenu_clienti_btns;
        private System.Windows.Forms.Button btn_saveUsers;
        private System.Windows.Forms.Button btn_show_clients;
        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.Button btn_user_dropdown;
        private System.Windows.Forms.Panel panel_subMenu_rezervari_btns;
        private System.Windows.Forms.Button btn_saveBookings;
        private System.Windows.Forms.Button btn_show_bookings;
        private System.Windows.Forms.Button btn_add_booking;
        private System.Windows.Forms.Button btn_bookings_dropdown;
        private System.Windows.Forms.Panel panel_subMenu_camere_btns;
        private System.Windows.Forms.Button btn_save_rooms;
        private System.Windows.Forms.Button btn_show_camere;
        private System.Windows.Forms.Button btn_add_camere;
        private System.Windows.Forms.Button btn_camere_dropdown;
        private System.Windows.Forms.Panel panel_childForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private DateTimeUC dateTimeUC1;
    }
}