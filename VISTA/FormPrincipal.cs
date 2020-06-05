using MySql.Data.MySqlClient;
using PantallaMain.DATOS;
using PantallaMain.MODELO;
using PantallaMain.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PantallaMain
{


    public partial class FormPrincipal : Form
    {
        string imgLoc = "";
        bool play = false;
        string[] archivosMP3;
        string[] rutasArchivosMP3;
        public string posicion;
        int contador;
        byte[] imagenes;
        cliente cli = new cliente();
        MemoryStream ms1 = new MemoryStream();

        public FormPrincipal()
        {
            InitializeComponent();

        }
        public FormPrincipal(string usuario)
        {
            InitializeComponent();

         
            buttonInsertar.Visible = false;
            //this.Icon = Properties.Resources.Address_Book;
            labelUsuario.Text = usuario;
            canciones();
            fotoPerfil();
            comboBox1.Items.AddRange(new object[] { "pop", "trap", "electronic" });
            tablaCanciones.ClearSelection();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            canciones();

        }


        private void buttonPlay_Click(object sender, EventArgs e)
        {



        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn column in tablaCanciones.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        /// <summary>
        /// Añadimos a la tabla las canciones que tenemos en la base de datos
        /// </summary>
        public void canciones()
        {
            //Llamamos a la clase sqlCanciones 
            sqlCanciones con = new sqlCanciones();
            //Limpiamos la tabla de todo registro o filtro anterior
            tablaCanciones.Rows.Clear();
            try
            {
                //Bucle por cada posicion de la array vamos rellenando la tabla con los geters de la clase cancion
                foreach (cancion cancion in con.guardarEnTabla("cancion"))
                {
                    //Añadimos a la tabla el objeto que cogemos 
                    tablaCanciones.Rows.Add(new object[] { cancion.getNombre(), cancion.getArtista(), cancion.getGenero() });
                    Console.WriteLine(cancion.getIdCancion());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        /// <summary>
        /// Seleccion de tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tablaCanciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlPlaylist sqlplay = new sqlPlaylist();
            playlist play = new playlist();
            sqlCanciones con = new sqlCanciones();
            string posicionNombre = "";
            string posicionArtista = "";
            contador = 0;
            //Si la tabla no esta vaci0a
            if (tablaCanciones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && e.RowIndex >= 0)
            {
                tablaCanciones.CurrentCell.Selected = true;
                //Cuando seleccionamos una tabla nos devuelve un string con el nombre del artista y la cancion
                posicionNombre = tablaCanciones.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                posicionArtista = tablaCanciones.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                labelInvisibleNombre.Text = posicionNombre;
                labelInvisibleArtista.Text = posicionArtista;
                //Console.WriteLine(posicionNombre);
                //Console.WriteLine(posicionArtista);
            }
            //Creamos objeto pasamos a la playlist el string entero y el nombre de usuario
            play = new playlist(labelUsuario.Text, stringPlaylist());
            //Si es la primera vez el cual ese usuario añade a la playlist
            if (sqlplay.primeraVez(play) == "")
            {

                buttonAñadirPlaylist.Text = "ADD TO PLAYLIST";
            }
            else
            //SI el string de esa cancion contiene la misma
           if (sqlplay.primeraVez(play).Contains(" " + play.getIdCanciones() + " "))
            {
                buttonAñadirPlaylist.Text = "DELETE TO PLAYLIST";

            }
            //Si no la contiene
            else
            {
                buttonAñadirPlaylist.Text = "ADD TO PLAYLIST";

            }
            labelNombre.Text = labelInvisibleNombre.Text;
            labelArtista.Text = labelInvisibleArtista.Text;
            string nombre = labelInvisibleNombre.Text;
            //A memoryStream cogemos la imagen de la base de datos
            ms1 = new MemoryStream(con.imagen(nombre));
            ms1.Seek(0, SeekOrigin.Begin);
            //Insertamos la imagen en un pictureBox
            pictureBox1.Image = Image.FromStream(ms1);
            buttonAñadirPlaylist.Visible = true;



        }
        /// <summary>
        /// Si apretamos el boton stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            //Se para la cancion y la barra va a 0
            reproductor.Ctlcontrols.stop();
            //Cambiamos imagen de pause en play
            ImagenPlay.Image = Properties.Resources.ButtonPlayBlanco;
            play = false;
        }
        /// <summary>
        /// Si le damos a play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImagenPlay_Click(object sender, EventArgs e)
        {
            sqlCanciones con = new sqlCanciones();
            
            try
            {
                //Guardamos en un string el directorio actual donde se encuantra nuestro programa
                string path = Directory.GetCurrentDirectory();
                
                string nombre = labelInvisibleNombre.Text;

                Console.WriteLine(labelInvisibleNombre);

                



                switch (play)
                {
                    //Si ya le hemos dado a pause
                    case true:
                        //Pausamos la cancion
                        reproductor.Ctlcontrols.pause();
                        //Cambiamos la imagen de pause a play
                        ImagenPlay.Image = Properties.Resources.ButtonPlayBlanco;
                        play = false;
                        break;
                    //Si le damos a play
                    case false:
                        //Si no se ha seleccionado ninguna cancion
                        if (nombre.Equals("label2") && contador == 0)
                        {
                            MessageBox.Show("You dont select a song", "Error");
                        }
                        //Si es la primera vez que se reproduce la cancion
                        else if (contador == 0)
                        {

                            //reproducimos la cancion 
                            reproductor.URL = path + "\\" + "musica" + "\\" + nombre + ".mp3";




                            //Console.WriteLine("comando es: " + imagenes[0]);




                            contador++;
                        }
                        //Reproduce la cancion
                        reproductor.Ctlcontrols.play();
                        //Cambiamos la imagen de play a pause
                        ImagenPlay.Image = Properties.Resources.buttonPausaBlanco;
                        play = true;
                        break;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("No va");
            }

            //string con ruta actual

        }
        /// <summary>
        /// Timer que actuliza la barra de estado cada segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Llamamos la funcion que actualiza 
            actualizarDatosTrack();
            //Cogemos el valor del MacTrack de Windows.Media.Player y actualizamos nuestro mactrackBar 
            macTrackBarTiempo.Value = (int)reproductor.Ctlcontrols.currentPosition;
            //Cogemos el valor del MacTrack del volumen de Windows.Media.Player y actualizamos nuestro mactrackBar 
            macTrackBarVolumen.Value = reproductor.settings.volume;

        }
        /// <summary>
        /// Actualizamos los datos de la barra de estado
        /// </summary>
        public void actualizarDatosTrack()
        {
            //Si el reproductor esta en play(reproduciendo musica)
            if (reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                macTrackBarTiempo.Maximum = (int)reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();

            }
            //Si el reproductor esta en pausa
            else if (reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                //Se para el timer
                timer1.Stop();
            }
            //Si el reproductor esta en stop
            else if (reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                //Cambiamos el macTrackBar nuestro y lo ponemos en 0
                macTrackBarTiempo.Value = 0;
            }
        }
        /// <summary>
        /// Actualizamos el Mactrack del WindowMediaPlayer del volumen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void macTrackBar2_ValueChanged(object sender, decimal value)
        {
            //Actualizamos el Mactrack del WindowMediaPlayer(volumen) segun el valor de nuestro macTrackBar
            reproductor.settings.volume = macTrackBarVolumen.Value;
        }
        /// <summary>
        /// Cuando esta el reproductor reproduciendose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            actualizarDatosTrack();
        }
        /// <summary>
        /// Buscador por nombre de cancion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            sqlCanciones cancion = new sqlCanciones();
            try
            {
                //Limpiamos todos los registros de la tabla
                tablaCanciones.Rows.Clear();
                //Bucle el cual se recorre por cada vez que cuando hace la sentencia sql encuntra un resultado
                foreach (cancion cn in cancion.buscarPorNombre(new cancion(textBoxBuscador.Text)))
                {
                    //Añadimos a la tabla un objeto el cual contiene los campos(nombre cancion) de la tabla de nuestra base de datos
                    tablaCanciones.Rows.Add(new object[] { cn.getNombre(), cn.getArtista(), cn.getGenero() });
                    Console.WriteLine(cn.getIdCancion());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No funciona el buscador");
            }
        }
        /// <summary>
        /// Filtrado por genero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlCanciones cancion = new sqlCanciones();
            //Guardamos en un string los elementos que seleccionamos en nuestro comboBox
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            try
            {
                //Limpiamos todos los registros de nuestra tabla
                tablaCanciones.Rows.Clear();
                //Bucle el cual se recorre por cada vez que cuando hace la sentencia sql encuntra un resultado
                foreach (cancion cn in cancion.buscarPorGenero(new cancion(selected)))
                {
                    //Añadimos a la tabla un objeto el cual contiene los campos(genero cancion) de la tabla de nuestra base de datos
                    tablaCanciones.Rows.Add(new object[] { cn.getNombre(), cn.getArtista(), cn.getGenero() });
                    Console.WriteLine(cn.getIdCancion());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("No funciona el filtrado");
            }
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Abrimos la ventana de modificacion del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMejorarCuenta_Click(object sender, EventArgs e)
        {
            //Abrimos el formulario para modificar los datos del usuario
            FormCambioDatos fromDatos = new FormCambioDatos(labelUsuario.Text);
            fromDatos.Visible = true;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Le pasamos un usuario a nuestra playlist parseamos y añadimos estos valores a la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button_Click(object sender, EventArgs e)
        {
            playlist play = new playlist();
            sqlPlaylist sqlplay = new sqlPlaylist();

            sqlCanciones cancion = new sqlCanciones();
            string frase;

            play = new playlist(labelUsuario.Text);
            string stringIdCanciones = sqlplay.primeraVez(play);
            //cn = new cancion(stringIdCanciones);
            string[] parsear = stringIdCanciones.Split(' ');
            tablaCanciones.Rows.Clear();
            foreach (string parseado in parsear)
            {
                if(parseado.Equals(""))
                {
                    Console.WriteLine("Este espacio no");
                }
                else
                {
                    frase = parseado;
                    Console.WriteLine("Frase es " + frase);
                    try
                    {
                        if(frase.Equals("") )
                        {
                            MessageBox.Show("The playlist is empty");
                        }
                        else
                        {
                            foreach (cancion cn in cancion.conseguirPlaylist(new cancion(frase)))
                            {
                                tablaCanciones.Rows.Add(new object[] { cn.getNombre(), cn.getArtista(), cn.getGenero() });
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    /* foreach (cancion cn in cancion.buscarPorNombre(new cancion(textBoxBuscador.Text)))
                {
                    //Añadimos a la tabla un objeto el cual contiene los campos(nombre cancion) de la tabla de nuestra base de datos
                    tablaCanciones.Rows.Add(new object[] { cn.getNombre(), cn.getArtista(), cn.getGenero() });
                    Console.WriteLine(cn.getIdCancion());
                }*/
                }


            }


        }
        /// <summary>
        /// Devolvemos un string de las idCanciones de playlist
        /// </summary>
        /// <returns></returns>
        public string stringIdPlaylist()
        {
            sqlPlaylist play = new sqlPlaylist();
            playlist pl = new playlist(labelUsuario.Text);
            return play.primeraVez(pl); 
        }


        /// <summary>
        /// Guardamos en string idCanciones
        /// </summary>
        /// <returns></returns>
        public string stringPlaylist()
        {

            sqlCanciones canciones = new sqlCanciones();
            //Guardamos en string idCanciones de nuestra base de datos
            string nombre = canciones.conseguirIdCancion(new cancion(labelInvisibleNombre.Text));
            string total = nombre;

            return total;
        }

        /// <summary>
        /// Añadimos cancion a la playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAñadirPlaylist_Click(object sender, EventArgs e)
        {
            playlist play = new playlist(labelUsuario.Text);
            sqlPlaylist sqlplay = new sqlPlaylist();
            try
            {
                play = new playlist(labelUsuario.Text);
                play = new playlist(labelUsuario.Text, stringPlaylist());

            }
            catch
            {
                Console.WriteLine("No introduce en playlist");
            }
            //Si no tiene ninguna cancion en la playlist
            Console.WriteLine(buttonAñadirPlaylist.Text);
            
            if (buttonAñadirPlaylist.Text == "ADD TO PLAYLIST")
            {
                if (sqlplay.primeraVez(play) == "")
                {
                    //Insertamos cancion en base de datos
                    sqlplay.InsertarCanciones(play);
                    buttonAñadirPlaylist.Text = "DELETE TO PLAYLIST";
                }
                else
                {
                    sqlplay.actualizarPlaylist(play);
                    buttonAñadirPlaylist.Text = "DELETE TO PLAYLIST";

                    Console.WriteLine("Este usuario ya tiene esta cancion es su playlist");
                }
                
            }
            else
            {
                
                parsearPlaylist2(parsearPlaylist());
                buttonAñadirPlaylist.Text = "ADD TO PLAYLIST";
            }
        }

        /// <summary>
        /// Parseamos la playlist de cada usuario guardando en un string el numero
        /// </summary>
        /// <returns></returns>
        public string parsearPlaylist()
        {

            playlist play = new playlist(labelUsuario.Text);
            sqlPlaylist sqlplay = new sqlPlaylist();
            string frase;
            string total;
            try
            {
                play = new playlist(labelUsuario.Text);
                play = new playlist(labelUsuario.Text, stringPlaylist());
                //Si la sentencia no es null y contiene el string que cogemos de idCanciones 
                if (sqlplay.primeraVez(play) != null && sqlplay.primeraVez(play).Contains(" " + play.getIdCanciones() + " "))
                {
                    frase = stringPlaylist();
                    //Guardamos en array la frase spliteada
                    string[] parsear = frase.Split(' ');
                    foreach (string parseado in parsear)
                    {
                        Console.WriteLine(parseado);
                        total = parseado;
                        Console.WriteLine("El total es " + total);
                        play = new playlist(labelUsuario.Text, total);
                        return total;
                    }

                }
                else
                {
                    Console.WriteLine("No parsea");
                    return "";
                }

            }
            catch
            {
                Console.WriteLine("No introduce en playlist");
                return "";
            }
            return "";

        }
        /// <summary>
        /// Añadimos espacios al idCancion y actualizamos el valor en nuestra base de datos
        /// </summary>
        /// <param name="idCancion"></param>
        /// <returns></returns>
        public bool parsearPlaylist2(string idCancion)
        {

            playlist play = new playlist(labelUsuario.Text);
            sqlPlaylist sqlplay = new sqlPlaylist();
            string frase;
            string total = "";
            
            try
            {
                play = new playlist(labelUsuario.Text);
                play = new playlist(labelUsuario.Text, stringPlaylist());
                //Si la sentencia no es null y contiene el string que cogemos de idCanciones 
                if (sqlplay.primeraVez(play) != null && sqlplay.primeraVez(play).Contains(" " + play.getIdCanciones() + " "))
                {
                    frase = stringIdPlaylist();
                    //Guardamos en array la frase spliteada
                    string[] parsear = frase.Split(' ');
                    foreach (string parseado in parsear)
                    {
                        if (parseado.Equals(idCancion) || parseado.Equals(""))
                        {
                            Console.WriteLine("Este fuera");
                        }
                        else
                        {
                            total += " " + parseado + " " ;
                            Console.WriteLine(total);

                        }
                    }
                    play = new playlist(labelUsuario.Text, total);
                    if (sqlplay.eliminarPlaylist(play))
                    {
                        Console.WriteLine(stringPlaylist());
                        return true;
                    }
                    return false;

                }
                else
                {
                    Console.WriteLine("No parsea");
                    return false;
                }

            }
            catch
            {
                Console.WriteLine("No introduce en playlist");
                return false;
            }
            

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Seleccion de imagen para perfil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxImagenUsuario_DoubleClick(object sender, EventArgs e)
        {

            OpenFileDialog opfdSeleccionar = new OpenFileDialog();
            //Filtros para imagen
            opfdSeleccionar.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            //Seleccion imagen
            opfdSeleccionar.Title = "Select a image";
            //Si le damos a OK en nuestro dialogo de seleccion de la imagen
            if (opfdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                buttonInsertar.Visible = true;
                imgLoc = opfdSeleccionar.FileName.ToString();
                pictureBoxImagenUsuario.ImageLocation = imgLoc;
            }
        }
        
      
        
    /// <summary>
    /// Insertamos la imagen seleccionada y la subimos a nuestra base de datos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e)
        {
            sqlClientes sqlcli = new sqlClientes();
            cliente cli = new cliente();
            byte[] img = null;
            MemoryStream ms = new MemoryStream();
            //Cargamos nuestra imagen en nuestra pictureBox
            pictureBoxImagenUsuario.Image.Save(ms, ImageFormat.Jpeg);
        
            img = ms.ToArray();
            
            //Subimos nuestra imagen a nuestro servidor
            cli = new cliente(labelUsuario.Text, img);
            if (sqlcli.actualizarImagen(cli))
            {
                Console.WriteLine("Insertado con exito");
                buttonInsertar.Visible = false;
            }
            else
            {
                Console.WriteLine("No se ha insertado");
                MessageBox.Show("You cannot upload this image try with another one");
            }

        }

        /// <summary>
        /// Cargamos nuestra foto de perfil
        /// </summary>
        public void fotoPerfil()
        {
            sqlClientes sqlcli = new sqlClientes();
            cliente cli = new cliente();
            cli = new cliente(labelUsuario.Text);
            if (sqlcli.revisionImagen(cli))
            {
                //Cargamos nuestra imagen desde la base de datos
                ms1 = new MemoryStream(sqlcli.imagen(cli));
                ms1.Seek(0, SeekOrigin.Begin);
                //Mostramos la imagen en nuestro pictureBox
                pictureBoxImagenUsuario.Image = Image.FromStream(ms1);
            }
        }
        


        private void pictureBoxImagenUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
       /// <summary>
       /// Accion cuando seleccionamos el textBox
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void textBoxBuscador_Enter(object sender, EventArgs e)
        {
            if (textBoxBuscador.Text == "Search")
            {
                textBoxBuscador.Text = "";
                textBoxBuscador.ForeColor = Color.White;
                textBoxBuscador.UseSystemPasswordChar = false;
            }
        }
        /// <summary>
        /// Accion cuando deseleccionamos el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxBuscador_Leave(object sender, EventArgs e)
        {
            if (textBoxBuscador.Text == "")
            {
                textBoxBuscador.Text = "Search";
                textBoxBuscador.ForeColor = Color.White;
                textBoxBuscador.UseSystemPasswordChar = false;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {

        }



        //INTENTO DE MOVER BARRA DE PROGRESO(NO ES POSIBLE DEBIDO A QUE LA BARRA DE WINDOWS.MEDIAPLAYER SOLO ESTA EN MODO LECTURA)
        /*private void macTrackBarTiempo_ValueChanged(object sender, decimal value)
        {
            reproductor.Ctlcontrols.currentItem.duration = macTrackBarTiempo.Value;
        }*/

    }
}

