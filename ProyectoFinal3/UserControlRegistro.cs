using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinal3
{
    /// <summary>
    /// UserControl que representa la interfaz de registro de usuarios.
    /// </summary>
    public partial class UserControlRegistro : UserControl
    {
        /// <summary>
        /// Evento que se dispara cuando se hace clic en el botón "Ya tengo cuenta".
        /// </summary>
        public event EventHandler BotonTengoCuentaClickeado;

        /// <summary>
        /// Evento que se dispara cuando se hace clic en el botón "Crear cuenta".
        /// </summary>
        public event EventHandler BotonCrearCuentaClickeado;

        /// <summary>
        /// Nombre de usuario introducido para el registro.
        /// </summary>
        public string userNameRegistration { get; set; }

        /// <summary>
        /// Correo electrónico introducido para el registro.
        /// </summary>
        public string correo { get; set; }

        /// <summary>
        /// Contraseña introducida para el registro.
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Constructor de la clase UserControlRegistro.
        /// </summary>
        public UserControlRegistro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador de eventos para el clic en la etiqueta "Ya tengo cuenta".
        /// Invoca el evento BotonTengoCuentaClickeado.
        /// </summary>
        private void labelAlreadyRegister_Click(object sender, EventArgs e)
        {
            BotonTengoCuentaClickeado?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Comprueba si las contraseñas introducidas coinciden.
        /// </summary>
        /// <returns>True si las contraseñas coinciden, False si no.</returns>
        private bool coincidenPasswords()
        {
            bool coincidenPasswords = false;

            if (textBoxRegisterPassword.Text == textBoxRegisterConfirmPword.Text)
                coincidenPasswords = true;
            else
            {
                labelRegisterConfirmPassword.Text = "La contraseña no coincide";
                labelRegisterConfirmPassword.ForeColor = Color.Red;
                coincidenPasswords = false;
            }

            return coincidenPasswords;
        }

        /// <summary>
        /// Comprueba si ya existe un usuario con el nombre introducido.
        /// </summary>
        /// <returns>True si el nombre de usuario ya existe, False si no.</returns>
        private bool nombreExiste()
        {
            bool existe = false;

            // Configuración de la conexión a la base de datos
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "slamstats";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();

            cmd.Parameters.Add("@name", MySqlDbType.Text).Value = textBoxNameUserRegister.Text;

            cmd.CommandText = "SELECT COUNT(*) FROM usuario WHERE NombreUsuario = @name";

            conn.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            // Si existe un usuario con ese nombre se informará al usuario para que elija otro
            if (count > 0)
            {
                labelNameUserRegister.Text = "Ya existe un usuario con ese nombre";
                existe = true;
            }

            return existe;
        }

        /// <summary>
        /// Comprueba si todos los campos del registro están completados.
        /// </summary>
        /// <returns>True si todos los campos están completados, False si no.</returns>
        private bool camposCompletados()
        {
            bool completados = true;

            if (textBoxNameUserRegister.Text.Length == 0)
            {
                labelNameUserRegister.ForeColor = Color.Red;
                completados = false;
            }
            else
            {
                labelNameUserRegister.ForeColor = Color.White;
            }

            if (textBoxRegisterEmail.Text.Length == 0)
            {
                labelRegistrationEmail.ForeColor = Color.Red;
                completados = false;
            }
            else
            {
                labelRegistrationEmail.ForeColor = Color.White;
            }

            if (textBoxRegisterPassword.Text.Length == 0)
            {
                labelRegisterPassword.ForeColor = Color.Red;
                completados = false;
            }
            else
            {
                labelRegisterPassword.ForeColor = Color.White;
            }

            if (textBoxRegisterConfirmPword.Text.Length == 0)
            {
                labelRegisterConfirmPassword.ForeColor = Color.Red;
                completados = false;
            }
            else
            {
                labelRegisterConfirmPassword.ForeColor = Color.White;
            }

            return completados;
        }

        /// <summary>
        /// Manejador de eventos para el clic en el botón "Crear cuenta".
        /// Realiza comprobaciones y, si son exitosas, invoca el evento BotonCrearCuentaClickeado.
        /// </summary>
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            // Si la contraseña está confirmada correctamente, los campos están completados y no existe un usuario con ese nombre
            // se creará la cuenta
            if (coincidenPasswords() && camposCompletados() && !nombreExiste())
            {
                userNameRegistration = textBoxNameUserRegister.Text;
                correo = textBoxRegisterEmail.Text;
                password = textBoxRegisterPassword.Text;

                BotonCrearCuentaClickeado?.Invoke(this, EventArgs.Empty);
            }
        }
    }

}