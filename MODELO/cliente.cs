using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaMain.MODELO
{
    class cliente
    {
        //ATRIBUTOS
        string usuario;
        string email;
        string password;
        byte[] imagen;
        


        //CONSTRUCTOR
        public cliente()
        {

        }
        public cliente(string usuario)
        {
            this.usuario = usuario;
        }
        public cliente(string usuario, byte[] imagen)
        {
            this.usuario = usuario;
            this.imagen = imagen;
        }

        public cliente(string usuario, string password, string email)
        {
            this.usuario = usuario;
            this.password = password;
            this.email = email;
        }
        
        public cliente(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }



        //GETTERS Y SETTERS
        public String getUsuario()
        {
            return usuario;
        }
        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }
        public String getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getPassword()
        {
            return password;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public byte[] getImagen()
        {
            return imagen;
        }
        public void setImagen(byte[] imagen)
        {
            this.imagen = imagen;
        }
    }
}
