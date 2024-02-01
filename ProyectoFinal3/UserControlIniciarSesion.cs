using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal3
{
    /// <summary>
    /// UserControl que representa la interfaz de inicio de sesión.
    /// </summary>
    public partial class UserControlIniciarSesion : UserControl
    {
        /// <summary>
        /// Evento que se dispara cuando se hace clic en el texto "¿No tengo cuenta?".
        /// </summary>
        public event EventHandler BotonNoTengoCuentaClickeado;

        /// <summary>
        /// Evento que se dispara cuando se hace clic en el botón "Iniciar Sesión".
        /// </summary>
        public event EventHandler BotonIniciarSesiónClickeado;

        /// <summary>
        /// Conector de la base de datos.
        /// </summary>
        public MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        /// <summary>
        /// Conexión a la base de datos.
        /// </summary>
        public MySqlConnection conn;

        /// <summary>
        /// Nombre de usuario introducido en el cuadro de texto.
        /// </summary>
        public string userNameLogIn { get; set; }

        /// <summary>
        /// Contraseña introducida en el cuadro de texto.
        /// </summary>
        public string userLogInPasswd { get; set; }

        /// <summary>
        /// Constructor de la clase UserControlIniciarSesion.
        /// </summary>
        public UserControlIniciarSesion()
        {
            InitializeComponent();
            initMySql();
        }

        /// <summary>
        /// Manejador de eventos para el clic en la etiqueta "No tengo cuenta".
        /// Invoca el evento BotonNoTengoCuentaClickeado.
        /// </summary>
        private void labelNoAccount_Click(object sender, EventArgs e)
        {
            BotonNoTengoCuentaClickeado?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Manejador de eventos para el clic en el botón "Iniciar Sesión".
        /// Realiza comprobaciones y, si son exitosas, invoca el evento BotonIniciarSesiónClickeado.
        /// </summary>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (camposCompletados() && existeUsuario() && comprobarPassword())
            {
                userNameLogIn = textBoxLogInPassword.Text;

                BotonIniciarSesiónClickeado?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Inicializa la conexión a la base de datos MySQL.
        /// </summary>
        private void initMySql()
        {
            // Configuración de la conexión a la base de datos
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "slamstats";

            conn = new MySqlConnection(builder.ToString());
        }

        /// <summary>
        /// Comprueba si el usuario introducido existe en la base de datos.
        /// </summary>
        /// <returns>True si el usuario existe, False si no.</returns>
        private bool existeUsuario()
        {
            bool existe = true;

            MySqlCommand cmd = conn.CreateCommand();

            cmd.Parameters.Add("@name", MySqlDbType.Text).Value = textBoxNameUserLogIn.Text;

            cmd.CommandText = "SELECT COUNT(*) FROM usuario WHERE NombreUsuario = @name";

            conn.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            if (count == 0)
            {
                labelNameUserLogIn.Text = "No existe un usuario con ese nombre";
                existe = false;
            }

            return existe;
        }

        /// <summary>
        /// Comprueba si la contraseña introducida coincide con la almacenada en la base de datos.
        /// </summary>
        /// <returns>True si la contraseña es correcta, False si no.</returns>
        private bool comprobarPassword()
        {
            bool existe = true;

            MySqlCommand cmd = conn.CreateCommand();

            cmd.Parameters.Add("@name", MySqlDbType.Text).Value = textBoxNameUserLogIn.Text;

            cmd.CommandText = "SELECT contrasena FROM usuario WHERE NombreUsuario = @name";

            conn.Open();

            string passwordAlmacenada = cmd.ExecuteScalar().ToString();

            conn.Close();

            if (!passwordAlmacenada.Equals(textBoxLogInPassword.Text))
                existe = false;

            return existe;
        }

        /// <summary>
        /// Comprueba si los campos de texto están completados.
        /// </summary>
        /// <returns>True si los campos están completados, False si no.</returns>
        private bool camposCompletados()
        {
            bool completados = true;

            if (textBoxNameUserLogIn.Text.Length == 0)
            {
                labelNameUserLogIn.ForeColor = Color.Red;
                completados = false;
            }
            else
            {
                labelNameUserLogIn.ForeColor = Color.White;
            }

            if (textBoxLogInPassword.Text.Length == 0)
            {
                labelLogInPassword.ForeColor = Color.Red;
                completados = false;
            }
            else
            {
                labelLogInPassword.ForeColor = Color.White;
            }

            return completados;
        }
    }

}
