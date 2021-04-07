namespace HotelManagement.views.BookingsController
{
    partial class ShowBookings
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
            this.dgv_bookings = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delete_room = new System.Windows.Forms.Button();
            this.Btn_Edit_Room = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookings)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_bookings
            // 
            this.dgv_bookings.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.StartDate,
            this.EndDate,
            this.Camera});
            this.dgv_bookings.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_bookings.Location = new System.Drawing.Point(105, 76);
            this.dgv_bookings.Name = "dgv_bookings";
            this.dgv_bookings.RowHeadersWidth = 51;
            this.dgv_bookings.RowTemplate.Height = 24;
            this.dgv_bookings.Size = new System.Drawing.Size(798, 411);
            this.dgv_bookings.TabIndex = 0;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "CheckIn";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "CheckOut";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 125;
            // 
            // Camera
            // 
            this.Camera.HeaderText = "Camera";
            this.Camera.MinimumWidth = 6;
            this.Camera.Name = "Camera";
            this.Camera.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // btn_delete_room
            // 
            this.btn_delete_room.BackColor = System.Drawing.Color.Red;
            this.btn_delete_room.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_delete_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_room.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_room.Location = new System.Drawing.Point(262, 525);
            this.btn_delete_room.Name = "btn_delete_room";
            this.btn_delete_room.Size = new System.Drawing.Size(121, 35);
            this.btn_delete_room.TabIndex = 29;
            this.btn_delete_room.Text = "&Delete";
            this.btn_delete_room.UseVisualStyleBackColor = false;
            this.btn_delete_room.Click += new System.EventHandler(this.btn_delete_room_Click);
            // 
            // Btn_Edit_Room
            // 
            this.Btn_Edit_Room.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Edit_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit_Room.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit_Room.Location = new System.Drawing.Point(105, 525);
            this.Btn_Edit_Room.Name = "Btn_Edit_Room";
            this.Btn_Edit_Room.Size = new System.Drawing.Size(121, 35);
            this.Btn_Edit_Room.TabIndex = 28;
            this.Btn_Edit_Room.Text = "&Edit";
            this.Btn_Edit_Room.UseVisualStyleBackColor = true;
            this.Btn_Edit_Room.Click += new System.EventHandler(this.Btn_Edit_Room_Click);
            // 
            // ShowBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1050, 642);
            this.Controls.Add(this.btn_delete_room);
            this.Controls.Add(this.Btn_Edit_Room);
            this.Controls.Add(this.dgv_bookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowBookings";
            this.Text = "ShowBookings";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookings)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camera;
        private System.Windows.Forms.Button btn_delete_room;
        private System.Windows.Forms.Button Btn_Edit_Room;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
    }
}