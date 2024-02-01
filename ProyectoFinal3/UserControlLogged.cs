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
    /// UserControl que representa la interfaz gráfica cuando el usuario ha iniciado sesión.
    /// </summary>
    public partial class UserControlLogged : UserControl
    {
        /// <summary>
        /// Evento que se dispara cuando se hace click en el panel de favoritos.
        /// </summary>
        public EventHandler panelFavoritosClickeado;

        /// <summary>
        /// Evento que se dispara cuando se hace click en el botón para cerrar sesión.
        /// </summary>
        public EventHandler cerrarSesionClickeado;

        /// <summary>
        /// Constructor de la clase UserControlLogged.
        /// </summary>
        public UserControlLogged()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que maneja el evento cuando el mouse entra en el panel.
        /// </summary>
        private void panelLogged_MouseEnter(object sender, EventArgs e)
        {
            panelLoggedFavPlayers.BackColor = Color.FromArgb(244, 169, 55);
        }

        /// <summary>
        /// Método que maneja el evento cuando el mouse sale del panel.
        /// </summary>
        private void panelLogged_MouseLeave(object sender, EventArgs e)
        {
            panelLoggedFavPlayers.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Setter para establecer el nombre del usuario que ha iniciado sesión.
        /// </summary>
        public void setUserName(string userName)
        {
            labelUserName.Text = userName;
        }

        /// <summary>
        /// Método que maneja el click en el panel de favoritos.
        /// </summary>
        private void panelLoggedFavPlayers_Click(object sender, EventArgs e)
        {
            panelFavoritosClickeado?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Método que maneja el click en el botón para cerrar sesión.
        /// </summary>
        private void labelCloseSession_Click(object sender, EventArgs e)
        {
            cerrarSesionClickeado?.Invoke(this, EventArgs.Empty);
        }
    }
}
