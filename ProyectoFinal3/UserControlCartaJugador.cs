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
    /// UserControl que representa una carta de jugador en la interfaz gráfica.
    /// Contiene información como la imagen del jugador y su nombre.
    /// </summary>
    public partial class UserControlCartaJugador : UserControl
    {
        /// <summary>
        /// Disparador para el evento CartaClickeada, que se activa cuando se hace clic en la carta de jugador.
        /// </summary>
        public EventHandler CartaClickeada;

        /// <summary>
        /// Identificador del jugador asociado a la carta.
        /// </summary>
        public int idJugador { get; set; }

        /// <summary>
        /// Constructor de la clase UserControlCartaJugador.
        /// </summary>
        /// <param name="Id">Identificador del jugador.</param>
        /// <param name="urlImagen">URL de la imagen del jugador.</param>
        /// <param name="namePlayerCard">Nombre del jugador.</param>
        public UserControlCartaJugador(int Id, string urlImagen, string namePlayerCard)
        {
            InitializeComponent();
            idJugador = Id;
            labelCardNamePlayer.Text = namePlayerCard;

            // Cargar la imagen del jugador desde la URL
            pictureBoxCardPlayerImage.Load(urlImagen);
        }

        /// <summary>
        /// Evento Click del UserControlCartaJugador.
        /// Invoca el evento CartaClickeada.
        /// </summary>
        private void UserControlCartaJugador_Click(object sender, EventArgs e)
        {
            CartaClickeada?.Invoke(this, EventArgs.Empty);
        }
    }

}
