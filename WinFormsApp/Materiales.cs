using ClasesInnovaStock.Models;
using ClasesInnovaStock.Repositories;
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
        private readonly IGenericRepository<Material> _repoMateriales;
        private int? materialIdSeleccionado = null;

        public Materiales()
        {
            InitializeComponent();
            _repoMateriales = new GenericRepository<Material>();
        }

        private void Materiales_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _repoMateriales.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la grilla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        // --- BOTÓN 1: AGREGAR ---
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Por favor, completa al menos el nombre y el precio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevoMaterial = new Material
                {
                    Nombre = textBox1.Text,                             // textBox1: Nombre
                    PrecioUnitario = decimal.Parse(textBox2.Text),      // textBox2: Precio
                    StockActual = decimal.Parse(textBox4.Text),         // textBox4: Stock
                    Color = "N/A",                                      // Propiedad Color por defecto
                    UnidadMedida = "unidades"                           // Evita error NOT NULL en la base de datos
                };

                _repoMateriales.Agregar(nuevoMaterial);
                MessageBox.Show("Material agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                string mensajeError = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error detallado: {mensajeError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- SELECCIONAR FILA DE LA GRILLA ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                materialIdSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

                textBox1.Text = fila.Cells["Nombre"].Value?.ToString();
                textBox2.Text = fila.Cells["PrecioUnitario"].Value?.ToString();
                textBox3.Clear(); // textBox3 (Costo visual) se limpia al seleccionar ya que no es una propiedad directa del modelo
                textBox4.Text = fila.Cells["StockActual"].Value?.ToString();
            }
        }

        // --- BOTÓN 2: MODIFICAR ---
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialIdSeleccionado == null)
                {
                    MessageBox.Show("Selecciona un material de la grilla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var materialAEditar = _repoMateriales.ObtenerPorId(materialIdSeleccionado.Value);
                if (materialAEditar != null)
                {
                    materialAEditar.Nombre = textBox1.Text;
                    materialAEditar.PrecioUnitario = decimal.Parse(textBox2.Text);
                    materialAEditar.StockActual = decimal.Parse(textBox4.Text);
                    materialAEditar.UnidadMedida = "unidades";

                    _repoMateriales.Modificar(materialAEditar);
                    MessageBox.Show("Material modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrilla();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error detallado: {mensajeError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- BOTÓN 3: QUITAR ---
        private void button3_Click(object sender, EventArgs e)
        {
            if (materialIdSeleccionado == null)
            {
                MessageBox.Show("Selecciona un material de la grilla para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Estás seguro de eliminar este material?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                _repoMateriales.Eliminar(materialIdSeleccionado.Value);
                MessageBox.Show("Material eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarCampos();
            }
        }

        // --- BOTÓN 4: TINTAS ---
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección de Tintas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- BOTÓN 5: MENÚ ---
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            materialIdSeleccionado = null;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}