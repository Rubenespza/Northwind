using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=DESKTOP-FT33RAV;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=true;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable DataTable;

        public Form3()
        {
            InitializeComponent();
            //Inicializar la conexion y el adaptador
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("SELECT CategoryID FROM Categories", connection);
            DataTable = new DataTable();
            adapter.Fill(DataTable);
            // Asignar los datos al Combobox
            comboBox1.DataSource = DataTable;
            comboBox1.DisplayMember = "CategoryID";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
        public static Bitmap ByteToImage(byte[] blob)
        {

            try
            {
                MemoryStream mStream = new MemoryStream();
                byte[] pData = blob;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            catch (Exception ex)
            {
                // Manejar la excepción (puedes mostrar un mensaje o registrar el error)
                MessageBox.Show("Error al convertir bytes a imagen: " + ex.Message);
                return null; // Otra opción es devolver null en caso de error
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // Obtener el CategoryID seleccionado
                if (comboBox1.SelectedItem is DataRowView selectedRowView)
                {
                    int CategoryID = Convert.ToInt32(selectedRowView.Row["CategoryID"]);
                    // Obtener los datos de la categoría seleccionada
                    string query = "SELECT CategoryName, Description, Picture FROM Categories WHERE CategoryID = @CategoryID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Text = reader["CategoryName"].ToString();
                        textBox2.Text = reader["Description"].ToString();
                        byte[] imageBytes = (byte[])reader["Picture"];
                        // Convertir los bytes a un objeto Bitmap (Image)
                        Bitmap categoryBitmap = ByteToImage(imageBytes);
                        if (categoryBitmap != null)
                        {
                            // Mostrar la imagen en el PictureBox
                            pictureBox1.Image = categoryBitmap;
                        }
                        else
                        {
                            // Manejar el caso de error (por ejemplo, mostrar un mensaje)
                            MessageBox.Show("Error al cargar la imagen.");
                        }



                        reader.Close();
                        connection.Close();
                    }
                }


            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            string categoryName = textBox1.Text;
            string description = textBox2.Text;


            MessageBox.Show("Categoria insertada correctamente");
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";


        }
    }
}
