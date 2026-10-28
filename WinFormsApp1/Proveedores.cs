using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) // volver
        {
            this.Hide();
            MenuInicio frm = new MenuInicio();
            frm.ShowDialog();
            this.Show();
        }
    }
}
