using PantallaMain.MODELO;
using PantallaMain.DATOS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using Microsoft.SqlServer.Server;

namespace PantallaMain.DATOS
{
    class sqlCanciones
    {
		List<cancion> guardarCanciones;
		MySqlDataAdapter da;
		byte[] imagenes;
		MySqlConnection conexion = new MySqlConnection("server=jayt.zapto.org; port=3307; userid=jayt2; password=Admin1234; database=jayt; ");
		string nombre, artista, genero;
		/// <summary>
		/// Devolvemos array el cual tienen nuestras canciones 
		/// </summary>
		/// <param name="nombreTabla"></param>
		/// <returns></returns>
		public List<cancion> guardarEnTabla(string nombreTabla)
		{
			guardarCanciones = new List<cancion>();
			
			string consultaSql = "SELECT * FROM " + nombreTabla ;
			cancion canciones;
			try
			{
				conexion.Open();
				MySqlCommand comand = new MySqlCommand(consultaSql, conexion);
				MySqlDataReader comando = comand.ExecuteReader();
				//Si hay contenido en la sentencia
				while(comando.Read())
				{
					//Cogemos contenido y lo guardamos en el objecto cancion
					canciones = new cancion((int)comando[0],string.Format("{0}",comando[1]), string.Format("{0}", comando[2]), string.Format("{0}", comando[3]));
					guardarCanciones.Add(canciones);
					Console.WriteLine(string.Format("{0}", comando[1]));
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
			Console.WriteLine(guardarCanciones.ToString());
			return guardarCanciones;
		}
		/// <summary>
		/// Devolvemos imagenes
		/// </summary>
		/// <param name="nombreCancion"></param>
		/// <returns></returns>
		public byte[] imagen(string nombreCancion)
		{
			
			string consultaSql = "SELECT imagen FROM cancion WHERE nombre = '" + nombreCancion+ "'" ;
			MySqlCommand comand;
			MySqlDataReader comando;
			try
			{
				conexion.Open();
				comand = new MySqlCommand(consultaSql, conexion);
				comando = comand.ExecuteReader();
				
				DataTable table = new DataTable();

				//Si hay contenido en la base de datos
				if (comando.Read())
				{
					imagenes = (byte[])comando["imagen"];
					Console.WriteLine("comando es: " + imagenes[0]);

					
				}
				conexion.Close();
				comando.Close();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
			return imagenes;
		}

		/// <summary>
		/// Buscamos por el nombre de la cancion y devolvemos array con el resultado
		/// </summary>
		/// <param name="cn"></param>
		/// <returns></returns>
		public List<cancion> buscarPorNombre(cancion cn)
		{
			
			string consultaSql = "SELECT * FROM cancion WHERE nombre LIKE '%" + cn.getNombre() + "%';";
			guardarCanciones = new List<cancion>();
			try
			{
				conexion.Open();
				MySqlCommand comand = new MySqlCommand(consultaSql, conexion);
				MySqlDataReader comando = comand.ExecuteReader();
				while (comando.Read())
				{
					nombre = comando.GetString("nombre");
					artista = comando.GetString("artista");
					genero = comando.GetString("genero");

					guardarCanciones.Add(new cancion((int)comando[0], string.Format("{0}", comando[1]), string.Format("{0}", comando[2]), string.Format("{0}", comando[3])));
				}
				conexion.Close();
				comando.Close();
			}
			
			catch(Exception ex)
			{
				Console.WriteLine("Esto falla " + ex);
			}
			return guardarCanciones;
		}

		/// <summary>
		/// Buscamos por genero de cancion y devolvemos array
		/// </summary>
		/// <param name="cn"></param>
		/// <returns></returns>
		public List<cancion> buscarPorGenero(cancion cn)
		{
			
			string consultaSql = "SELECT * FROM cancion WHERE genero LIKE '" + cn.getNombre() + "';";
			guardarCanciones = new List<cancion>();
			try
			{
				conexion.Open();
				MySqlCommand comand = new MySqlCommand(consultaSql, conexion);
				MySqlDataReader comando = comand.ExecuteReader();
				while (comando.Read())
				{
					nombre = comando.GetString("nombre");
					artista = comando.GetString("artista");
					genero = comando.GetString("genero");

					guardarCanciones.Add(new cancion((int)comando[0], string.Format("{0}", comando[1]), string.Format("{0}", comando[2]), string.Format("{0}", comando[3])));
				}
				conexion.Close();
				comando.Close();
			}

			catch (Exception ex)
			{
				Console.WriteLine("Esto falla " + ex);
			}
			return guardarCanciones;
		}
		/// <summary>
		/// Devolvemos una array de los resultados de la idCancion de ese usuario
		/// </summary>
		/// <param name="cn"></param>
		/// <returns></returns>
		public List<cancion> conseguirPlaylist(cancion cn)
		{

			string consultaSql = "SELECT * FROM cancion WHERE idCancion = " + cn.getNombre() + ";";/*cn.getNombre() equivale al idCancion*/
			guardarCanciones = new List<cancion>();
			try
			{
				conexion.Open();
				MySqlCommand comand = new MySqlCommand(consultaSql, conexion);
				MySqlDataReader comando = comand.ExecuteReader();
				while (comando.Read())
				{
					nombre = comando.GetString("nombre");
					artista = comando.GetString("artista");
					genero = comando.GetString("genero");
					if (comando.Equals(""))
					{
						Console.WriteLine("Por aqui no paso");
					}
					else 
					{ 
					guardarCanciones.Add(new cancion((int)comando[0], string.Format("{0}", comando[1]), string.Format("{0}", comando[2]), string.Format("{0}", comando[3])));
					}
				}
				conexion.Close();
				comando.Close();
			}

			catch (Exception ex)
			{
				Console.WriteLine("Esto falla " + ex);
			}
			return guardarCanciones;
		}

		/// <summary>
		/// Guardamos un string de idCanion
		/// </summary>
		/// <param name="cn"></param>
		/// <returns></returns>
		public string conseguirIdCancion(cancion cn)
		{
			string consultaSql = "SELECT idCancion FROM cancion WHERE nombre LIKE '" + cn.getNombre() + "';";
			try
			{
				conexion.Open();
				MySqlCommand comand = new MySqlCommand(consultaSql, conexion);


				string nombre = comand.ExecuteScalar().ToString();
				Console.WriteLine(nombre);

				return nombre;
			}
			catch(Exception ex)
			{
				Console.WriteLine("No consigue el nombre de la cancion");
				return null;

			}
		}

		
	}
}
