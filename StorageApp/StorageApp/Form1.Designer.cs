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
            this.smokedTab = new System.Windows.Forms.TabPage();
            this.giftedTab = new System.Windows.Forms.TabPage();
            this.onOrderTab = new System.Windows.Forms.TabPage();
            this.wishTab = new System.Windows.Forms.TabPage();
            this.graphTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(782, 493);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // smokedTab
            // 
            this.smokedTab.Location = new System.Drawing.Point(4, 22);
            this.smokedTab.Name = "smokedTab";
            this.smokedTab.Padding = new System.Windows.Forms.Padding(3);
            this.smokedTab.Size = new System.Drawing.Size(782, 493);
            this.smokedTab.TabIndex = 1;
            this.smokedTab.Text = "Smoked";
            this.smokedTab.UseVisualStyleBackColor = true;
            // 
            // giftedTab
            // 
            this.giftedTab.Location = new System.Drawing.Point(4, 22);
            this.giftedTab.Name = "giftedTab";
            this.giftedTab.Size = new System.Drawing.Size(782, 493);
            this.giftedTab.TabIndex = 2;
            this.giftedTab.Text = "Gifted";
            this.giftedTab.UseVisualStyleBackColor = true;
            // 
            // onOrderTab
            // 
            this.onOrderTab.Location = new System.Drawing.Point(4, 22);
            this.onOrderTab.Name = "onOrderTab";
            this.onOrderTab.Size = new System.Drawing.Size(782, 493);
            this.onOrderTab.TabIndex = 3;
            this.onOrderTab.Text = "On Order";
            this.onOrderTab.UseVisualStyleBackColor = true;
            // 
            // wishTab
            // 
            this.wishTab.Location = new System.Drawing.Point(4, 22);
            this.wishTab.Name = "wishTab";
            this.wishTab.Size = new System.Drawing.Size(782, 493);
            this.wishTab.TabIndex = 4;
            this.wishTab.Text = "Wishlist";
            this.wishTab.UseVisualStyleBackColor = true;
            // 
            // graphTab
            // 
            this.graphTab.Location = new System.Drawing.Point(4, 22);
            this.graphTab.Name = "graphTab";
            this.graphTab.Size = new System.Drawing.Size(782, 493);
            this.graphTab.TabIndex = 5;
            this.graphTab.Text = "Graphs";
            this.graphTab.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 516);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Name = "mainForm";
            this.Text = "Cigar Storage App v0.1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage smokedTab;
        private System.Windows.Forms.TabPage giftedTab;
        private System.Windows.Forms.TabPage onOrderTab;
        private System.Windows.Forms.TabPage wishTab;
        private System.Windows.Forms.TabPage graphTab;
    }
}

