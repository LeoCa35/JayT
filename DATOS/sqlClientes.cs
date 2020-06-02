using CryptSharp;
using Microsoft.Build.BuildEngine;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using PantallaMain.MODELO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PantallaMain
{
    /// <summary>
    /// Insertamos clientes a la base de datos
    /// </summary>
    class sqlClientes
    {

        MySqlConnection conexion = new MySqlConnection("server=jayt.zapto.org; port=3307; userid=jayt2; password=Admin1234; database=jayt; ");
        byte[] imagenes;
        /// <summary>
        /// Insertamos los datos del usuario en nuestra base datos
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public bool InsertarClientes(cliente cli)
        {
            string passEncriptado = Crypter.Phpass.Crypt(cli.getPassword());
           
            string insertar = "INSERT INTO clientes (usuario,password,email) VALUES (" +
                '"' + cli.getUsuario() + '"' + "," +
                '"' + passEncriptado + '"' + "," +
                '"' + cli.getEmail() + '"' + ");";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(insertar, conexion);
                //Ejecucion comando
                comand.ExecuteNonQuery();

                conexion.Close();
                return true;
            }
            catch (MySqlException excepcion)
            {
                Console.WriteLine(excepcion.ToString());
                return false;
            }



        }
        //Validamos si el usuario existe
        public bool validarUsuario(cliente cli)
        {
            
            string validar = "SELECT * FROM clientes WHERE usuario = '" + cli.getUsuario() + "';";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(validar, conexion);
                //Ejecutamos comando
                comand.ExecuteNonQuery();

                conexion.Close();
                return true;
                

            }
            catch (MySqlException excepcion)
            {
                conexion.Close();
                MessageBox.Show(excepcion.ToString());
                MessageBox.Show("No funciona el validado");
                return false;
            }

        }
        /// <summary>
        /// Buscamos si el password coincide con el usuario
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public bool buscarPorUsuario(cliente cli)
        {
           
            
            cliente client = new cliente(cli.getUsuario(), cli.getPassword());

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("SELECT password FROM clientes WHERE usuario = '" + cli.getUsuario() + "'", conexion);
                Console.WriteLine("conexion");

                Console.WriteLine(cli.getPassword());

                string contraseña = (string)comando.ExecuteScalar();
                bool matches = Crypter.CheckPassword(cli.getPassword(), contraseña);
                Console.WriteLine("Ejecucion query correcta");
                Console.WriteLine(contraseña);
                //Si la contraseña es igual al resultado de la sentencia que nos devuelve
                if (matches/*contraseña.Equals(cli.getPassword())*/)
                {

                    Console.WriteLine(contraseña);
                    Console.WriteLine(cli.getUsuario());
                    conexion.Close();
                    return true;

                }
                else
                {
                    conexion.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo peta");
                return false;
            }

        }
        /// <summary>
        /// Funcion que devuelve un boolean si devuelve la contraseña de ese usuario
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public bool seleccionPassword(cliente cli)
        {
            string seleccion = "SELECT password FROM clientes WHERE usuario = '" + cli.getUsuario() + "' ;";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(seleccion, conexion);
                string contraseña = (string)comand.ExecuteScalar();
                bool matches = Crypter.CheckPassword(cli.getPassword(), contraseña);
                while (matches)
                {
                    conexion.Close();
                    return true;
                }
            }
            catch
            {
                conexion.Close();
                return false;
            }
            conexion.Close();
            return false;
        }


        /// <summary>
        /// Actualizamos el password
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public void actualizarPassword(cliente cli)
        {
            string passEncriptado = Crypter.Phpass.Crypt(cli.getPassword());
            string update = "UPDATE clientes SET password = '" + passEncriptado + "' WHERE usuario = '"+ cli.getUsuario() + "' ;";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(update, conexion);
                comand.ExecuteNonQuery();

                conexion.Close();
                
                //MessageBox.Show("Insertado");

            }
            catch (MySqlException excepcion)
            {
                conexion.Close();
                MessageBox.Show(excepcion.ToString());
                MessageBox.Show("No funciona el Actualizar");
                
            }
        }
        /// <summary>
        /// Actualizamos la imagen de perfil
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public bool actualizarImagen(cliente cli)
        {

            string update = "UPDATE clientes SET imagen = @imagen WHERE usuario = '" + cli.getUsuario() + "';";
            
            try
            {
                conexion.Open();
                
                MySqlCommand comand = new MySqlCommand("UPDATE clientes SET imagen = @imagen WHERE usuario = '" + cli.getUsuario() + "'", conexion);
                //Añadimos parametros a nuestra imagen
                comand.Parameters.AddWithValue("imagen", cli.getImagen());
                comand.ExecuteNonQuery();
                conexion.Close();
                return true;


            }
            catch(MySqlException excepcion)
            {
                Console.WriteLine(excepcion.ToString());
                MessageBox.Show("No funciona el insertar la imagen");
                conexion.Close();
                return false;
            }
        }
        /// <summary>
        /// Devolvemos la imagen
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public byte[] imagen(cliente cli)
        {

            string consultaSql = "SELECT imagen FROM clientes WHERE usuario = '" + cli.getUsuario() + "'";

            MySqlCommand comand;
            MySqlDataReader comando;
            
            try
            {
                conexion.Open();
                comand = new MySqlCommand(consultaSql, conexion);
                comando = comand.ExecuteReader();



                if (comando.Read())
                {
                    imagenes = (byte[])comando["imagen"];
                    


                }
                conexion.Close();
                comando.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return imagenes;
        }
        /// <summary>
        /// Revisamos si existe la imagen en la base de datos
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public bool revisionImagen(cliente cli)
        {
            string consultaSql = "SELECT imagen FROM clientes WHERE usuario = '"+cli.getUsuario()+"'  AND imagen IS NOT NULL";
            Console.WriteLine(cli.getUsuario());
            MySqlCommand comand;
            MySqlDataReader comando;

            try
            {
                conexion.Open();
                comand = new MySqlCommand(consultaSql, conexion);
                comando = comand.ExecuteReader();



                if (comando.Read())
                {
                    
                    conexion.Close();
                    return true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                conexion.Close();
                return false;
            }
            conexion.Close();
            return false;
        }
    }
}
