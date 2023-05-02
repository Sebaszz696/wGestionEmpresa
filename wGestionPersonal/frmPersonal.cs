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


namespace wGestionPersonal
{/// <summary>
/// Sebastian Velasquez, Mateo Becerra
/// 02/05/2023
/// Gestion personal de una empresa
/// </summary>
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }
        //MUESTRA LA FECHA ACTUAL
        private void Fecha_Tick(object sender, EventArgs e)
        {

            lblFecha.Text = DateTime.Now.ToString("dddd " + " d" + " MMMM " + " yyy");
        }

        //myStream es una variable privada de tipo Stream. Es utilizada para almacenar el flujo de datos de un archivo seleccionado
        private Stream myStream;
        int count = 0;
        string line;




        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtgCSV.Rows.Clear();
        }

        private void btnCSV_Click_1(object sender, EventArgs e)
        {

            //Se define una matrix llamada "result" que se usará para almacenar los datos leídos del archivo como cedula nombre etc.
            string[] result;

            // Crear un objeto OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Establecer el directorio inicial del diálogo en el directorio de la aplicación
            openFileDialog1.InitialDirectory = Application.StartupPath;

            // Establecer el filtro de archivo para mostrar solo archivos CSV
            openFileDialog1.Filter = "Archivos (*.csv) | *.csv";

            // Mostrar el cuadro de diálogo y cargar el archivo CSV seleccionado cuando se presiona ok
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //se intenta abrir el archivo seleccionado
                try
                {
                    //Si el archivo no está vacío leer los datos
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {

                        // Utilizar el objeto StreamReader para leer el archivo línea por línea
                        using (myStream)
                        {
                           
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);

                              // Leer cada línea del archivo
                            while ((line = file.ReadLine()) != null)
                            {
                                //Cada línea se divide en campos separados por punto y coma(";") y se almacena en result
                                result = line.Split(';');

                                //los valores de "result" se agregan a la tabla  utilizando el método "Add" 
                                dtgCSV.Rows.Add(result[0], result[1], result[2], result[3], result[4], result[5], result[6], result[7]);
                                //count++;
                            }
                            file.Close();
                        }
                    }
                }

                //Mensaje de error
                catch (Exception ex)
                {
                    MessageBox.Show("Mensaje de error" + ex.Message);
                }


            }
        }

        private void dtgCSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {

        }
    }
}
