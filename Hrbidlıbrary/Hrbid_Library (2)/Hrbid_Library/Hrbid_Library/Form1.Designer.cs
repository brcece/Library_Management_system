namespace Hrbid_Library
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button button1;
            this.form1_button_close = new System.Windows.Forms.Button();
            this.form1_label_tıtle = new System.Windows.Forms.Label();
            this.form1_label_welcome = new System.Windows.Forms.Label();
            this.form1_pictureBox_1 = new System.Windows.Forms.PictureBox();
            this.form1_pictureBox_2 = new System.Windows.Forms.PictureBox();
            this.form1_textbox_username = new System.Windows.Forms.TextBox();
            this.form1_textBox_password = new System.Windows.Forms.TextBox();
            this.form1_pictureBox_3 = new System.Windows.Forms.PictureBox();
            this.form1_pictureBox_4 = new System.Windows.Forms.PictureBox();
            this.form1_panel_1 = new System.Windows.Forms.Panel();
            this.form1_panel_2 = new System.Windows.Forms.Panel();
            this.form_button_logın = new System.Windows.Forms.Button();
            this.form1_button_sıngup = new System.Windows.Forms.Button();
            this.form1_panel_3 = new System.Windows.Forms.Panel();
            this.form1_panel_4 = new System.Windows.Forms.Panel();
            this.form1_panel_6 = new System.Windows.Forms.Panel();
            this.form1_panel_5 = new System.Windows.Forms.Panel();
            this.form1_linklabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.form1_pictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1_pictureBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1_pictureBox_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1_pictureBox_4)).BeginInit();
            this.SuspendLayout();
            // 
            // form1_button_close
            // 
            this.form1_button_close.BackColor = System.Drawing.Color.Olive;
            this.form1_button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.form1_button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form1_button_close.ForeColor = System.Drawing.Color.Maroon;
            this.form1_button_close.Location = new System.Drawing.Point(287, 0);
            this.form1_button_close.Name = "form1_button_close";
            this.form1_button_close.Size = new System.Drawing.Size(28, 30);
            this.form1_button_close.TabIndex = 0;
            this.form1_button_close.Text = "X";
            this.form1_button_close.UseVisualStyleBackColor = false;
            this.form1_button_close.Click += new System.EventHandler(this.form1_button_close_Click);
            // 
            // form1_label_tıtle
            // 
            this.form1_label_tıtle.AutoSize = true;
            this.form1_label_tıtle.Font = new System.Drawing.Font("Terminator Two", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form1_label_tıtle.ForeColor = System.Drawing.Color.Teal;
            this.form1_label_tıtle.Location = new System.Drawing.Point(44, 9);
            this.form1_label_tıtle.Name = "form1_label_tıtle";
            this.form1_label_tıtle.Size = new System.Drawing.Size(221, 23);
            this.form1_label_tıtle.TabIndex = 1;
            this.form1_label_tıtle.Text = "hrbid library";
            // 
            // form1_label_welcome
            // 
            this.form1_label_welcome.AutoSize = true;
            this.form1_label_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.form1_label_welcome.Font = new System.Drawing.Font("Terminator Two", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form1_label_welcome.ForeColor = System.Drawing.Color.Green;
            this.form1_label_welcome.Location = new System.Drawing.Point(216, 33);
            this.form1_label_welcome.Name = "form1_label_welcome";
            this.form1_label_welcome.Size = new System.Drawing.Size(76, 13);
            this.form1_label_welcome.TabIndex = 2;
            this.form1_label_welcome.Text = "welcome";
            // 
            // form1_pictureBox_1
            // 
            this.form1_pictureBox_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("form1_pictureBox_1.BackgroundImage")));
            this.form1_pictureBox_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.form1_pictureBox_1.ErrorImage = null;
            this.form1_pictureBox_1.Location = new System.Drawing.Point(105, 53);
            this.form1_pictureBox_1.Name = "form1_pictureBox_1";
            this.form1_pictureBox_1.Size = new System.Drawing.Size(100, 94);
            this.form1_pictureBox_1.TabIndex = 3;
            this.form1_pictureBox_1.TabStop = false;
            // 
            // form1_pictureBox_2
            // 
            this.form1_pictureBox_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("form1_pictureBox_2.BackgroundImage")));
            this.form1_pictureBox_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.form1_pictureBox_2.Location = new System.Drawing.Point(-5, 137);
            this.form1_pictureBox_2.Name = "form1_pictureBox_2";
            this.form1_pictureBox_2.Size = new System.Drawing.Size(320, 33);
            this.form1_pictureBox_2.TabIndex = 4;
            this.form1_pictureBox_2.TabStop = false;
            this.form1_pictureBox_2.Click += new System.EventHandler(this.form1_pictureBox_2_Click);
            // 
            // form1_textbox_username
            // 
            this.form1_textbox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.form1_textbox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.form1_textbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form1_textbox_username.ForeColor = System.Drawing.Color.White;
            this.form1_textbox_username.Location = new System.Drawing.Point(80, 176);
            this.form1_textbox_username.Name = "form1_textbox_username";
            this.form1_textbox_username.Size = new System.Drawing.Size(184, 15);
            this.form1_textbox_username.TabIndex = 5;
            this.form1_textbox_username.Text = "Username";
            this.form1_textbox_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.form1_textbox_username_MouseClick);
            this.form1_textbox_username.TextChanged += new System.EventHandler(this.form1_textbox_username_TextChanged);
            // 
            // form1_textBox_password
            // 
            this.form1_textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.form1_textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.form1_textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form1_textBox_password.ForeColor = System.Drawing.Color.White;
            this.form1_textBox_password.Location = new System.Drawing.Point(80, 232);
            this.form1_textBox_password.Name = "form1_textBox_password";
            this.form1_textBox_password.Size = new System.Drawing.Size(184, 15);
            this.form1_textBox_password.TabIndex = 6;
            this.form1_textBox_password.Text = "Password";
            this.form1_textBox_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.form1_textBox_password_MouseClick);
            this.form1_textBox_password.TextChanged += new System.EventHandler(this.form1_textBox_password_TextChanged);
            this.form1_textBox_password.MouseEnter += new System.EventHandler(this.form1_textBox_password_MouseEnter);
            // 
            // form1_pictureBox_3
            // 
            this.form1_pictureBox_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("form1_pictureBox_3.BackgroundImage")));
            this.form1_pictureBox_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.form1_pictureBox_3.Location = new System.Drawing.Point(47, 176);
            this.form1_pictureBox_3.Name = "form1_pictureBox_3";
            this.form1_pictureBox_3.Size = new System.Drawing.Size(27, 22);
            this.form1_pictureBox_3.TabIndex = 7;
            this.form1_pictureBox_3.TabStop = false;
            // 
            // form1_pictureBox_4
            // 
            this.form1_pictureBox_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("form1_pictureBox_4.BackgroundImage")));
            this.form1_pictureBox_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.form1_pictureBox_4.Location = new System.Drawing.Point(47, 232);
            this.form1_pictureBox_4.Name = "form1_pictureBox_4";
            this.form1_pictureBox_4.Size = new System.Drawing.Size(27, 22);
            this.form1_pictureBox_4.TabIndex = 8;
            this.form1_pictureBox_4.TabStop = false;
            // 
            // form1_panel_1
            // 
            this.form1_panel_1.BackColor = System.Drawing.Color.White;
            this.form1_panel_1.ForeColor = System.Drawing.Color.White;
            this.form1_panel_1.Location = new System.Drawing.Point(80, 195);
            this.form1_panel_1.Name = "form1_panel_1";
            this.form1_panel_1.Size = new System.Drawing.Size(184, 1);
            this.form1_panel_1.TabIndex = 9;
            // 
            // form1_panel_2
            // 
            this.form1_panel_2.BackColor = System.Drawing.Color.White;
            this.form1_panel_2.ForeColor = System.Drawing.Color.White;
            this.form1_panel_2.Location = new System.Drawing.Point(80, 253);
            this.form1_panel_2.Name = "form1_panel_2";
            this.form1_panel_2.Size = new System.Drawing.Size(184, 1);
            this.form1_panel_2.TabIndex = 10;
            // 
            // form_button_logın
            // 
            this.form_button_logın.BackColor = System.Drawing.Color.Olive;
            this.form_button_logın.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.form_button_logın.Font = new System.Drawing.Font("Terminator Two", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form_button_logın.ForeColor = System.Drawing.Color.Black;
            this.form_button_logın.Location = new System.Drawing.Point(47, 286);
            this.form_button_logın.Name = "form_button_logın";
            this.form_button_logın.Size = new System.Drawing.Size(217, 33);
            this.form_button_logın.TabIndex = 11;
            this.form_button_logın.Text = "LOGIN";
            this.form_button_logın.UseVisualStyleBackColor = false;
            this.form_button_logın.Click += new System.EventHandler(this.form_button_logın_Click);
            // 
            // form1_button_sıngup
            // 
            this.form1_button_sıngup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.form1_button_sıngup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.form1_button_sıngup.Font = new System.Drawing.Font("Terminator Two", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form1_button_sıngup.Location = new System.Drawing.Point(47, 325);
            this.form1_button_sıngup.Name = "form1_button_sıngup";
            this.form1_button_sıngup.Size = new System.Drawing.Size(217, 33);
            this.form1_button_sıngup.TabIndex = 12;
            this.form1_button_sıngup.Text = "SING UP";
            this.form1_button_sıngup.UseVisualStyleBackColor = false;
            this.form1_button_sıngup.Click += new System.EventHandler(this.form1_button_sıngup_Click);
            // 
            // form1_panel_3
            // 
            this.form1_panel_3.BackColor = System.Drawing.Color.GreenYellow;
            this.form1_panel_3.Location = new System.Drawing.Point(-3, 0);
            this.form1_panel_3.Name = "form1_panel_3";
            this.form1_panel_3.Size = new System.Drawing.Size(318, 1);
            this.form1_panel_3.TabIndex = 13;
            // 
            // form1_panel_4
            // 
            this.form1_panel_4.BackColor = System.Drawing.Color.GreenYellow;
            this.form1_panel_4.Location = new System.Drawing.Point(311, 0);
            this.form1_panel_4.Name = "form1_panel_4";
            this.form1_panel_4.Size = new System.Drawing.Size(1, 403);
            this.form1_panel_4.TabIndex = 14;
            // 
            // form1_panel_6
            // 
            this.form1_panel_6.BackColor = System.Drawing.Color.GreenYellow;
            this.form1_panel_6.Location = new System.Drawing.Point(-3, 402);
            this.form1_panel_6.Name = "form1_panel_6";
            this.form1_panel_6.Size = new System.Drawing.Size(318, 1);
            this.form1_panel_6.TabIndex = 16;
            // 
            // form1_panel_5
            // 
            this.form1_panel_5.BackColor = System.Drawing.Color.GreenYellow;
            this.form1_panel_5.Location = new System.Drawing.Point(0, 0);
            this.form1_panel_5.Name = "form1_panel_5";
            this.form1_panel_5.Size = new System.Drawing.Size(1, 403);
            this.form1_panel_5.TabIndex = 17;
            // 
            // form1_linklabel
            // 
            this.form1_linklabel.AutoSize = true;
            this.form1_linklabel.Font = new System.Drawing.Font("Terminator Two", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form1_linklabel.LinkColor = System.Drawing.Color.Olive;
            this.form1_linklabel.Location = new System.Drawing.Point(59, 374);
            this.form1_linklabel.Name = "form1_linklabel";
            this.form1_linklabel.Size = new System.Drawing.Size(170, 13);
            this.form1_linklabel.TabIndex = 18;
            this.form1_linklabel.TabStop = true;
            this.form1_linklabel.Text = "Forgot Password";
            this.form1_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.form1_linklabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Terminator Two", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(25, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "STUDENT\r\n";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Olive;
            button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.CausesValidation = false;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button1.Location = new System.Drawing.Point(-3, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 30);
            button1.TabIndex = 53;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(313, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.form1_linklabel);
            this.Controls.Add(this.form1_panel_5);
            this.Controls.Add(this.form1_panel_6);
            this.Controls.Add(this.form1_panel_4);
            this.Controls.Add(this.form1_panel_3);
            this.Controls.Add(this.form1_button_sıngup);
            this.Controls.Add(this.form_button_logın);
            this.Controls.Add(this.form1_panel_2);
            this.Controls.Add(this.form1_panel_1);
            this.Controls.Add(this.form1_pictureBox_4);
            this.Controls.Add(this.form1_pictureBox_3);
            this.Controls.Add(this.form1_textBox_password);
            this.Controls.Add(this.form1_textbox_username);
            this.Controls.Add(this.form1_pictureBox_1);
            this.Controls.Add(this.form1_pictureBox_2);
            this.Controls.Add(this.form1_label_welcome);
            this.Controls.Add(this.form1_label_tıtle);
            this.Controls.Add(this.form1_button_close);
            this.Controls.Add(button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1_pictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1_pictureBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1_pictureBox_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1_pictureBox_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button form1_button_close;
        private System.Windows.Forms.Label form1_label_tıtle;
        private System.Windows.Forms.Label form1_label_welcome;
        private System.Windows.Forms.PictureBox form1_pictureBox_1;
        private System.Windows.Forms.PictureBox form1_pictureBox_2;
        private System.Windows.Forms.TextBox form1_textBox_password;
        private System.Windows.Forms.PictureBox form1_pictureBox_3;
        private System.Windows.Forms.PictureBox form1_pictureBox_4;
        private System.Windows.Forms.Panel form1_panel_1;
        private System.Windows.Forms.Panel form1_panel_2;
        private System.Windows.Forms.Button form_button_logın;
        private System.Windows.Forms.Button form1_button_sıngup;
        private System.Windows.Forms.Panel form1_panel_3;
        private System.Windows.Forms.Panel form1_panel_4;
        private System.Windows.Forms.Panel form1_panel_6;
        private System.Windows.Forms.Panel form1_panel_5;
        public System.Windows.Forms.TextBox form1_textbox_username;
        private System.Windows.Forms.LinkLabel form1_linklabel;
        private System.Windows.Forms.Label label5;
    }
}

