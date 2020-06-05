using MySql.Data.MySqlClient;
using System;
using PantallaMain.MODELO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PantallaMain.DATOS;

namespace PantallaMain
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //this.Icon = Properties.Resources.Address_Book;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Validamos si el usuario y la contraseña son correctos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            sqlClientes con = new sqlClientes();
            string usuario = textBoxUsuario.Text;
            string password = textBoxPassword.Text;
            FormPrincipal fprincipal = new FormPrincipal(usuario);
            Boolean entrada;
            cliente cli = new cliente(usuario, password);
            sqlCanciones cancion = new sqlCanciones();
            
           try
            {
                
                entrada = con.buscarPorUsuario(cli);

                if (entrada)
                {
                    fprincipal.Visible = true;
                    this.Hide();
                }
                else
                {
                    labelRestricciones.Text = "Incorrect username or password";
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("no va");
            }
           

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Nos lleva a la pantalla register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formregister fr = new Formregister();
            //Me.Hide();
            fr.Visible = true;
            Visible = false;
            

            //Formregister.Show();
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.White;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.White;
                textBoxPassword.UseSystemPasswordChar = false;

            }
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

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "User";
                textBoxUsuario.ForeColor = Color.White;
                textBoxUsuario.UseSystemPasswordChar = false;

            }
        }
    }
}
