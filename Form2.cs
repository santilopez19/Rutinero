using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rutinero
{
    public partial class Form2 : Form
    {
        private string archivoEjercicios = "ejercicios.txt";
        private string archivoRutina = "rutina.txt";
        public Form2()
        {
            InitializeComponent();

            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            archivoRutina = Path.Combine(escritorio, "rutina.txt");

            dgvRutina.Columns.Add("Codigo", "Código");
            dgvRutina.Columns.Add("Nombre", "Nombre");

            Ejercicios.Columns.Add("Codigo", "Código");
            Ejercicios.Columns.Add("Nombre", "Nombre");
            Ejercicios.Columns.Add("Descripcion", "Descripción");

            CargarEjerciciosEnComboBox();
            CargarEjerciciosEnGrilla(); 

            dgvRutina.AllowUserToAddRows = false; // Evitar filas vacías
            Ejercicios.AllowUserToAddRows = false;
        }
        private void CargarEjerciciosEnGrilla()
        {
            // Limpiar la grilla
            Ejercicios.Rows.Clear();

            // Cargar ejercicios desde el archivo
            if (File.Exists(archivoEjercicios))
            {
                var lineas = File.ReadAllLines(archivoEjercicios);
                foreach (var linea in lineas)
                {
                    string[] datos = linea.Split('|');
                    if (datos.Length == 3)
                    {
                        Ejercicios.Rows.Add(datos[0], datos[1], datos[2]);
                    }
                }
            }
        }
        private void CargarEjerciciosEnComboBox()
        {
            // Limpiar los ComboBox
            cmbCodigo.Items.Clear();
            cmbNombre.Items.Clear();

            // Cargar ejercicios desde el archivo
            if (File.Exists(archivoEjercicios))
            {
                var lineas = File.ReadAllLines(archivoEjercicios);
                foreach (var linea in lineas)
                {
                    string[] datos = linea.Split('|');
                    if (datos.Length == 3)
                    {
                        cmbCodigo.Items.Add(datos[0]); // Código
                        cmbNombre.Items.Add(datos[1]); // Nombre
                    }
                }
            }
        }

        private void Ejercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRutina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                cmbNombre.SelectedIndex = cmbCodigo.SelectedIndex;
            }
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {

            // Verificar que haya ejercicios en la rutina
            if (dgvRutina.Rows.Count == 0)
            {
                MessageBox.Show("No hay ejercicios en la rutina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el archivo de la rutina en el escritorio
            using (StreamWriter writer = new StreamWriter(archivoRutina))
            {
                writer.WriteLine("Rutina de ejercicios:");
                foreach (DataGridViewRow row in dgvRutina.Rows)
                {
                    writer.WriteLine($"{row.Cells[0].Value} - {row.Cells[1].Value}");
                }
            }

            MessageBox.Show($"Rutina guardada en: {archivoRutina}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Quitar_Click(object sender, EventArgs e)
        {

            // Verificar si hay una fila seleccionada en la grilla de la rutina
            if (dgvRutina.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un ejercicio para quitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Eliminar la fila seleccionada
            foreach (DataGridViewRow row in dgvRutina.SelectedRows)
            {
                dgvRutina.Rows.Remove(row);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

            // Verificar que se haya seleccionado un ejercicio
            if (cmbNombre.SelectedIndex == -1 || cmbCodigo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un ejercicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el código y nombre del ejercicio seleccionado
            string codigo = cmbCodigo.SelectedItem.ToString();
            string nombre = cmbNombre.SelectedItem.ToString();

            // Agregar el ejercicio a la grilla de la rutina
            dgvRutina.Rows.Add(codigo, nombre);

            // Limpiar la selección del ComboBox
            cmbCodigo.SelectedIndex = -1;
            cmbNombre.SelectedIndex = -1;
        }

        private void crearEjercicios_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog(); 
            CargarEjerciciosEnComboBox();
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombre.SelectedIndex != -1)
            {
                cmbCodigo.SelectedIndex = cmbNombre.SelectedIndex;
            }
        }
    }
}
