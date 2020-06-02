using MySql.Data.MySqlClient;
using PantallaMain.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaMain.DATOS
{
    class sqlPlaylist
    {
        MySqlConnection conexion = new MySqlConnection("server=jayt.zapto.org; port=3307; userid=jayt2; password=Admin1234; database=jayt; ");

        /// <summary>
        /// Insertar playlist
        /// </summary>
        /// <param name="play"></param>
        public void InsertarCanciones(playlist play)
        {
            
            string insertar = "INSERT INTO playlist (usuario,idCanciones) VALUES (" +
                '"' + play.getUsuario() + '"' + "," +
                '"' +" " + play.getIdCanciones() +" "+'"' + ");";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(insertar, conexion);
                comand.ExecuteNonQuery();
                conexion.Close();
                
            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                MessageBox.Show("No funciona Insertado");
               
            }
        }
        /// <summary>
        /// Seleccionamos idCanciones 
        /// </summary>
        /// <param name="play"></param>
        /// <returns></returns>
        public string primeraVez(playlist play)
        {

            string insertar = "SELECT idCanciones FROM playlist WHERE usuario = '" + play.getUsuario() + "';" ;
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(insertar, conexion);
                string nombre = (string)comand.ExecuteScalar();
                Console.WriteLine(nombre);
                if (nombre == null)
                {
                    conexion.Close();
                    return "";
                }
                conexion.Close();
                return nombre;

            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                MessageBox.Show("No funciona Insertado");
                return null;

            }
        }

        /// <summary>
        /// Actualizamos idCanciones
        /// </summary>
        /// <param name="play"></param>
        /// <returns></returns>
        public string actualizarPlaylist(playlist play)
        {
            string actualizar = "UPDATE playlist SET idCanciones= CONCAT(idCanciones, '"  +" "+ play.getIdCanciones()+" "+ "') where usuario = '"+ play.getUsuario()+"';";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(actualizar, conexion);
                string playlist = (string)comand.ExecuteScalar();
                Console.WriteLine(playlist);
                return playlist;


            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                MessageBox.Show("No funciona Insertado");
                return null;

            }
        }
        /// <summary>
        /// Actualizamos idCanciones y lo devolvemos
        /// </summary>
        /// <param name="play"></param>
        /// <returns></returns>
        public string actualizarPlaylist2(playlist play)
        {
            string actualizar = "UPDATE playlist SET idCanciones= '"+play.getIdCanciones()+"' where usuario = '" + play.getUsuario() + "';";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(actualizar, conexion);
                string playlist = (string)comand.ExecuteScalar();
                Console.WriteLine(playlist);
                return playlist;


            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                MessageBox.Show("No funciona Insertado");
                return null;

            }
        }
        /// <summary>
        /// Eliminamos cancion de idCanciones
        /// </summary>
        /// <param name="play"></param>
        /// <returns></returns>
        public bool eliminarPlaylist(playlist play)
        {
            string actualizar = "UPDATE playlist SET idCanciones =  '"+ play.getIdCanciones() +"' where usuario = '" + play.getUsuario() + "';";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(actualizar, conexion);
                string playlist = (string)comand.ExecuteScalar();
                Console.WriteLine(playlist);
                return true;


            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                MessageBox.Show("No funciona Insertado");
                return false;

            }
        }



    }
}
