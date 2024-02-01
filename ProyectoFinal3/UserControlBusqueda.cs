using ProyectoFinal3.Clases.TuProyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal3
{
    /// <summary>
    /// UserControl que representa la interfaz de búsqueda de jugadores.
    /// </summary>
    public partial class UserControlBusqueda : UserControl
    {
        /// <summary>
        /// Evento que se activa al realizar una búsqueda en la base de datos.
        /// </summary>
        public EventHandler busquedaBaseDatos;

        /// <summary>
        /// Evento que se activa al abrir la vista de un jugador.
        /// </summary>
        public EventHandler abrirUserControlJugador;

        /// <summary>
        /// Lista de jugadores obtenidos en la búsqueda.
        /// </summary>
        private List<Jugador> jugadores;

        /// <summary>
        /// Identificador del jugador seleccionado.
        /// </summary>
        private int idJugadorSeleccionado;

        /// <summary>
        /// Constructor por defecto del UserControlBusqueda.
        /// </summary>
        public UserControlBusqueda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método interno para agregar los resultados de la búsqueda al DataGridView.
        /// </summary>
        private void addResultadosBusqueda()
        {
            dataGridViewSearch.Rows.Clear();

            //Añadir los jugadores al DataGridView
            foreach (Jugador jugador in jugadores)
            {
                string[] filaNueva = new string[4];
                filaNueva[0] = jugador.NombreCompleto;
                filaNueva[1] = "Jugador";
                filaNueva[2] = jugador.Posicion;
                filaNueva[3] = "#" + jugador.Dorsal;

                int rowIndex = dataGridViewSearch.Rows.Add(filaNueva);

                DataGridViewImageCell cell = dataGridViewSearch.Rows[rowIndex].Cells["Imagen"] as DataGridViewImageCell;

                if (!string.IsNullOrEmpty(jugador.urlFotoCabeza))
                {
                    try
                    {
                        //Cargar la imagen desde la URL
                        using (WebClient webClient = new WebClient())
                        {
                            byte[] data = webClient.DownloadData(jugador.urlFotoCabeza);
                            using (MemoryStream ms = new MemoryStream(data))
                            {
                                cell.Value = Image.FromStream(ms);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Setter para la lista de jugadores que activa el evento para mostrarlos por pantalla.
        /// </summary>
        public void setJugadores(List<Jugador> jugadores)
        {
            this.jugadores = jugadores;
            addResultadosBusqueda();
        }

        /// <summary>
        /// Evento que se activa cuando el control DataGridView se hace visible.
        /// </summary>
        private void dataGridViewSearch_VisibleChanged(object sender, EventArgs e)
        {
            dataGridViewSearch.Rows.Clear();
        }

        /// <summary>
        /// Evento que se activa al hacer click en una celda del DataGridView.
        /// Abre la vista del jugador y pasa el ID del mismo.
        /// </summary>
        private void dataGridViewSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pasar el ID del jugador para que se realicen consultas de información sobre ese jugador
            idJugadorSeleccionado = jugadores[e.RowIndex].ID;

            abrirUserControlJugador?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Método que devuelve el ID del jugador que el usuario ha seleccionado.
        /// </summary>
        public int getIdJugadorSeleccionado()
        {
            return idJugadorSeleccionado;
        }
    }

}
