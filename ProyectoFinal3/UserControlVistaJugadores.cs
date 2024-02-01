using MySql.Data.MySqlClient;
using ProyectoFinal3.Clases.TuProyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyectoFinal3
{
    /// <summary>
    /// UserControl que muestra una lista de cartas de jugadores.
    /// </summary>
    public partial class UserControlVistaJugadores : UserControl
    {
        /// <summary>
        /// Evento que se activa cuando se hace clic en una carta de jugador.
        /// </summary>
        public EventHandler clickEnCarta;

        /// <summary>
        /// Obtiene o establece el título de la página.
        /// </summary>
        public string tituloPagina { get; set; }

        /// <summary>
        /// Obtiene o establece la lista de jugadores cuyas cartas se mostrarán.
        /// </summary>
        public List<Jugador> jugadoresCartas { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del jugador clickeado.
        /// </summary>
        public int IdJugadorClickado { get; set; }

        /// <summary>
        /// Constructor por defecto del UserControlVistaJugadores.
        /// </summary>
        public UserControlVistaJugadores()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra las cartas de los jugadores en el control.
        /// </summary>
        public void mostrarCartasJugadores()
        {
            //Ocultar temporalmente el panel y cambiar el cursor mientras se cambia el panel
            flowLayoutPanelCartasJugadores.Visible = false;
            Cursor = Cursors.WaitCursor;

            //Limpiar las cartas existentes en el panel
            flowLayoutPanelCartasJugadores.Controls.Clear();

            //Establecer el titulo de la pagina
            labelTitle.Text = tituloPagina;

            //Crear las tarjetas de cada jugador para mostrarlas por pantalla
            foreach (Jugador j in jugadoresCartas)
            {
                UserControlCartaJugador carta = new UserControlCartaJugador(j.ID, j.urlFotoCabeza, j.NombreCompleto);

                //Asociar un manejador de eventos al evento CartaClickeada de cada carta
                carta.CartaClickeada += (sender, args) =>
                {
                    IdJugadorClickado = carta.idJugador;

                    clickEnCarta?.Invoke(this, EventArgs.Empty);
                };

                flowLayoutPanelCartasJugadores.Controls.Add(carta);
            }

            flowLayoutPanelCartasJugadores.Visible = true;
            Cursor = Cursors.Default;
        }
    }

}
