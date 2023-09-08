namespace Hrbid_Library
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.borrow_panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.borrow_panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.borrow_textBox = new System.Windows.Forms.TextBox();
            this.return_button_borrow = new System.Windows.Forms.Button();
            this.CHECKSTUDENTbutton2 = new System.Windows.Forms.Button();
            this.studentID_textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.borrow_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.borrow_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // borrow_panel1
            // 
            this.borrow_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.borrow_panel1.Controls.Add(this.label2);
            this.borrow_panel1.Controls.Add(this.label1);
            this.borrow_panel1.Controls.Add(this.pictureBox1);
            this.borrow_panel1.Location = new System.Drawing.Point(12, 12);
            this.borrow_panel1.Name = "borrow_panel1";
            this.borrow_panel1.Size = new System.Drawing.Size(508, 154);
            this.borrow_panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Terminator Two", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(359, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "BOOK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Terminator Two", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(63, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "RETURN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(209, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // borrow_panel2
            // 
            this.borrow_panel2.BackColor = System.Drawing.Color.Olive;
            this.borrow_panel2.Controls.Add(this.label9);
            this.borrow_panel2.Controls.Add(this.button1);
            this.borrow_panel2.Controls.Add(this.studentID_textBox2);
            this.borrow_panel2.Controls.Add(this.CHECKSTUDENTbutton2);
            this.borrow_panel2.Controls.Add(this.dataGridView1);
            this.borrow_panel2.Controls.Add(this.label3);
            this.borrow_panel2.Controls.Add(this.borrow_textBox);
            this.borrow_panel2.Controls.Add(this.return_button_borrow);
            this.borrow_panel2.Location = new System.Drawing.Point(12, 185);
            this.borrow_panel2.Name = "borrow_panel2";
            this.borrow_panel2.Size = new System.Drawing.Size(508, 453);
            this.borrow_panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Terminator Two", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(276, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Borrow new book\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 148);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Terminator Two", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(196, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Book Name";
            // 
            // borrow_textBox
            // 
            this.borrow_textBox.Location = new System.Drawing.Point(113, 155);
            this.borrow_textBox.Name = "borrow_textBox";
            this.borrow_textBox.Size = new System.Drawing.Size(281, 22);
            this.borrow_textBox.TabIndex = 1;
            this.borrow_textBox.TextChanged += new System.EventHandler(this.borrow_textBox_TextChanged);
            // 
            // return_button_borrow
            // 
            this.return_button_borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.return_button_borrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.return_button_borrow.Font = new System.Drawing.Font("Terminator Two", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.return_button_borrow.ForeColor = System.Drawing.Color.Olive;
            this.return_button_borrow.Location = new System.Drawing.Point(27, 378);
            this.return_button_borrow.Name = "return_button_borrow";
            this.return_button_borrow.Size = new System.Drawing.Size(213, 54);
            this.return_button_borrow.TabIndex = 5;
            this.return_button_borrow.Text = "Return ";
            this.return_button_borrow.UseVisualStyleBackColor = false;
            this.return_button_borrow.Click += new System.EventHandler(this.return_button_borrow_Click);
            // 
            // CHECKSTUDENTbutton2
            // 
            this.CHECKSTUDENTbutton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CHECKSTUDENTbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CHECKSTUDENTbutton2.Font = new System.Drawing.Font("Terminator Two", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CHECKSTUDENTbutton2.ForeColor = System.Drawing.Color.Olive;
            this.CHECKSTUDENTbutton2.Location = new System.Drawing.Point(113, 87);
            this.CHECKSTUDENTbutton2.Name = "CHECKSTUDENTbutton2";
            this.CHECKSTUDENTbutton2.Size = new System.Drawing.Size(281, 35);
            this.CHECKSTUDENTbutton2.TabIndex = 2;
            this.CHECKSTUDENTbutton2.Text = "Check Student";
            this.CHECKSTUDENTbutton2.UseVisualStyleBackColor = false;
            this.CHECKSTUDENTbutton2.Click += new System.EventHandler(this.CHECKSTUDENTbutton2_Click);
            // 
            // studentID_textBox2
            // 
            this.studentID_textBox2.Location = new System.Drawing.Point(113, 48);
            this.studentID_textBox2.Name = "studentID_textBox2";
            this.studentID_textBox2.Size = new System.Drawing.Size(281, 22);
            this.studentID_textBox2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Terminator Two", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(195, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Student Info";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(530, 650);
            this.Controls.Add(this.borrow_panel2);
            this.Controls.Add(this.borrow_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.borrow_panel1.ResumeLayout(false);
            this.borrow_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.borrow_panel2.ResumeLayout(false);
            this.borrow_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel borrow_panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel borrow_panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button return_button_borrow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox borrow_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox studentID_textBox2;
        private System.Windows.Forms.Button CHECKSTUDENTbutton2;
    }
}