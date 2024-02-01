using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectoFinal
{
    /// <summary>
    /// UserControl que representa la barra de tareas de la aplicación.
    /// Contiene botones y eventos asociados a acciones específicas.
    /// </summary>
    public partial class barraTareas : UserControl
    {
        /// <summary>
        /// Delegado para el evento BotonInicioClickeado.
        /// </summary>
        public event EventHandler BotonInicioClickeado;

        /// <summary>
        /// Delegado para el evento BotonHBClickeado.
        /// </summary>
        public event EventHandler BotonHBClickeado;

        /// <summary>
        /// Delegado para el evento TextBoxSearchFocused, que se activa cuando el cuadro de búsqueda recibe el foco.
        /// </summary>
        public event EventHandler TextBoxSearchFocused;

        /// <summary>
        /// Delegado para el evento TextBoxSearchUnfocused, que se activa cuando el cuadro de búsqueda pierde el foco.
        /// </summary>
        public event EventHandler TextBoxSearchUnfocused;

        /// <summary>
        /// Delegado para el evento TextBoxSearching, que se activa cuando el usuario está escribiendo en el cuadro de búsqueda y presiona Enter.
        /// </summary>
        public event EventHandler TextBoxSearching;

        /// <summary>
        /// Nombre que el usuario escribe para buscar.
        /// </summary>
        public string nameSearched { get; set; }

        /// <summary>
        /// Constructor de la clase barraTareas.
        /// </summary>
        public barraTareas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Load que se activa al cargar la barra de tareas.
        /// Inicializa los botones y realiza otras configuraciones necesarias.
        /// </summary>
        private void barraTareas_Load_1(object sender, EventArgs e)
        {
            initBotones();
        }

        /// <summary>
        /// Inicializa la apariencia de los botones de la barra de tareas.
        /// </summary>
        private void initBotones()
        {
            custimizarBotones(buttonInicio);
            custimizarBotones(hambgMenuButton);
        }

        /// <summary>
        /// Personaliza la apariencia de un botón eliminando el borde y ajustando los colores.
        /// </summary>
        /// <param name="boton">Botón a personalizar.</param>
        private void custimizarBotones(System.Windows.Forms.Button boton)
        {
            // Eliminar el borde
            boton.FlatAppearance.BorderSize = 0;
            // Ajustar el color del borde
            boton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            // Configurar FlatAppearance para el estado normal y el estado de foco
            // Eliminar el color de fondo al pasar el cursor
            boton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            // Eliminar el color de fondo al hacer clic
            boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        /// <summary>
        /// Evento Click del botón de inicio.
        /// Invoca el evento BotonInicioClickeado.
        /// </summary>
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            BotonInicioClickeado?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Evento Click del botón de menú.
        /// Invoca el evento BotonHBClickeado.
        /// </summary>
        private void hambgMenuButton_Click_1(object sender, EventArgs e)
        {
            BotonHBClickeado?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Evento Enter del cuadro de búsqueda.
        /// Invoca el evento TextBoxSearchFocused.
        /// </summary>
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            TextBoxSearchFocused?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Evento Leave del cuadro de búsqueda.
        /// Invoca el evento TextBoxSearchUnfocused y limpia el contenido del cuadro de búsqueda.
        /// </summary>
        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            TextBoxSearchUnfocused?.Invoke(this, EventArgs.Empty);
            textBoxSearch.Clear();
        }

        /// <summary>
        /// Evento KeyDown del cuadro de búsqueda.
        /// Captura las pulsaciones de teclas y, si se presiona Enter, invoca el evento TextBoxSearching.
        /// </summary>
        private void textBoxSearching(object sender, KeyEventArgs e)
        {
            nameSearched = textBoxSearch.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxSearch.Text.Length > 0)
                    TextBoxSearching?.Invoke(this, EventArgs.Empty);
            }
        }
    }

}

