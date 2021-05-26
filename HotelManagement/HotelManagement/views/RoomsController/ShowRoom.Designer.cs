namespace HotelManagement.views.RoomsController
{
    partial class listView_showRoom
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_showRooms = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marestrePretCu100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scadePretCu100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Edit_Room = new System.Windows.Forms.Button();
            this.btn_delete_room = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showRooms)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dgv_showRooms
            // 
            this.dgv_showRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_showRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgv_showRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Capacity,
            this.Premium,
            this.Pret});
            this.dgv_showRooms.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_showRooms.Location = new System.Drawing.Point(68, 53);
            this.dgv_showRooms.Name = "dgv_showRooms";
            this.dgv_showRooms.RowHeadersWidth = 51;
            this.dgv_showRooms.RowTemplate.Height = 24;
            this.dgv_showRooms.Size = new System.Drawing.Size(970, 394);
            this.dgv_showRooms.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.marestrePretCu100ToolStripMenuItem,
            this.scadePretCu100ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 100);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // marestrePretCu100ToolStripMenuItem
            // 
            this.marestrePretCu100ToolStripMenuItem.Name = "marestrePretCu100ToolStripMenuItem";
            this.marestrePretCu100ToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.marestrePretCu100ToolStripMenuItem.Text = "Marestre pret cu 100";
            this.marestrePretCu100ToolStripMenuItem.Click += new System.EventHandler(this.marestrePretCu100ToolStripMenuItem_Click);
            // 
            // scadePretCu100ToolStripMenuItem
            // 
            this.scadePretCu100ToolStripMenuItem.Name = "scadePretCu100ToolStripMenuItem";
            this.scadePretCu100ToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.scadePretCu100ToolStripMenuItem.Text = "Scade pret cu 100";
            this.scadePretCu100ToolStripMenuItem.Click += new System.EventHandler(this.scadePretCu100ToolStripMenuItem_Click);
            // 
            // Btn_Edit_Room
            // 
            this.Btn_Edit_Room.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Edit_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit_Room.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit_Room.Location = new System.Drawing.Point(68, 478);
            this.Btn_Edit_Room.Name = "Btn_Edit_Room";
            this.Btn_Edit_Room.Size = new System.Drawing.Size(121, 35);
            this.Btn_Edit_Room.TabIndex = 26;
            this.Btn_Edit_Room.Text = "&Edit";
            this.Btn_Edit_Room.UseVisualStyleBackColor = true;
            this.Btn_Edit_Room.Click += new System.EventHandler(this.Btn_Edit_Room_Click);
            // 
            // btn_delete_room
            // 
            this.btn_delete_room.BackColor = System.Drawing.Color.Red;
            this.btn_delete_room.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_delete_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_room.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_room.Location = new System.Drawing.Point(225, 478);
            this.btn_delete_room.Name = "btn_delete_room";
            this.btn_delete_room.Size = new System.Drawing.Size(121, 35);
            this.btn_delete_room.TabIndex = 27;
            this.btn_delete_room.Text = "&Delete";
            this.btn_delete_room.UseVisualStyleBackColor = false;
            this.btn_delete_room.Click += new System.EventHandler(this.btn_delete_room_Click);
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 125;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.Width = 125;
            // 
            // Premium
            // 
            this.Premium.HeaderText = "Premium";
            this.Premium.MinimumWidth = 6;
            this.Premium.Name = "Premium";
            this.Premium.Width = 125;
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.MinimumWidth = 6;
            this.Pret.Name = "Pret";
            this.Pret.Width = 125;
            // 
            // listView_showRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1050, 642);
            this.Controls.Add(this.btn_delete_room);
            this.Controls.Add(this.Btn_Edit_Room);
            this.Controls.Add(this.dgv_showRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listView_showRoom";
            this.Text = "ShowRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showRooms)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgv_showRooms;
        private System.Windows.Forms.Button Btn_Edit_Room;
        private System.Windows.Forms.Button btn_delete_room;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marestrePretCu100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scadePretCu100ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premium;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
    }
}