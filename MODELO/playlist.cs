using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaMain.MODELO
{
    class playlist
    {
        //ATRIBUTOS
        int idPlaylist;
        string usuario;
        string idCanciones;
        int totalCanciones;

        public playlist()
        {

        }
        public playlist(string usuario)
        {
            this.usuario = usuario;
        }
        public playlist(string usuario, string idCanciones)
        {
            
            this.usuario = usuario;
            this.idCanciones = idCanciones;
            /*this.totalCanciones = totalCanciones;
 */       }

        //GETTERS Y SETTERS
        public int getIdPlaylist()
        {
            return idPlaylist;
        }
        public void setIdPlaylist(int idPlayList)
        {
            this.idPlaylist = idPlaylist;
        }
        public String getUsuario()
        {
            return usuario;
        }
        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }
        public string getIdCanciones()
        {
            return idCanciones;
        }
        public void setIdCanciones(string idCanciones)
        {
            this.idCanciones = idCanciones;
        }
        public int getTotalCanciones()
        {
            return totalCanciones;
        }
        public void setTotalCanciones(int totalCanciones)
        {
            this.totalCanciones = totalCanciones;
        }
    }
}
