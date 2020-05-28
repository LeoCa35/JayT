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
				while(comando.Read())
				{
					canciones = new cancion((int)comando[0],string.Format("{0}",comando[1]), string.Format("{0}", comando[2]), string.Format("{0}", comando[4]));
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

					guardarCanciones.Add(new cancion((int)comando[0], string.Format("{0}", comando[1]), string.Format("{0}", comando[2]), string.Format("{0}", comando[4])));
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

					guardarCanciones.Add(new cancion((int)comando[0], string.Format("{0}", comando[1]), string.Format("{0}", comando[2]), string.Format("{0}", comando[4])));
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
				//nombre = comando.GetString("idCancion");
			}
			catch(Exception ex)
			{
				Console.WriteLine("No consigue el nombre de la cancion");
				return null;

			}
		}

		
	}
}
