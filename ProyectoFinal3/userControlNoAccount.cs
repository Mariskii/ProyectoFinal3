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
    /// UserControl que representa la interfaz gráfica cuando el usuario no tiene una cuenta.
    /// </summary>
    public partial class userControlNoAccount : UserControl
    {
        /// <summary>
        /// Evento que se dispara cuando se hace click en el botón para crear una cuenta.
        /// </summary>
        public event EventHandler BotonCrearCuentaClickeado;

        /// <summary>
        /// Evento que se dispara cuando se hace click en el botón para iniciar sesión.
        /// </summary>
        public event EventHandler BotonIniciarSesionClickeado;

        /// <summary>
        /// Constructor de la clase userControlNoAccount.
        /// </summary>
        public userControlNoAccount()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que maneja el click en la etiqueta para crear una cuenta.
        /// </summary>
        private void labelCrearCuenta_Click(object sender, EventArgs e)
        {
            BotonCrearCuentaClickeado?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Método que maneja el click en la etiqueta para iniciar sesión.
        /// </summary>
        private void labelIniciarSesion_Click(object sender, EventArgs e)
        {
            BotonIniciarSesionClickeado?.Invoke(this, EventArgs.Empty);
        }
    }

}
