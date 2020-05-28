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
namespace PantallaMain
{
    class sqlClientes
    {
        MySqlConnection conexion = new MySqlConnection("server=jayt.zapto.org; port=3307; userid=jayt2; password=Admin1234; database=jayt; ");
        byte[] imagenes;
        public bool InsertarClientes(cliente cli)
        {
           
            string insertar = "INSERT INTO clientes (usuario,password,email) VALUES (" +
                '"' + cli.getUsuario() + '"' + "," +
                '"' + cli.getPassword() + '"' + "," +
                '"' + cli.getEmail() + '"' + ");";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(insertar, conexion);
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
        public bool validarUsuario(cliente cli)
        {
            
            string validar = "SELECT * FROM clientes WHERE usuario = '" + cli.getUsuario() + "';";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(validar, conexion);
                comand.ExecuteNonQuery();

                conexion.Close();
                return true;
                //MessageBox.Show("Insertado");

            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                MessageBox.Show("No funciona el validado");
                return false;
            }

        }
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
                Console.WriteLine("Ejecucion query correcta");
                Console.WriteLine(contraseña);
                if (contraseña.Equals(cli.getPassword()))
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
        public bool actualizarPassword(cliente cli)
        {
            string update = "UPDATE clientes SET password = '" + cli.getEmail() + "' WHERE usuario = '" + cli.getUsuario() + "' AND password = '" + cli.getPassword() + "';";
            try
            {
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(update, conexion);
                comand.ExecuteNonQuery();

                conexion.Close();
                return true;
                //MessageBox.Show("Insertado");

            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                MessageBox.Show("No funciona el Actualizar");
                return false;
            }
        }
        public bool actualizarImagen(cliente cli)
        {

            string update = "UPDATE clientes SET imagen = @imagen WHERE usuario = '" + cli.getUsuario() + "';";
            //string insertar = "INSERT INTO clientes (usuario,password,email,imagen) VALUES ('l','l','l', "+cli.getImagen() +" )"
            try
            {
                conexion.Open();
                
                MySqlCommand comand = new MySqlCommand("UPDATE clientes SET imagen = @imagen WHERE usuario = '" + cli.getUsuario() + "'", conexion);
                comand.Parameters.AddWithValue("imagen", cli.getImagen());
                comand.ExecuteNonQuery();
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
