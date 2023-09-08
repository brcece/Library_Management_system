namespace Hrbid_Library
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.borrow_panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.borrow_textBox = new System.Windows.Forms.TextBox();
            this.borrow_button_borrow = new System.Windows.Forms.Button();
            this.borrow_panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.borrow_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.borrow_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // borrow_panel2
            // 
            this.borrow_panel2.BackColor = System.Drawing.Color.Olive;
            this.borrow_panel2.Controls.Add(this.dataGridView1);
            this.borrow_panel2.Controls.Add(this.dateTimePicker2);
            this.borrow_panel2.Controls.Add(this.dateTimePicker1);
            this.borrow_panel2.Controls.Add(this.label5);
            this.borrow_panel2.Controls.Add(this.label4);
            this.borrow_panel2.Controls.Add(this.label3);
            this.borrow_panel2.Controls.Add(this.borrow_textBox);
            this.borrow_panel2.Controls.Add(this.borrow_button_borrow);
            this.borrow_panel2.Location = new System.Drawing.Point(12, 185);
            this.borrow_panel2.Name = "borrow_panel2";
            this.borrow_panel2.Size = new System.Drawing.Size(518, 453);
            this.borrow_panel2.TabIndex = 19;
            this.borrow_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.borrow_panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 96);
            this.dataGridView1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(327, 335);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Terminator Two", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(344, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "ENDED TIME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Terminator Two", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "STARTED TIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Terminator Two", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(214, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Book Name";
            // 
            // borrow_textBox
            // 
            this.borrow_textBox.Location = new System.Drawing.Point(134, 92);
            this.borrow_textBox.Name = "borrow_textBox";
            this.borrow_textBox.Size = new System.Drawing.Size(259, 22);
            this.borrow_textBox.TabIndex = 1;
            // 
            // borrow_button_borrow
            // 
            this.borrow_button_borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.borrow_button_borrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrow_button_borrow.Font = new System.Drawing.Font("Terminator Two", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borrow_button_borrow.ForeColor = System.Drawing.Color.Olive;
            this.borrow_button_borrow.Location = new System.Drawing.Point(27, 378);
            this.borrow_button_borrow.Name = "borrow_button_borrow";
            this.borrow_button_borrow.Size = new System.Drawing.Size(458, 54);
            this.borrow_button_borrow.TabIndex = 5;
            this.borrow_button_borrow.Text = "Borrow";
            this.borrow_button_borrow.UseVisualStyleBackColor = false;
            // 
            // borrow_panel1
            // 
            this.borrow_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.borrow_panel1.Controls.Add(this.label2);
            this.borrow_panel1.Controls.Add(this.label1);
            this.borrow_panel1.Controls.Add(this.pictureBox1);
            this.borrow_panel1.Location = new System.Drawing.Point(12, 12);
            this.borrow_panel1.Name = "borrow_panel1";
            this.borrow_panel1.Size = new System.Drawing.Size(518, 154);
            this.borrow_panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Terminator Two", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(342, 109);
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
            this.label1.Location = new System.Drawing.Point(246, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "BORROW";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(38, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(544, 795);
            this.Controls.Add(this.borrow_panel2);
            this.Controls.Add(this.borrow_panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.borrow_panel2.ResumeLayout(false);
            this.borrow_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.borrow_panel1.ResumeLayout(false);
            this.borrow_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel borrow_panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox borrow_textBox;
        private System.Windows.Forms.Button borrow_button_borrow;
        private System.Windows.Forms.Panel borrow_panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}