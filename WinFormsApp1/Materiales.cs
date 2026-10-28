using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Materiales : Form
    {
        public Materiales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //nombre
        {

        }

        private void button5_Click(object sender, EventArgs e) // volver
        {
            this.Hide();
            MenuInicio frm = new MenuInicio();
            frm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e) //tintas
        {
            this.Hide();
            Tintas frm = new Tintas();
            frm.ShowDialog();
            this.Show();
        }
    }
}
