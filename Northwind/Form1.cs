using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic.ApplicationServices;

namespace Northwind
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> users = new Dictionary<string, string>()
        {
            { "Davalio", "200216" },
            { "Fuller", "Escuelas123" },
            {"Leverling", "Seguridad!"  }
        };
        string connectionString = @"Data Source=DESKTOP-FT33RAV;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=true;";


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                    // No es necesario cerrar la conexión aquí, ya que se cerrará automáticamente al salir del método.
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo establecer la conexión con la base de datos. Verifica la cadena de conexión y la disponibilidad del servidor.");
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;

            if (users.ContainsKey(user) && users[user] == password)
            {
                MessageBox.Show("Inicio de sesion correcta");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}