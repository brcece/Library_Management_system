namespace Hrbid_Library
{
    partial class DashboardM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardM));
            this.dashborad_menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAcountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsAndLibrariansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librariansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dashborad_menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashborad_menuStrip2
            // 
            this.dashborad_menuStrip2.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.dashborad_menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dashborad_menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashborad_menuStrip2.GripMargin = new System.Windows.Forms.Padding(5, 200, 5, 50);
            this.dashborad_menuStrip2.ImageScalingSize = new System.Drawing.Size(90, 90);
            this.dashborad_menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.borrowBookToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.dashborad_menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.dashborad_menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.dashborad_menuStrip2.Name = "dashborad_menuStrip2";
            this.dashborad_menuStrip2.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.dashborad_menuStrip2.ShowItemToolTips = true;
            this.dashborad_menuStrip2.Size = new System.Drawing.Size(208, 872);
            this.dashborad_menuStrip2.TabIndex = 9;
            this.dashborad_menuStrip2.Text = "menuStrip2";
            this.dashborad_menuStrip2.UseWaitCursor = true;
            this.dashborad_menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dashborad_menuStrip2_ItemClicked);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.booksToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDBOOKToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.searchBooksToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Terminator Two", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.booksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.booksToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(187, 94);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // aDDBOOKToolStripMenuItem
            // 
            this.aDDBOOKToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDDBOOKToolStripMenuItem.Image")));
            this.aDDBOOKToolStripMenuItem.Name = "aDDBOOKToolStripMenuItem";
            this.aDDBOOKToolStripMenuItem.Size = new System.Drawing.Size(294, 96);
            this.aDDBOOKToolStripMenuItem.Text = "ADD BOOK";
            this.aDDBOOKToolStripMenuItem.Click += new System.EventHandler(this.aDDBOOKToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editBookToolStripMenuItem.Image")));
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(294, 96);
            this.editBookToolStripMenuItem.Text = "edit book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // searchBooksToolStripMenuItem
            // 
            this.searchBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchBooksToolStripMenuItem.Image")));
            this.searchBooksToolStripMenuItem.Name = "searchBooksToolStripMenuItem";
            this.searchBooksToolStripMenuItem.Size = new System.Drawing.Size(294, 96);
            this.searchBooksToolStripMenuItem.Text = "Search Book";
            this.searchBooksToolStripMenuItem.Click += new System.EventHandler(this.searchBooksToolStripMenuItem_Click);
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.borrowBookToolStripMenuItem.Font = new System.Drawing.Font("Terminator Two", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borrowBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrowBookToolStripMenuItem.Image")));
            this.borrowBookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Size = new System.Drawing.Size(187, 94);
            this.borrowBookToolStripMenuItem.Text = " Stock";
            this.borrowBookToolStripMenuItem.Click += new System.EventHandler(this.borrowBookToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAcountToolStripMenuItem,
            this.studentsAndLibrariansToolStripMenuItem,
            this.librariansToolStripMenuItem});
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Terminator Two", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.accountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountToolStripMenuItem.Image")));
            this.accountToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(187, 94);
            this.accountToolStripMenuItem.Text = "Users";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // myAcountToolStripMenuItem
            // 
            this.myAcountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("myAcountToolStripMenuItem.Image")));
            this.myAcountToolStripMenuItem.Name = "myAcountToolStripMenuItem";
            this.myAcountToolStripMenuItem.Size = new System.Drawing.Size(294, 96);
            this.myAcountToolStripMenuItem.Text = "My Acount";
            this.myAcountToolStripMenuItem.Click += new System.EventHandler(this.myAcountToolStripMenuItem_Click);
            // 
            // studentsAndLibrariansToolStripMenuItem
            // 
            this.studentsAndLibrariansToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsAndLibrariansToolStripMenuItem.Image")));
            this.studentsAndLibrariansToolStripMenuItem.Name = "studentsAndLibrariansToolStripMenuItem";
            this.studentsAndLibrariansToolStripMenuItem.Size = new System.Drawing.Size(294, 96);
            this.studentsAndLibrariansToolStripMenuItem.Text = "students ";
            this.studentsAndLibrariansToolStripMenuItem.Click += new System.EventHandler(this.studentsAndLibrariansToolStripMenuItem_Click);
            // 
            // librariansToolStripMenuItem
            // 
            this.librariansToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("librariansToolStripMenuItem.Image")));
            this.librariansToolStripMenuItem.Name = "librariansToolStripMenuItem";
            this.librariansToolStripMenuItem.Size = new System.Drawing.Size(294, 96);
            this.librariansToolStripMenuItem.Text = "librarians";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Olive;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Terminator Two", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 94);
            this.toolStripMenuItem1.Text = "history";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.exitToolStripMenuItem.CheckOnClick = true;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Terminator Two", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.exitToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 94);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Location = new System.Drawing.Point(441, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 619);
            this.panel1.TabIndex = 14;
            this.panel1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Terminator Two", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(464, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 560);
            this.label2.TabIndex = 13;
            this.label2.Text = "L\r\ni\r\nb\r\nr\r\na\r\nr\r\ny";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Terminator Two", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(340, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 480);
            this.label1.TabIndex = 12;
            this.label1.Text = "h\r\nr\r\nb\r\ni\r\nd\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(88, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Manager";
            this.label5.UseWaitCursor = true;
            // 
            // DashboardM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 872);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashborad_menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardM";
            this.dashborad_menuStrip2.ResumeLayout(false);
            this.dashborad_menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dashborad_menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem aDDBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem myAcountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsAndLibrariansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librariansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}