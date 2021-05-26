namespace HotelManagement.views.RoomsController
{
    partial class EditRoom
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
            this.Btn_FinishEdit_Room = new System.Windows.Forms.Button();
            this.CB_camera_premium = new System.Windows.Forms.CheckBox();
            this.Select_capacitate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_pret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_numar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.err_label = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.Red;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel_Button.Location = new System.Drawing.Point(413, 394);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(121, 35);
            this.Cancel_Button.TabIndex = 36;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Btn_FinishEdit_Room
            // 
            this.Btn_FinishEdit_Room.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_FinishEdit_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FinishEdit_Room.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FinishEdit_Room.Location = new System.Drawing.Point(273, 394);
            this.Btn_FinishEdit_Room.Name = "Btn_FinishEdit_Room";
            this.Btn_FinishEdit_Room.Size = new System.Drawing.Size(121, 35);
            this.Btn_FinishEdit_Room.TabIndex = 35;
            this.Btn_FinishEdit_Room.Text = "&Edit";
            this.Btn_FinishEdit_Room.UseVisualStyleBackColor = true;
            this.Btn_FinishEdit_Room.Click += new System.EventHandler(this.Btn_FinishEdit_Room_Click);
            // 
            // CB_camera_premium
            // 
            this.CB_camera_premium.AutoSize = true;
            this.CB_camera_premium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_camera_premium.Location = new System.Drawing.Point(273, 337);
            this.CB_camera_premium.Name = "CB_camera_premium";
            this.CB_camera_premium.Size = new System.Drawing.Size(204, 27);
            this.CB_camera_premium.TabIndex = 34;
            this.CB_camera_premium.Text = "Camera Premium";
            this.CB_camera_premium.UseVisualStyleBackColor = true;
            // 
            // Select_capacitate
            // 
            this.Select_capacitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_capacitate.FormattingEnabled = true;
            this.Select_capacitate.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Select_capacitate.Location = new System.Drawing.Point(273, 283);
            this.Select_capacitate.Name = "Select_capacitate";
            this.Select_capacitate.Size = new System.Drawing.Size(261, 33);
            this.Select_capacitate.TabIndex = 33;
            this.Select_capacitate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Capacitate";
            // 
            // tb_pret
            // 
            this.tb_pret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pret.Location = new System.Drawing.Point(273, 206);
            this.tb_pret.Name = "tb_pret";
            this.tb_pret.Size = new System.Drawing.Size(261, 30);
            this.tb_pret.TabIndex = 31;
            this.tb_pret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Pret";
            // 
            // tb_numar
            // 
            this.tb_numar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numar.Location = new System.Drawing.Point(273, 122);
            this.tb_numar.Name = "tb_numar";
            this.tb_numar.Size = new System.Drawing.Size(261, 30);
            this.tb_numar.TabIndex = 29;
            this.tb_numar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Numar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Editeaza Camera";
            // 
            // err_label
            // 
            this.err_label.AutoSize = true;
            this.err_label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_label.ForeColor = System.Drawing.Color.DarkRed;
            this.err_label.Location = new System.Drawing.Point(271, 68);
            this.err_label.Name = "err_label";
            this.err_label.Size = new System.Drawing.Size(0, 19);
            this.err_label.TabIndex = 37;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(878, 595);
            this.Controls.Add(this.err_label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Btn_FinishEdit_Room);
            this.Controls.Add(this.CB_camera_premium);
            this.Controls.Add(this.Select_capacitate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_pret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_numar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "EditRoom";
            this.Text = "EditRoom";
            this.Load += new System.EventHandler(this.EditRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Btn_FinishEdit_Room;
        private System.Windows.Forms.CheckBox CB_camera_premium;
        private System.Windows.Forms.ComboBox Select_capacitate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_pret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_numar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label err_label;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}