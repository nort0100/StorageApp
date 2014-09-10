namespace StorageApp
{
    partial class mainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalsButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.smokedTab = new System.Windows.Forms.TabPage();
            this.giftedTab = new System.Windows.Forms.TabPage();
            this.onOrderTab = new System.Windows.Forms.TabPage();
            this.wishTab = new System.Windows.Forms.TabPage();
            this.graphTab = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smokedImageBox = new System.Windows.Forms.PictureBox();
            this.smokedTextBox = new System.Windows.Forms.TextBox();
            this.giftImageBox = new System.Windows.Forms.PictureBox();
            this.giftedTextBox = new System.Windows.Forms.TextBox();
            this.orderImageBox = new System.Windows.Forms.PictureBox();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.wishTextBox = new System.Windows.Forms.TextBox();
            this.wishImageBox = new System.Windows.Forms.PictureBox();
            this.smokedExitButton = new System.Windows.Forms.Button();
            this.giftExitButton = new System.Windows.Forms.Button();
            this.orderExitButton = new System.Windows.Forms.Button();
            this.wishExitButton = new System.Windows.Forms.Button();
            this.graphExitButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.smokedTab.SuspendLayout();
            this.giftedTab.SuspendLayout();
            this.onOrderTab.SuspendLayout();
            this.wishTab.SuspendLayout();
            this.graphTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smokedImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.smokedTab);
            this.tabControl1.Controls.Add(this.giftedTab);
            this.tabControl1.Controls.Add(this.onOrderTab);
            this.tabControl1.Controls.Add(this.wishTab);
            this.tabControl1.Controls.Add(this.graphTab);
            this.tabControl1.Location = new System.Drawing.Point(-3, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.exitButton);
            this.mainTab.Controls.Add(this.totalsButton);
            this.mainTab.Controls.Add(this.deleteButton);
            this.mainTab.Controls.Add(this.modifyButton);
            this.mainTab.Controls.Add(this.addButton);
            this.mainTab.Controls.Add(this.descriptionTextBox);
            this.mainTab.Controls.Add(this.imageBox);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(782, 468);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(597, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalsButton
            // 
            this.totalsButton.Location = new System.Drawing.Point(421, 392);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(75, 23);
            this.totalsButton.TabIndex = 5;
            this.totalsButton.Text = "&Totals";
            this.totalsButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(295, 393);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(179, 393);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "&Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(54, 394);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(588, 213);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(160, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(588, 28);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(160, 120);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // smokedTab
            // 
            this.smokedTab.Controls.Add(this.smokedExitButton);
            this.smokedTab.Controls.Add(this.smokedTextBox);
            this.smokedTab.Controls.Add(this.smokedImageBox);
            this.smokedTab.Location = new System.Drawing.Point(4, 22);
            this.smokedTab.Name = "smokedTab";
            this.smokedTab.Padding = new System.Windows.Forms.Padding(3);
            this.smokedTab.Size = new System.Drawing.Size(782, 468);
            this.smokedTab.TabIndex = 1;
            this.smokedTab.Text = "Smoked";
            this.smokedTab.UseVisualStyleBackColor = true;
            // 
            // giftedTab
            // 
            this.giftedTab.Controls.Add(this.giftExitButton);
            this.giftedTab.Controls.Add(this.giftedTextBox);
            this.giftedTab.Controls.Add(this.giftImageBox);
            this.giftedTab.Location = new System.Drawing.Point(4, 22);
            this.giftedTab.Name = "giftedTab";
            this.giftedTab.Size = new System.Drawing.Size(782, 468);
            this.giftedTab.TabIndex = 2;
            this.giftedTab.Text = "Gifted";
            this.giftedTab.UseVisualStyleBackColor = true;
            // 
            // onOrderTab
            // 
            this.onOrderTab.Controls.Add(this.orderExitButton);
            this.onOrderTab.Controls.Add(this.orderTextBox);
            this.onOrderTab.Controls.Add(this.orderImageBox);
            this.onOrderTab.Location = new System.Drawing.Point(4, 22);
            this.onOrderTab.Name = "onOrderTab";
            this.onOrderTab.Size = new System.Drawing.Size(782, 468);
            this.onOrderTab.TabIndex = 3;
            this.onOrderTab.Text = "On Order";
            this.onOrderTab.UseVisualStyleBackColor = true;
            // 
            // wishTab
            // 
            this.wishTab.Controls.Add(this.wishExitButton);
            this.wishTab.Controls.Add(this.wishImageBox);
            this.wishTab.Controls.Add(this.wishTextBox);
            this.wishTab.Location = new System.Drawing.Point(4, 22);
            this.wishTab.Name = "wishTab";
            this.wishTab.Size = new System.Drawing.Size(782, 468);
            this.wishTab.TabIndex = 4;
            this.wishTab.Text = "Wishlist";
            this.wishTab.UseVisualStyleBackColor = true;
            // 
            // graphTab
            // 
            this.graphTab.Controls.Add(this.graphExitButton);
            this.graphTab.Location = new System.Drawing.Point(4, 22);
            this.graphTab.Name = "graphTab";
            this.graphTab.Size = new System.Drawing.Size(782, 468);
            this.graphTab.TabIndex = 5;
            this.graphTab.Text = "Graphs";
            this.graphTab.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.tableToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.eXitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // eXitToolStripMenuItem
            // 
            this.eXitToolStripMenuItem.Name = "eXitToolStripMenuItem";
            this.eXitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eXitToolStripMenuItem.Text = "E&xit";
            this.eXitToolStripMenuItem.Click += new System.EventHandler(this.eXitToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.propertiesToolStripMenuItem.Text = "&Properties";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnsToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tableToolStripMenuItem.Text = "Tab&le";
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.columnsToolStripMenuItem.Text = "&Columns";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "A&bout";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hToolStripMenuItem.Text = "&Help";
            // 
            // smokedImageBox
            // 
            this.smokedImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smokedImageBox.Location = new System.Drawing.Point(588, 28);
            this.smokedImageBox.Name = "smokedImageBox";
            this.smokedImageBox.Size = new System.Drawing.Size(160, 120);
            this.smokedImageBox.TabIndex = 0;
            this.smokedImageBox.TabStop = false;
            // 
            // smokedTextBox
            // 
            this.smokedTextBox.Location = new System.Drawing.Point(588, 213);
            this.smokedTextBox.Name = "smokedTextBox";
            this.smokedTextBox.Size = new System.Drawing.Size(160, 20);
            this.smokedTextBox.TabIndex = 1;
            // 
            // giftImageBox
            // 
            this.giftImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.giftImageBox.Location = new System.Drawing.Point(588, 28);
            this.giftImageBox.Name = "giftImageBox";
            this.giftImageBox.Size = new System.Drawing.Size(160, 120);
            this.giftImageBox.TabIndex = 1;
            this.giftImageBox.TabStop = false;
            // 
            // giftedTextBox
            // 
            this.giftedTextBox.Location = new System.Drawing.Point(588, 213);
            this.giftedTextBox.Name = "giftedTextBox";
            this.giftedTextBox.Size = new System.Drawing.Size(160, 20);
            this.giftedTextBox.TabIndex = 2;
            // 
            // orderImageBox
            // 
            this.orderImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderImageBox.Location = new System.Drawing.Point(588, 28);
            this.orderImageBox.Name = "orderImageBox";
            this.orderImageBox.Size = new System.Drawing.Size(160, 120);
            this.orderImageBox.TabIndex = 2;
            this.orderImageBox.TabStop = false;
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(588, 213);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(160, 20);
            this.orderTextBox.TabIndex = 3;
            // 
            // wishTextBox
            // 
            this.wishTextBox.Location = new System.Drawing.Point(588, 213);
            this.wishTextBox.Name = "wishTextBox";
            this.wishTextBox.Size = new System.Drawing.Size(160, 20);
            this.wishTextBox.TabIndex = 3;
            // 
            // wishImageBox
            // 
            this.wishImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wishImageBox.Location = new System.Drawing.Point(588, 28);
            this.wishImageBox.Name = "wishImageBox";
            this.wishImageBox.Size = new System.Drawing.Size(160, 120);
            this.wishImageBox.TabIndex = 4;
            this.wishImageBox.TabStop = false;
            // 
            // smokedExitButton
            // 
            this.smokedExitButton.Location = new System.Drawing.Point(597, 393);
            this.smokedExitButton.Name = "smokedExitButton";
            this.smokedExitButton.Size = new System.Drawing.Size(75, 23);
            this.smokedExitButton.TabIndex = 7;
            this.smokedExitButton.Text = "E&xit";
            this.smokedExitButton.UseVisualStyleBackColor = true;
            this.smokedExitButton.Click += new System.EventHandler(this.smokedExitButton_Click);
            // 
            // giftExitButton
            // 
            this.giftExitButton.Location = new System.Drawing.Point(597, 393);
            this.giftExitButton.Name = "giftExitButton";
            this.giftExitButton.Size = new System.Drawing.Size(75, 23);
            this.giftExitButton.TabIndex = 7;
            this.giftExitButton.Text = "E&xit";
            this.giftExitButton.UseVisualStyleBackColor = true;
            this.giftExitButton.Click += new System.EventHandler(this.giftExitButton_Click);
            // 
            // orderExitButton
            // 
            this.orderExitButton.Location = new System.Drawing.Point(597, 393);
            this.orderExitButton.Name = "orderExitButton";
            this.orderExitButton.Size = new System.Drawing.Size(75, 23);
            this.orderExitButton.TabIndex = 7;
            this.orderExitButton.Text = "E&xit";
            this.orderExitButton.UseVisualStyleBackColor = true;
            this.orderExitButton.Click += new System.EventHandler(this.orderExitButton_Click);
            // 
            // wishExitButton
            // 
            this.wishExitButton.Location = new System.Drawing.Point(597, 393);
            this.wishExitButton.Name = "wishExitButton";
            this.wishExitButton.Size = new System.Drawing.Size(75, 23);
            this.wishExitButton.TabIndex = 7;
            this.wishExitButton.Text = "E&xit";
            this.wishExitButton.UseVisualStyleBackColor = true;
            this.wishExitButton.Click += new System.EventHandler(this.wishExitButton_Click);
            // 
            // graphExitButton
            // 
            this.graphExitButton.Location = new System.Drawing.Point(597, 393);
            this.graphExitButton.Name = "graphExitButton";
            this.graphExitButton.Size = new System.Drawing.Size(75, 23);
            this.graphExitButton.TabIndex = 7;
            this.graphExitButton.Text = "E&xit";
            this.graphExitButton.UseVisualStyleBackColor = true;
            this.graphExitButton.Click += new System.EventHandler(this.graphExitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(785, 516);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Cigar Storage App v0.1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.smokedTab.ResumeLayout(false);
            this.smokedTab.PerformLayout();
            this.giftedTab.ResumeLayout(false);
            this.giftedTab.PerformLayout();
            this.onOrderTab.ResumeLayout(false);
            this.onOrderTab.PerformLayout();
            this.wishTab.ResumeLayout(false);
            this.wishTab.PerformLayout();
            this.graphTab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smokedImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage smokedTab;
        private System.Windows.Forms.TabPage giftedTab;
        private System.Windows.Forms.TabPage onOrderTab;
        private System.Windows.Forms.TabPage wishTab;
        private System.Windows.Forms.TabPage graphTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXitToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.PictureBox smokedImageBox;
        private System.Windows.Forms.TextBox smokedTextBox;
        private System.Windows.Forms.PictureBox giftImageBox;
        private System.Windows.Forms.TextBox giftedTextBox;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.PictureBox orderImageBox;
        private System.Windows.Forms.PictureBox wishImageBox;
        private System.Windows.Forms.TextBox wishTextBox;
        private System.Windows.Forms.Button smokedExitButton;
        private System.Windows.Forms.Button giftExitButton;
        private System.Windows.Forms.Button orderExitButton;
        private System.Windows.Forms.Button wishExitButton;
        private System.Windows.Forms.Button graphExitButton;
    }
}

