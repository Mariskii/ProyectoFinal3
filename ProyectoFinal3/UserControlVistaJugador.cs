using MySql.Data.MySqlClient;
using proyectoFinal;
using ProyectoFinal3.Clases;
using ProyectoFinal3.Clases.TuProyecto.Models;
using ProyectoFinal3.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace ProyectoFinal3
{
    public partial class UserControlVistaJugador : UserControl
    {
        //Conector de la base de datos
        public MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public MySqlConnection conn;
        public MySqlCommand cmd;

        //Datos del jugador
        private Jugador jugador = new Jugador();
        private List<Temporada> temporadas = new List<Temporada>();
        private Premios premios = new Premios();
        private List<byte[]> equipos = new List<byte[]>();

        //Lista de pictureBox para pintar los trofeos
        private List<PictureBox> pictureBoxesPremios;
        private List<Label> labelsCantidadPremios;

        private int idjugador;
        private bool favorito;
        private bool login;
        private string userName;

        public UserControlVistaJugador(int idJugador, bool login, string userName)
        {
            InitializeComponent();
            idjugador = idJugador;

            this.login = login;
            this.userName = userName;

            Dock = DockStyle.Fill;

            //Añadir a la lista los picturebox necesarios
            pictureBoxesPremios = new List<PictureBox> { pictureBoxPremio1, pictureBoxPremio2, pictureBoxPremio3, pictureBoxPremio4, pictureBoxPremio5, pictureBoxPremio6 };
            labelsCantidadPremios = new List<Label> {labelPremioCantidad1, labelPremioCantidad2, labelPremioCantidad3, labelPremioCantidad4, labelPremioCantidad5 };
        }

        private void UserControlVistaJugador_Load(object sender, EventArgs e)
        {
            initConectorMySql();

            //Mientras la pantalla del jugador se carga y se distribuye la información no se verá el userControl
            //Y el cursor cambiará al del estado de carga para que el usuario sepa que está cargando
            Cursor = Cursors.WaitCursor;
            Visible = false;

            //Comprobar si el jugador está en la lista de favoritos del usuario
            isFavorito();

            //Pedir la información a la base de datos de la información principal del jugador y pintarla
            getJugadorFromDatabase();
            paintPlayerMainInfo();

            //Pedir información de la base de datos de la información de las estadísticas del jugador y pintarla
            getEstadisticasFromDatabase();
            paintPlayerStats();

            //Pedir información a la base de datos de los premios que ha ganado el jugador y pintarlos
            getPremiosFromDatabase();
            paintPlayerTrophies();

            //Pedir las url de los equipos de los cuales ha formado parte el jugador y añadir las imagenes por pantalla
            getEquiposFromDatabase();
            paintPlayerTeams();

            //Una vez distribuida y pintada la informacion se mostrará la pantalla y el cursor volverá a su estado normal
            Visible = true;
            Cursor = Cursors.Default;
        }

        private void isFavorito() 
        {

            if(login)
            {
                cmd.CommandText = "SELECT COUNT(*) FROM jugadoresFavoritos WHERE JugadorID = @idJugador AND UsuarioID = (SELECT ID FROM usuario WHERE NombreUsuario = @userName)";

                conn.Open();

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                if (cantidad > 0)
                {
                    favorito = true;
                    pictureBoxFavorito.Image = Resources.estrellaLlena;
                }

                conn.Close();
            }
        }

        private void getJugadorFromDatabase() 
        {
            cmd.CommandText = "SELECT * FROM JUGADOR WHERE ID = @idJugador";

            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read()) 
            {
                //asignar los valores del jugador
                jugador.ID = Convert.ToInt32(reader["ID"]);
                jugador.NombreCompleto = Convert.ToString(reader["nombreCompleto"]);
                jugador.Nacionalidad = Convert.ToString(reader["Nacionalidad"]);
                jugador.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                jugador.Altura = Convert.ToString(reader["Altura"]);
                jugador.Peso = Convert.ToString(reader["Peso"]);
                jugador.Posicion = Convert.ToString(reader["Posicion"]);
                jugador.Dorsal = Convert.ToString(reader["Dorsal"]);
                jugador.urlFotoCompleta = Convert.ToString(reader["fotoCompleta"]);
                jugador.urlFotoCabeza = Convert.ToString(reader["fotoCabeza"]);
            }

            conn.Close();
        }

        private void getEstadisticasFromDatabase() 
        {
            cmd.CommandText = "SELECT * FROM estadisticasportemporadajugador WHERE JugadorId = @idJugador";

            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            Temporada temporada;

            while (reader.Read())
            {
                temporada = new Temporada();

                temporada.season = Convert.ToString(reader["Temporada"]);
                temporada.PJ = Convert.ToInt32(reader["PJ"]);
                temporada.PPP = Convert.ToDouble(reader["PPP"]);
                temporada.TC = Convert.ToInt32(reader["TC"]);
                temporada.TL = Convert.ToInt32(reader["TL"]);
                temporada.RPP = Convert.ToDouble(reader["RPP"]);
                temporada.APP = Convert.ToDouble(reader["APP"]);
                temporada.STL = Convert.ToDouble(reader["STL"]);
                temporada.BLK = Convert.ToDouble(reader["BLK"]);
                temporada._3PM = Convert.ToDouble(reader["3PM"]);
                temporada._3PERC = Convert.ToDouble(reader["3PERC"]);

                temporadas.Add(temporada);
            }

            conn.Close();
        }

        private void getPremiosFromDatabase() 
        {
            cmd.CommandText = "SELECT * FROM premios WHERE JugadorId = @idJugador";

            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read()) 
            {
                premios.Anillos = Convert.ToInt32(reader["Anillos"]);
                premios.FMVP = Convert.ToInt32(reader["FMVP"]);
                premios.MVP = Convert.ToInt32(reader["MVP"]);
                premios.AllStar = Convert.ToInt32(reader["AllStar"]);
                premios.Anillos = Convert.ToInt32(reader["Anillos"]);
                premios.DPOY = Convert.ToInt32(reader["DPOY"]);
                premios.ROY = Convert.ToInt32(reader["ROY"]);
            }

            conn.Close();
        }

        private void getEquiposFromDatabase() 
        {
            cmd.CommandText = "SELECT Equipo.* FROM Jugador JOIN JugadorEquipo ON Jugador.ID = JugadorEquipo.JugadorID JOIN Equipo ON JugadorEquipo.EquipoID = Equipo.ID WHERE Jugador.ID = @idJugador;";

            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            string equipo;

            while (reader.Read())
            {
                // Obtén la información de la imagen del jugador en formato de bytes
                byte[] imagenJugador = reader.IsDBNull(reader.GetOrdinal("imagen_equipo")) ? null : (byte[])reader["imagen_equipo"];

                // Agrega la imagen del jugador a la lista
                equipos.Add(imagenJugador);
            }

            conn.Close();
        }

        private void paintPlayerTeams() 
        {
            foreach(byte[] equipo in equipos) 
            {
                PictureBox pictureBox = new PictureBox();

                MemoryStream stream = new MemoryStream(equipo);

                Image imagen = Image.FromStream(stream);
                pictureBox.Image = imagen;


                pictureBox.Width = 50;
                pictureBox.Height = 50;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                // Agrega el PictureBox al FlowLayoutPanel
                flowLayoutPanelEquipos.Controls.Add(pictureBox);
            }
        }

        private void paintPlayerTrophies() 
        {
            //Pintar cada trofeos
            if(premios.Anillos > 0) 
            {
                pictureBoxesPremios[0].Image = Resources.LarryObrein;
                pictureBoxesPremios[0].Visible = true;
                pictureBoxesPremios.RemoveAt(0);

                labelsCantidadPremios[0].Text = "x" + premios.Anillos;
                labelsCantidadPremios.RemoveAt(0);
            }

            if (premios.FMVP > 0)
            {
                pictureBoxesPremios[0].Image = Resources.FMVP;
                pictureBoxesPremios[0].Visible = true;
                pictureBoxesPremios.RemoveAt(0);

                labelsCantidadPremios[0].Text = "x" + premios.FMVP;
                labelsCantidadPremios.RemoveAt(0);
            }

            if (premios.MVP > 0)
            {
                pictureBoxesPremios[0].Image = Resources.MVP;
                pictureBoxesPremios[0].Visible = true;
                pictureBoxesPremios.RemoveAt(0);

                labelsCantidadPremios[0].Text = "x" + premios.MVP;
                labelsCantidadPremios.RemoveAt(0);
            }

            if (premios.AllStar > 0)
            {
                pictureBoxesPremios[0].Image = Resources.AllStar;
                pictureBoxesPremios[0].Visible = true;
                pictureBoxesPremios.RemoveAt(0);

                labelsCantidadPremios[0].Text = "x" + premios.AllStar;
                labelsCantidadPremios.RemoveAt(0);
            }

            if (premios.DPOY > 0)
            {
                pictureBoxesPremios[0].Image = Resources.DPOY;
                pictureBoxesPremios[0].Visible = true;
                pictureBoxesPremios.RemoveAt(0);

                labelsCantidadPremios[0].Text = "x" + premios.DPOY;
                labelsCantidadPremios.RemoveAt(0);
            }

            if (premios.ROY > 0)
            {
                pictureBoxesPremios[0].Image = Resources.ROY;
                pictureBoxesPremios[0].Visible = true;
                pictureBoxesPremios.RemoveAt(0);
            }
        }

        private void paintPlayerStats() 
        {
            //Si hay estadísticas para ese jugador se cargaran en el combobox
            if(temporadas.Count > 0) 
            {
                //añadir las posibles temporadas a visualizar del jugador
                foreach (Temporada temporada in temporadas)
                {
                    comboBoxTemporada.Items.Add(temporada.season);
                }

                comboBoxTemporada.SelectedIndex = 0;
            }
        }

        private void paintPlayerMainInfo() 
        {
            pictureBoxPlayer.Load(jugador.urlFotoCompleta);

            labelPlayerNumber.Text = "#" + jugador.Dorsal;

            labelPlayerName.Text = jugador.NombreCompleto;

            labelPosicion.Text = jugador.Posicion;

            labelAltura.Text = jugador.Altura;

            labelNacionalidad.Text = jugador.Nacionalidad;

            labelEdad.Text = jugador.FechaNacimiento.ToString("dd/MM/yyyy") +"("+calcularEdad()+" años)";
        }

        //Método que calcula la edad del jugador
        public int calcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - jugador.FechaNacimiento.Year;

            //Comprobar si ya ha pasado el cumpleaños en este año
            if (jugador.FechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        private void initConectorMySql()
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "slamstats";

            conn = new MySqlConnection(builder.ToString());
            cmd = conn.CreateCommand();

            cmd.Parameters.Add("@idJugador", MySqlDbType.Text).Value = idjugador;
            cmd.Parameters.Add("@userName", MySqlDbType.Text).Value = userName;
        }

        //Método que mostrará por pantalla las estadísticas del año que seleccione el usuario
        private void comboBoxTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtener el indice de la temporada seleccionada
            int indiceTemporada = comboBoxTemporada.SelectedIndex;

            //cambiar los datos por los de la temporada seleccionada
            labelPJ.Text = temporadas[indiceTemporada].PJ.ToString();
            labelPPP.Text = temporadas[indiceTemporada].PPP.ToString();
            labelTC.Text = temporadas[indiceTemporada].TC.ToString();
            labelTL.Text = temporadas[indiceTemporada].TL.ToString();
            labelRPP.Text = temporadas[indiceTemporada].RPP.ToString();
            labelAPP.Text = temporadas[indiceTemporada].APP.ToString();
            labelSTL.Text = temporadas[indiceTemporada].STL.ToString();
            labelBLK.Text = temporadas[indiceTemporada].BLK.ToString();
            label3PM.Text = temporadas[indiceTemporada]._3PM.ToString();
            label3FGM.Text = temporadas[indiceTemporada]._3PERC.ToString();
        }

        private void pictureBoxFavorito_Click(object sender, EventArgs e)
        {
            int filasAfectadas;

            if (login) 
            {
                conn.Open();

                //Si el jugador no está en favoritos lo añadirá a favoritos
                if (!favorito)
                {
                    cmd.CommandText = "INSERT INTO jugadoresfavoritos(JugadorID,UsuarioID) VALUES (@idJugador,(SELECT ID FROM usuario WHERE NombreUsuario = @userName))";

                    filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        pictureBoxFavorito.Image = Resources.estrellaLlena;
                        favorito = true;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error agregando el jugador a tu lista de favoritos", "Error al añadir a favoritos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else 
                {
                    cmd.CommandText = "DELETE FROM jugadoresfavoritos WHERE JugadorID = @idJugador AND UsuarioID = (SELECT ID FROM usuario WHERE NombreUsuario = @userName)";

                    filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        pictureBoxFavorito.Image = Resources.estrellaVacia;
                        favorito = false;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error eliminar el jugador a tu lista de favoritos", "Error al eliminar de favoritos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                conn.Close();
            }
            else 
            {
                //Si no se ha iniciado sesión se avisará al usuario de que debe iniciar sesión
                MessageBox.Show("Debe iniciar sesión para agregar el jugador a favoritos", "Inicio de Sesión Requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Getter del jugador de la página, su objetivo es añadir el jugador a la vista de recientes de la vista de inicio
        public Jugador getJugador() 
        {
            return jugador;
        }
    }
}
