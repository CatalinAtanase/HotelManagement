namespace HotelManagement.views.UsersController
{
    partial class ShowUsers
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
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delete_users = new System.Windows.Forms.Button();
            this.Btn_Edit_Room = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.BackgroundColor = System.Drawing.Color.White;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Prenume,
            this.Email,
            this.CNP,
            this.Telefon});
            this.dgv_users.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_users.Location = new System.Drawing.Point(63, 52);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.RowHeadersWidth = 51;
            this.dgv_users.RowTemplate.Height = 24;
            this.dgv_users.Size = new System.Drawing.Size(907, 316);
            this.dgv_users.TabIndex = 0;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 6;
            this.Nume.Name = "Nume";
            this.Nume.Width = 125;
            // 
            // Prenume
            // 
            this.Prenume.HeaderText = "Prenume";
            this.Prenume.MinimumWidth = 6;
            this.Prenume.Name = "Prenume";
            this.Prenume.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // CNP
            // 
            this.CNP.HeaderText = "CNP";
            this.CNP.MinimumWidth = 6;
            this.CNP.Name = "CNP";
            this.CNP.Width = 125;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 125;
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
            // btn_delete_users
            // 
            this.btn_delete_users.BackColor = System.Drawing.Color.Red;
            this.btn_delete_users.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_delete_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_users.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_users.Location = new System.Drawing.Point(220, 402);
            this.btn_delete_users.Name = "btn_delete_users";
            this.btn_delete_users.Size = new System.Drawing.Size(121, 35);
            this.btn_delete_users.TabIndex = 29;
            this.btn_delete_users.Text = "&Delete";
            this.btn_delete_users.UseVisualStyleBackColor = false;
            this.btn_delete_users.Click += new System.EventHandler(this.btn_delete_user_Click);
            // 
            // Btn_Edit_Room
            // 
            this.Btn_Edit_Room.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Edit_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit_Room.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit_Room.Location = new System.Drawing.Point(63, 402);
            this.Btn_Edit_Room.Name = "Btn_Edit_Room";
            this.Btn_Edit_Room.Size = new System.Drawing.Size(121, 35);
            this.Btn_Edit_Room.TabIndex = 28;
            this.Btn_Edit_Room.Text = "&Edit";
            this.Btn_Edit_Room.UseVisualStyleBackColor = true;
            this.Btn_Edit_Room.Click += new System.EventHandler(this.Btn_Edit_Room_Click);
            // 
            // ShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1032, 595);
            this.Controls.Add(this.btn_delete_users);
            this.Controls.Add(this.Btn_Edit_Room);
            this.Controls.Add(this.dgv_users);
            this.Name = "ShowUsers";
            this.Text = "ShowUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.Button btn_delete_users;
        private System.Windows.Forms.Button Btn_Edit_Room;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
    }
}