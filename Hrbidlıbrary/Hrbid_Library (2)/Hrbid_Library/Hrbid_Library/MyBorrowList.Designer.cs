namespace Hrbid_Library
{
    partial class MyBorrowList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBorrowList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MYBORROW_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.my_list_button_time = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYBORROW_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 163);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Terminator Two", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(186, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "MY BORROW\r\nLIST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MYBORROW_dataGridView1
            // 
            this.MYBORROW_dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MYBORROW_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MYBORROW_dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.MYBORROW_dataGridView1.Name = "MYBORROW_dataGridView1";
            this.MYBORROW_dataGridView1.RowHeadersWidth = 51;
            this.MYBORROW_dataGridView1.RowTemplate.Height = 24;
            this.MYBORROW_dataGridView1.Size = new System.Drawing.Size(456, 308);
            this.MYBORROW_dataGridView1.TabIndex = 1;
            this.MYBORROW_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MYBORROW_dataGridView1_CellContentClick);
            // 
            // my_list_button_time
            // 
            this.my_list_button_time.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.my_list_button_time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.my_list_button_time.Font = new System.Drawing.Font("Terminator Two", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.my_list_button_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.my_list_button_time.Location = new System.Drawing.Point(12, 494);
            this.my_list_button_time.Name = "my_list_button_time";
            this.my_list_button_time.Size = new System.Drawing.Size(456, 80);
            this.my_list_button_time.TabIndex = 3;
            this.my_list_button_time.Text = "EXTEND THE\r\nBORROWING TIME\r\n";
            this.my_list_button_time.UseVisualStyleBackColor = false;
            this.my_list_button_time.Click += new System.EventHandler(this.my_list_button_time_Click);
            // 
            // MyBorrowList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(478, 584);
            this.Controls.Add(this.my_list_button_time);
            this.Controls.Add(this.MYBORROW_dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBorrowList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBorrowList";
            this.Load += new System.EventHandler(this.MyBorrowList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYBORROW_dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MYBORROW_dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button my_list_button_time;
    }
}