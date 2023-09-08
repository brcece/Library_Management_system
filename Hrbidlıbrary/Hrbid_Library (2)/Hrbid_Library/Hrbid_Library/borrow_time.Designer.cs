namespace Hrbid_Library
{
    partial class borrow_time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrow_time));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TIME_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.endtime_label = new System.Windows.Forms.Label();
            this.time_dateTimePickerended = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.time_textBox = new System.Windows.Forms.TextBox();
            this.time_button_change = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIME_dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 164);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Terminator Two", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(193, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "EXTEND THE\r\nBORROWING TIME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TIME_dataGridView1
            // 
            this.TIME_dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TIME_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TIME_dataGridView1.Location = new System.Drawing.Point(12, 333);
            this.TIME_dataGridView1.Name = "TIME_dataGridView1";
            this.TIME_dataGridView1.RowHeadersWidth = 51;
            this.TIME_dataGridView1.RowTemplate.Height = 24;
            this.TIME_dataGridView1.Size = new System.Drawing.Size(453, 238);
            this.TIME_dataGridView1.TabIndex = 1;
            this.TIME_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TIME_dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.endtime_label);
            this.panel2.Controls.Add(this.time_dateTimePickerended);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.time_textBox);
            this.panel2.Location = new System.Drawing.Point(12, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 145);
            this.panel2.TabIndex = 2;
            // 
            // endtime_label
            // 
            this.endtime_label.AutoSize = true;
            this.endtime_label.Font = new System.Drawing.Font("Terminator Two", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.endtime_label.Location = new System.Drawing.Point(50, 99);
            this.endtime_label.Name = "endtime_label";
            this.endtime_label.Size = new System.Drawing.Size(146, 18);
            this.endtime_label.TabIndex = 4;
            this.endtime_label.Text = "Ending Time";
            // 
            // time_dateTimePickerended
            // 
            this.time_dateTimePickerended.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_dateTimePickerended.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_dateTimePickerended.Location = new System.Drawing.Point(289, 96);
            this.time_dateTimePickerended.Name = "time_dateTimePickerended";
            this.time_dateTimePickerended.Size = new System.Drawing.Size(130, 22);
            this.time_dateTimePickerended.TabIndex = 3;
            this.time_dateTimePickerended.ValueChanged += new System.EventHandler(this.time_dateTimePickerended_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Terminator Two", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book\'s \r\nName";
            // 
            // time_textBox
            // 
            this.time_textBox.Location = new System.Drawing.Point(132, 29);
            this.time_textBox.Name = "time_textBox";
            this.time_textBox.Size = new System.Drawing.Size(287, 22);
            this.time_textBox.TabIndex = 0;
            this.time_textBox.TextChanged += new System.EventHandler(this.time_textBox_TextChanged);
            // 
            // time_button_change
            // 
            this.time_button_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.time_button_change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.time_button_change.Font = new System.Drawing.Font("Terminator Two", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time_button_change.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.time_button_change.Location = new System.Drawing.Point(12, 577);
            this.time_button_change.Name = "time_button_change";
            this.time_button_change.Size = new System.Drawing.Size(453, 61);
            this.time_button_change.TabIndex = 3;
            this.time_button_change.Text = "Change";
            this.time_button_change.UseVisualStyleBackColor = false;
            this.time_button_change.Click += new System.EventHandler(this.time_button_change_Click);
            // 
            // borrow_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(478, 650);
            this.Controls.Add(this.time_button_change);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TIME_dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "borrow_time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "borrow_time";
            this.Load += new System.EventHandler(this.borrow_time_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIME_dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TIME_dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox time_textBox;
        private System.Windows.Forms.DateTimePicker time_dateTimePickerended;
        private System.Windows.Forms.Button time_button_change;
        private System.Windows.Forms.Label endtime_label;
    }
}