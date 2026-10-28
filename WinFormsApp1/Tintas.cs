using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Tintas : Form
    {
        public Tintas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuInicio frm = new MenuInicio();
            frm.ShowDialog();

            this.Show();
        }
    }
}
