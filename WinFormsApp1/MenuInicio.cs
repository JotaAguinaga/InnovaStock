using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Materiales frm = new Materiales();
            frm.ShowDialog();

            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Reportes frm = new Reportes();
            frm.ShowDialog();

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Proveedores frm = new Proveedores();
            frm.ShowDialog();

            this.Show();
        }
    }
}
