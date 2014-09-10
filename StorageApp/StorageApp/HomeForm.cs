using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StorageApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //new instance of about form
            AboutBox aboutForm = new AboutBox();
            //Display aboutform
            aboutForm.ShowDialog();
        }

        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exitFormClick();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //Load current Image from table/database into picture box
        }

        private void smokedExitButton_Click(object sender, EventArgs e)
        {
            exitFormClick();
        }

        private void giftExitButton_Click(object sender, EventArgs e)
        {
            exitFormClick();
        }

        private void orderExitButton_Click(object sender, EventArgs e)
        {
            exitFormClick();
        }

        private void wishExitButton_Click(object sender, EventArgs e)
        {
            exitFormClick();
        }

        private void graphExitButton_Click(object sender, EventArgs e)
        {
            exitFormClick();
        }

        //General Methods
        //Used to exit all forms
        private void exitFormClick()
        {
            //new instance of exit form
            ExitFormA exitForm = new ExitFormA();
            //Display aboutform
            exitForm.ShowDialog();
        }
    }
}
