namespace StorageApp
{
    partial class ExitFormA
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
            this.exitYesButton = new System.Windows.Forms.Button();
            this.exitNoButton = new System.Windows.Forms.Button();
            this.exitCancelButton = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitYesButton
            // 
            this.exitYesButton.Location = new System.Drawing.Point(24, 94);
            this.exitYesButton.Name = "exitYesButton";
            this.exitYesButton.Size = new System.Drawing.Size(75, 23);
            this.exitYesButton.TabIndex = 0;
            this.exitYesButton.Text = "&Yes";
            this.exitYesButton.UseVisualStyleBackColor = true;
            this.exitYesButton.Click += new System.EventHandler(this.exitYesButton_Click);
            // 
            // exitNoButton
            // 
            this.exitNoButton.Location = new System.Drawing.Point(136, 94);
            this.exitNoButton.Name = "exitNoButton";
            this.exitNoButton.Size = new System.Drawing.Size(75, 23);
            this.exitNoButton.TabIndex = 1;
            this.exitNoButton.Text = "&No";
            this.exitNoButton.UseVisualStyleBackColor = true;
            this.exitNoButton.Click += new System.EventHandler(this.exitNoButton_Click);
            // 
            // exitCancelButton
            // 
            this.exitCancelButton.Location = new System.Drawing.Point(247, 94);
            this.exitCancelButton.Name = "exitCancelButton";
            this.exitCancelButton.Size = new System.Drawing.Size(75, 23);
            this.exitCancelButton.TabIndex = 2;
            this.exitCancelButton.Text = "&Cancel";
            this.exitCancelButton.UseVisualStyleBackColor = true;
            this.exitCancelButton.Click += new System.EventHandler(this.exitCancelButton_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Location = new System.Drawing.Point(21, 38);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(268, 13);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "Do you want to save the changes made before exiting?";
            // 
            // ExitFormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 162);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.exitCancelButton);
            this.Controls.Add(this.exitNoButton);
            this.Controls.Add(this.exitYesButton);
            this.Name = "ExitFormA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exitFormA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitYesButton;
        private System.Windows.Forms.Button exitNoButton;
        private System.Windows.Forms.Button exitCancelButton;
        private System.Windows.Forms.Label exitLabel;
    }
}