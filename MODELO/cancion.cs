using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaMain.MODELO
{
    class cancion
    {
        //ATRIBUTOS

        int idCancion;
        string nombre;
        string artista;
        DateTime duracion;
        string genero;
        byte imagen;


        //CONSRUCTOR
        public cancion()
        {

        }
        public cancion(string nombre)
        {
            this.nombre = nombre;
            
        }
        /*public cancion(string genero)
        {
            this.genero = genero;
        }*/
        public cancion(int idCancion, string nombre, string artista,  string genero)
        {
            this.idCancion = idCancion;
            this.nombre = nombre;
            this.artista = artista;
            this.genero = genero;
            
        }
        public cancion(int idCancion, string nombre, string artista, string genero, byte imagen)
        {
            this.idCancion = idCancion;
            this.nombre = nombre;
            this.artista = artista;
            this.genero = genero;
            this.imagen = imagen;

        }

        //GETTERS Y SETTERS

        public int getIdCancion()
        {
            return idCancion;
        }
        public void setIdCliente(int idCancion)
        {
            this.idCancion = idCancion;
        }
        
        public String getNombre()
        {
            return nombre;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getArtista()
        {
            return artista;
        }
        public void setArtista(String artista)
        {
            this.artista = artista;
        }
        public DateTime getDuracion()
        {
            return duracion;
        }
        public void setDuracion(DateTime duracion)
        {
            this.duracion = duracion;
        }
        public string getGenero()
        {
            return genero;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }
        public byte getImagen()
        {
            return imagen;
        }
        public void setImagen(byte imagen)
        {
            this.imagen = imagen;
        }



    }
}
