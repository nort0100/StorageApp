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
    public partial class ExitFormA : Form
    {
        public ExitFormA()
        {
            InitializeComponent();
        }

        private void exitYesButton_Click(object sender, EventArgs e)
        {
            //save all current database updates etc.
        }

        private void exitNoButton_Click(object sender, EventArgs e)
        {
            //exit, don't save any changes
            Application.Exit();
        }

        private void exitCancelButton_Click(object sender, EventArgs e)
        {
            //leave form, return to previous form
            this.Close();
        }
    }
}
