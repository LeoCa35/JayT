using MySql.Data.MySqlClient;
using PantallaMain;
using PantallaMain.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PantallaMain
{
    
    public partial class Formregister : Form
    {
        public Formregister()
        {
            InitializeComponent();


        }
        /// <summary>
        /// Boton registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            sqlClientes con = new sqlClientes();
            FormLogin fl = new FormLogin();
            string usuario = textBoxUsuario.Text;
            string password = textBoxPassword.Text;
            string email = textBoxEmail.Text;
                       
            try 
            {
                
                //Cuando la contraseña es menor que 7
                if (password.Length <= 7)
                {
                    labelRestricciones.Text = "The password is too short";
                } else if (!verificarEmail(email))//Cuando el email no es valido
                {
                    labelRestricciones.Text = "Not acceptable email";
                }else if (usuario.Length >= 8)//Cuando el usuario es muy largo
                {
                    labelRestricciones.Text = "The username is too long";
                }
                else if (con.InsertarClientes(new cliente(usuario, password, email))) //Si se cumplen los requisitos
                {
                    fl.Visible = true;
                    Visible = false;
                    
                }
                else
                {
                    labelRestricciones.Text = "This user is alredy register";//Si el usuario ya esta registrado

                }
                
            }
            catch(Exception sida)
            {
                MessageBox.Show("dsadsads");
            }
            
            
        }/// <summary>
        /// Verificacion email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool verificarEmail(string email)
        {
            return Regex.IsMatch(email, @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
        }

        private void Formregister_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
           
                if (textBoxUsuario.Text == "User")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = Color.White;
                textBoxUsuario.UseSystemPasswordChar = false;
            }
        }
        

  

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.White;
                textBoxEmail.UseSystemPasswordChar = false;

            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.White;
                textBoxEmail.UseSystemPasswordChar = false;

            }
        }

        private void textBoxUsuario_Leave_1(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "User";
                textBoxUsuario.ForeColor = Color.White;
                textBoxUsuario.UseSystemPasswordChar = false;

            }
        }

        private void textBoxPassword_Enter_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.White;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.White;
                textBoxPassword.UseSystemPasswordChar = false;

            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin fr = new FormLogin();
            //Me.Hide();
            fr.Visible = true;
            Visible = false;
        }
    }
}
