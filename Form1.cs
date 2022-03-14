using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmirhanApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter tuşu çalışıyor.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esc tuşu çalışıyor.");
        }

        private void btnControlBox_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)
                this.ControlBox = false;
            else
                this.ControlBox = true;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form2 formB = new Form2();
            formB.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
        Form2 formB = new Form2();
        formB.ShowDialog();
        }
    }
}
    

