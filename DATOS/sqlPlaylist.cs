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
        public void InsertarCanciones(playlist play)
        {
            
            string insertar = "INSERT INTO playlist (usuario,idCanciones,totalCaniones) VALUES (" +
                '"' + play.getUsuario() + '"' + "," +
                '"' +" " + play.getIdCanciones() +" "+'"' + ",1);";
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
        public string primeraVez(playlist play)
        {

            string insertar = "SELECT idCanciones FROM playlist WHERE usuario = '" + play.getUsuario() + "';" ;
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(insertar, conexion);
                string nombre = (string)comand.ExecuteScalar();
                Console.WriteLine(nombre);
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
        /// 
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
        /*public string actualizarPlaylist(playlist play)
        {
            string actualizar = "UPDATE playlist SET idCanciones= CONCAT(idCanciones, '" + " " + play.getIdCanciones() + " " + "') where usuario = '" + play.getUsuario() + "';";
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
        }*/



    }
}
