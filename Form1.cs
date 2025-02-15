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
    public partial class Form1 : Form
    {
        private string archivoEjercicios = "ejercicios.txt";
        public Form1()
        {
            InitializeComponent();

            GrillaEjercicios.Columns.Add("Codigo", "Código");
            GrillaEjercicios.Columns.Add("Nombre", "Nombre");
            GrillaEjercicios.Columns.Add("Descripcion", "Descripción");
            CargarEjerciciosEnGrilla();
        }
        private void CargarEjerciciosEnGrilla()
        {
            // Limpiar la grilla
            GrillaEjercicios.Rows.Clear();

            // Cargar ejercicios desde el archivo
            if (File.Exists(archivoEjercicios))
            {
                var lineas = File.ReadAllLines(archivoEjercicios);
                foreach (var linea in lineas)
                {
                    string[] datos = linea.Split('|');
                    if (datos.Length == 3)
                    {
                        // Agregar una fila con los datos del ejercicio
                        GrillaEjercicios.Rows.Add(datos[0], datos[1], datos[2]);
                    }
                }
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Crear_Click(object sender, EventArgs e)
        {

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Autogenerar el código
            int nuevoCodigo = ObtenerSiguienteCodigo();
            txtCodigo.Text = nuevoCodigo.ToString();

            // Guardar el ejercicio en el archivo
            using (StreamWriter writer = File.AppendText(archivoEjercicios))
            {
                writer.WriteLine($"{nuevoCodigo}|{txtNombre.Text}|{txtDescripcion.Text}");
            }

            // Actualizar la grilla
            CargarEjerciciosEnGrilla();

            // Limpiar los campos
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCodigo.Clear();

            MessageBox.Show("Ejercicio creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ObtenerSiguienteCodigo()
        {
            if (!File.Exists(archivoEjercicios))
            {
                return 1; // Si el archivo no existe, empezar con el código 1
            }

            var lineas = File.ReadAllLines(archivoEjercicios);
            if (lineas.Length == 0)
            {
                return 1;
            }

            // Obtener el último código y sumarle 1
            var ultimaLinea = lineas.Last();
            string[] datos = ultimaLinea.Split('|');
            if (datos.Length > 0 && int.TryParse(datos[0], out int ultimoCodigo))
            {
                return ultimoCodigo + 1;
            }

            return 1; // Si no se puede obtener el último código, empezar con 1
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {

            // Verificar si hay una fila seleccionada en la grilla
            if (GrillaEjercicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un ejercicio para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el código del ejercicio seleccionado
            var codigo = GrillaEjercicios.SelectedRows[0].Cells[0].Value.ToString();

            // Leer todos los ejercicios y excluir el seleccionado
            var lineas = File.ReadAllLines(archivoEjercicios);
            var nuevasLineas = lineas.Where(linea => !linea.StartsWith(codigo + "|")).ToArray();

            // Sobrescribir el archivo con los ejercicios restantes
            File.WriteAllLines(archivoEjercicios, nuevasLineas);

            // Actualizar la grilla
            CargarEjerciciosEnGrilla();

            MessageBox.Show("Ejercicio eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GrillaEjercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // Verificar que se haya hecho clic en una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow fila = GrillaEjercicios.Rows[e.RowIndex];

                // Cargar los datos en los TextBox
                txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            // Verificar que se haya seleccionado una fila en la grilla
            if (GrillaEjercicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un ejercicio para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow fila = GrillaEjercicios.SelectedRows[0];

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar la fila seleccionada con los nuevos datos
            fila.Cells["Nombre"].Value = txtNombre.Text;
            fila.Cells["Descripcion"].Value = txtDescripcion.Text;

            // Guardar los cambios en el archivo
            GuardarEjerciciosEnArchivo();

            MessageBox.Show("Ejercicio modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void GuardarEjerciciosEnArchivo()
        {
            // Crear una lista para almacenar los ejercicios
            List<string> ejercicios = new List<string>();

            // Recorrer las filas de la grilla
            foreach (DataGridViewRow fila in GrillaEjercicios.Rows)
            {
                if (!fila.IsNewRow) // Ignorar la fila vacía al final
                {
                    string codigo = fila.Cells["Codigo"].Value.ToString();
                    string nombre = fila.Cells["Nombre"].Value.ToString();
                    string descripcion = fila.Cells["Descripcion"].Value.ToString();

                    // Agregar el ejercicio a la lista
                    ejercicios.Add($"{codigo}|{nombre}|{descripcion}");
                }
            }

            // Guardar la lista en el archivo
            File.WriteAllLines(archivoEjercicios, ejercicios);
        }
    }
}
