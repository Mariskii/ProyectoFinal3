using System.Windows.Forms;
using System;
using ProyectoFinal3;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Reflection;
using ProyectoFinal3.Clases.TuProyecto.Models;
using System.Collections.Generic;
using System.Collections;

namespace proyectoFinal
{
    public partial class FormMain : Form
    {
        //Elementos de la aplicación que se muestran por pantalla
        private UserControlInicioVacio userControlInicioVacio = new UserControlInicioVacio();
        private barraTareas barraTareas = new barraTareas();

        //LOS DOS ESTADOS EN LOS QUE SE PUEDE ENCONTRAR EL MENÚ LATERAL
        private userControlNoAccount userControlNoAccount = new userControlNoAccount();
        private UserControlLogged userControlLogged = new UserControlLogged();

        private UserControlRegistro userControlRegistro = new UserControlRegistro();
        private UserControlIniciarSesion userControlIniciarSesion = new UserControlIniciarSesion();
        private UserControlBusqueda userControlBusqueda = new UserControlBusqueda();

        UserControlVistaJugadores userControlVistaJugadores = new UserControlVistaJugadores();

        //UserControl en el que se guardará la anterior ventana, par cuando el textbox deje de estar focus
        //vuelva al userControl Principal
        UserControl userControlAuxiliar;

        //Si el menú lateral está expandido o no
        bool menuExpanded = true;

        //Conector de la base de datos
        public MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public MySqlConnection conn;
        public MySqlCommand cmd;

        //Si se ha iniciado sesión
        bool login = false;
        string userName;

        //Los jugadores que el usuario ha visto recientemente
        List<Jugador> jugadoresRecientes = new List<Jugador>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //hacer que el tamaño del control de usuario al tamaño de panel cuando se carga el form
            userControlInicioVacio.Dock = DockStyle.Fill;

            //cargar el control de inicio al panel cuando se carga el formulario
            panelPrincipal.Controls.Add(userControlInicioVacio);

            //TOOLSBAR
            barraTareas.Dock = DockStyle.Fill;

            //Mostrar la barra de tareas en el panel superior del formulario
            panelToolsBar.Controls.Add(barraTareas);


            //Inicializar el contenido del menú lateral
            initHBMenu();

            initConectorMySql();
            initActions();
        }

        private void initConectorMySql() 
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "slamstats";

            conn = new MySqlConnection(builder.ToString());
            cmd = conn.CreateCommand();

            //Datos que se buscarán y almacenarán

            cmd.Parameters.Add("@name", MySqlDbType.Text).Value = userControlRegistro.userNameRegistration;
            cmd.Parameters.Add("@email", MySqlDbType.Text).Value = userControlRegistro.correo;
            cmd.Parameters.Add("@password", MySqlDbType.Text).Value = userControlRegistro.password;
            //cmd.Parameters.Add("@nameSearched", MySqlDbType.Text).Value = barraTareas.nameSearched;
            cmd.Parameters.Add("@nameSearched", MySqlDbType.Text).Value = "%" + barraTareas.nameSearched + "%";
        }

        private void initActions() 
        {
            barraTareas.BotonInicioClickeado += mostrarInicio;
            barraTareas.BotonHBClickeado += mostrarMenu;
            barraTareas.TextBoxSearchFocused += buscarFocused;
            //barraTareas.TextBoxSearchUnfocused += buscarUnFocused;
            barraTareas.TextBoxSearching += buscar;

            userControlNoAccount.BotonCrearCuentaClickeado += mostrarCrearCuenta;
            userControlNoAccount.BotonIniciarSesionClickeado += mostrarIniciarSesion;

            userControlIniciarSesion.BotonNoTengoCuentaClickeado += mostrarCrearCuenta;
            userControlIniciarSesion.BotonIniciarSesiónClickeado += iniciarSesion;

            userControlRegistro.BotonTengoCuentaClickeado += mostrarIniciarSesion;
            userControlRegistro.BotonCrearCuentaClickeado += crearCuenta;

            userControlBusqueda.abrirUserControlJugador += mostrarJugador;

            userControlVistaJugadores.clickEnCarta += mostrarJugadorCarta;

            userControlLogged.panelFavoritosClickeado += mostrarJugadoresFavoritos;
            userControlLogged.cerrarSesionClickeado += cerrarSesion;
        }


        //Definir el evento del boton de inicio de la barra de tareas, que es mostrar en el panel principal el inicio de la aplicaciom
        private void mostrarInicio(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            if(jugadoresRecientes.Count < 1)
                panelPrincipal.Controls.Add(userControlInicioVacio);
            else 
            {

                //Si hay más de 5 jugadores se borrará el ultimo
                if(jugadoresRecientes.Count > 5)
                    jugadoresRecientes.Remove(jugadoresRecientes.Last());

                panelPrincipal.Controls.Add(userControlVistaJugadores);

                userControlVistaJugadores.tituloPagina = "Vistos recientemente";
                userControlVistaJugadores.jugadoresCartas = jugadoresRecientes;

                userControlVistaJugadores.mostrarCartasJugadores();
            }
        }

        //Definir el evento que al pulsarlo mostrará y desaparecerá el menú lateral
        private void mostrarMenu(object sender, EventArgs e)
        {
            timerHMenu.Start();
        }

        //Mostrar por el menú lateral un contenido u otro dependiendo de si se ha iniciado sesión o no
        private void initHBMenu()
        {

            if (!login) 
            {
                panelHBmenuContent.Controls.Add(userControlNoAccount);
                userControlNoAccount.Dock = DockStyle.Fill;
            }
            else 
            {
                panelHBmenuContent.Controls.Add(userControlLogged);
                userControlLogged.Dock = DockStyle.Fill;
            }
            
        }

        //Cada 10 milisegundos el menú se contraerá o expandirá 10px
        private void timerHMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpanded)
            {
                contraerMenu();
            }
            else
            {
                expandirMenu();
            }
        }

        private void contraerMenu() 
        {
            hamburguerMenu.Width -= 10;
            if (hamburguerMenu.Width == hamburguerMenu.MinimumSize.Width)
            {
                menuExpanded = false;
                timerHMenu.Stop();
            }
        }

        private void expandirMenu() 
        {
            hamburguerMenu.Width += 10;
            if (hamburguerMenu.Width == hamburguerMenu.MaximumSize.Width)
            {
                menuExpanded = true;
                timerHMenu.Stop();
            }
        }

        //Navegación Para crear cuenta
        private void mostrarCrearCuenta(object sender, EventArgs e)
        {
            //minimizar el menú lateral
            hamburguerMenu.Width = 0;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(userControlRegistro);
            userControlRegistro.Dock = DockStyle.Fill;
        }

        private void mostrarIniciarSesion(object sender, EventArgs e)
        {
            hamburguerMenu.Width = 0;
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(userControlIniciarSesion);
            userControlIniciarSesion.Dock = DockStyle.Fill;
        }


        //CREAR CUENTA
        //Método que crea la cuenta accediendo a la base de datos y introduciendo los datos del usuario
        private void crearCuenta(object sender, EventArgs e) 
        {
            //Consulta que se va a ejecutar
            string sql;

            MySqlCommand cmdCrearCuenta = conn.CreateCommand();

            cmdCrearCuenta.Parameters.Add("@name", MySqlDbType.Text).Value = userControlRegistro.userNameRegistration;
            cmdCrearCuenta.Parameters.Add("@email", MySqlDbType.Text).Value = userControlRegistro.correo;
            cmdCrearCuenta.Parameters.Add("@password", MySqlDbType.Text).Value = userControlRegistro.password;

            cmdCrearCuenta.CommandText = "INSERT INTO usuario (NombreUsuario,Correo,Contrasena) VALUES (@name,@email,@password)";

            conn.Open();

            int rowsAffected = cmdCrearCuenta.ExecuteNonQuery();

            //Si el registro se ha hecho correctamente
            if (rowsAffected > 0)
            {
                //Al crear la cuenta se inicia sesion automaticamente
                login = true;

                //Guardar el nombre del usuario creado para que se inicie se sesión y que se muestre el nuevo nombre
                //de usuario en el menu lateral
                userName = userControlRegistro.userNameRegistration;
                userControlLogged.setUserName(userName);
                //Cambiar el panel que se muestra en el menu lateral
                panelHBmenuContent.Controls.Clear();
                panelHBmenuContent.Controls.Add(userControlLogged);
                userControlLogged.Dock = DockStyle.Fill;

                UserControlCuentaCreada userControlCuentaCreada = new UserControlCuentaCreada();

                panelPrincipal.Controls.Clear();
                panelPrincipal.Controls.Add(userControlCuentaCreada);
                userControlCuentaCreada.Dock = DockStyle.Fill;
            }
            else
            {
                panelPrincipal.Controls.Add(new UserControlErrorRegister());
                Dock = DockStyle.Fill;
            }  

            conn.Close();
        }

        //Iniciar Sesión
        public void iniciarSesion(object sender, EventArgs e)
        {
            userName = userControlIniciarSesion.userNameLogIn;
            login = true;

            userControlLogged.setUserName(userName);

            //Cambiar el panel que se muestra en el menu lateral
            panelHBmenuContent.Controls.Clear();
            panelHBmenuContent.Controls.Add(userControlLogged);
            userControlLogged.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(userControlInicioVacio);

            jugadoresRecientes.Clear();

            userControlInicioVacio.Dock = DockStyle.Fill;
        }

        //Método para cerrar la sesión
        public void cerrarSesion(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si la respuesta del usuario es positiva se cerrara la sesion
            if (resultado == DialogResult.Yes)
            {
                
                userName = "";
                login = false;

                panelPrincipal.Controls.Clear();
                panelPrincipal.Controls.Add(userControlInicioVacio);

                // Cambiar el panel que se muestra en el menú lateral
                panelHBmenuContent.Controls.Clear();
                panelHBmenuContent.Controls.Add(userControlNoAccount);
                userControlNoAccount.Dock = DockStyle.Fill;
            }
        }

        //BUSQUEDA DE JUGADOR

        //Método que se encarga de mostrar la pantalla de busqueda
        public void buscarFocused(object sender, EventArgs e) 
        {
            hamburguerMenu.Width = 0;

            //almacenar el userControl que se encuentra visible antes de mostrar el otro
            userControlAuxiliar = panelPrincipal.Controls.OfType<UserControl>().FirstOrDefault();

            //Se mostrará la vista de busqueda
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(userControlBusqueda);
            userControlBusqueda.Dock = DockStyle.Fill;          
        }

        /*public void buscarUnFocused(object sender, EventArgs e) 
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(userControlAuxiliar);
            userControlAuxiliar.Dock = DockStyle.Fill;
        }*/

        //Método que busca a los jugadores o equipos
        public void buscar(object sender, EventArgs e) 
        {
            MySqlCommand cmdBuscarJugador = conn.CreateCommand();
            cmdBuscarJugador.Parameters.Add("@nameSearched", MySqlDbType.Text).Value = "%" + barraTareas.nameSearched + "%";

            //Realizar la consulta que devolverá los jugadores y equipos que ha pedido el usuario
            cmdBuscarJugador.CommandText = "SELECT * FROM JUGADOR WHERE nombreCompleto LIKE @nameSearched";

            conn.Open();

            //Lista en la que se almacenarán todos los jugadores
            List<Jugador> jugadores = new List<Jugador>();

            MySqlDataReader reader = cmdBuscarJugador.ExecuteReader();

            //Crear la lista de jugadores que se han encontrado en la base de datos
            while (reader.Read())
            {
                Jugador jugador = new Jugador();

                //asignar los valores del jugador
                jugador.ID = Convert.ToInt32(reader["ID"]);
                jugador.NombreCompleto = Convert.ToString(reader["nombreCompleto"]);
                jugador.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                jugador.Posicion = Convert.ToString(reader["Posicion"]);
                jugador.Dorsal = Convert.ToString(reader["Dorsal"]);
                jugador.urlFotoCabeza = Convert.ToString(reader["fotoCabeza"]);

                jugadores.Add(jugador);
            }

            //Agregar los resultados a la vista busqueda
            userControlBusqueda.setJugadores(jugadores);

            conn.Close();
        }

        //Método que muestra por pantalla el panel con los datos de un jugador
        private void mostrarJugador(object sender, EventArgs e) 
        {
            panelPrincipal.Controls.Clear();
            //Crear un nuevo userControl de jugador al que se le pasa el id del jugador sobre el que realizará las consultas
            UserControlVistaJugador userControlVistaJugador = new UserControlVistaJugador(userControlBusqueda.getIdJugadorSeleccionado(), login, userName);
            panelPrincipal.Controls.Add(userControlVistaJugador);

            //Añadir el jugador a los vistos recientemente
            addJugadorRecientes(userControlVistaJugador);
        }

        //Método para mostrar la vista de un jugador a partir de su tarjeta
        private void mostrarJugadorCarta(object sender, EventArgs e) 
        {
            panelPrincipal.Controls.Clear();
            //Crear un nuevo userControl de jugador al que se le pasa el id del jugador sobre el que realizarán las consultas
            UserControlVistaJugador userControlVistaJugador = new UserControlVistaJugador(userControlVistaJugadores.IdJugadorClickado, login, userName);
            panelPrincipal.Controls.Add(userControlVistaJugador);

            //Añadir el jugador a los vistos recientemente
            addJugadorRecientes(userControlVistaJugador);
        }

        //Método que añade el jugador a los vistos recientemente si el jugador no está en la lista de vistos recientemiente lo añadirá 
        private void addJugadorRecientes(UserControlVistaJugador ucvj) 
        {
            if (!jugadoresRecientes.Any(jugador => jugador.ID == ucvj.getJugador().ID))
                jugadoresRecientes.Add(ucvj.getJugador());
        }

        //Método que muestra por pantalla el panel con los jugadores favoritos del usuario
        private void mostrarJugadoresFavoritos(object sender, EventArgs e) 
        {
            MySqlCommand cmdBuscarJugadoresFavoritos = conn.CreateCommand();
            cmdBuscarJugadoresFavoritos.Parameters.Add("@userName", MySqlDbType.Text).Value = userName;

            cmdBuscarJugadoresFavoritos.CommandText = "SELECT Jugador.NombreCompleto, Jugador.fotoCabeza, Jugador.ID" +
                    " FROM Jugador" +
                    " JOIN JugadoresFavoritos ON Jugador.ID = JugadoresFavoritos.JugadorID" +
                    " JOIN Usuario ON JugadoresFavoritos.UsuarioID = Usuario.ID" +
                    " WHERE Usuario.NombreUsuario = @userName";

            conn.Open();

            //Lista en la que se almacenarán todos los jugadores
            List<Jugador> jugadores = new List<Jugador>();

            Jugador jugador;

            MySqlDataReader reader = cmdBuscarJugadoresFavoritos.ExecuteReader();

            //Leer los jugadores que ha devuelto la consulta
            while (reader.Read())
            {
                jugador = new Jugador();

                jugador.ID = Convert.ToInt32(reader["ID"]);
                jugador.NombreCompleto = Convert.ToString(reader["NombreCompleto"]);
                jugador.urlFotoCabeza = Convert.ToString(reader["fotoCabeza"]);

                jugadores.Add(jugador);
            }

            conn.Close();

            userControlVistaJugadores.tituloPagina = "Jugadores Favoritos";
            userControlVistaJugadores.jugadoresCartas = jugadores;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(userControlVistaJugadores);
            userControlVistaJugadores.Dock = DockStyle.Fill;
            userControlVistaJugadores.mostrarCartasJugadores();
            hamburguerMenu.Width = 0;
        }
    }
}