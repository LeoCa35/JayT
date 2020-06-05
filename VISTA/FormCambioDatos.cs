using PantallaMain.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaMain.VISTA
{
    public partial class FormCambioDatos : Form
    {
        sqlClientes sqlcli = new sqlClientes();
        cliente cli = new cliente();
        public FormCambioDatos()
        {
            InitializeComponent();
        }
        public FormCambioDatos(string usuario)
        {
            InitializeComponent();
            textBoxUsuarioActual.Text = usuario;
        }

        private void FormCambioDatos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuarioActual_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Actualizamos datos del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            
            cli = new cliente(textBoxUsuarioActual.Text, textBoxPasswordActual.Text);
            //Actualizamos los datos si coincide el usuario y la contraseña
            if (sqlcli.seleccionPassword(cli))
            {
                if (textBoxPasswordNueva.Text.Length<=7)
                {
                    labelRestricciones.Text = "The password is too short";
                }
                else
                {
                    cli.setPassword(textBoxPasswordNueva.Text);
                    sqlcli.actualizarPassword(cli);
                    labelRestricciones.Text = "Update complete";
                }
                
            }
            else
            {
                labelRestricciones.Text = "The password is incorrect";
            }
            
        }
        /// <summary>
        /// Accion cuando seleccionamos el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPasswordActual_Enter(object sender, EventArgs e)
        {
            if (textBoxPasswordActual.Text == "Password")
            {
                textBoxPasswordActual.Text = "";
                textBoxPasswordActual.ForeColor = Color.White;
                textBoxPasswordActual.UseSystemPasswordChar = true;
            }
        }
        /// <summary>
        /// Accion cuando deseleccionamos el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPasswordActual_Leave(object sender, EventArgs e)
        {
            if (textBoxPasswordActual.Text == "")
            {
                textBoxPasswordActual.Text = "Password";
                textBoxPasswordActual.ForeColor = Color.White;
                textBoxPasswordActual.UseSystemPasswordChar = true;
            }
        }
        /// <summary>
        /// Accion cuando seleccionamos el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPasswordNueva_Enter(object sender, EventArgs e)
        {
            if (textBoxPasswordNueva.Text == "Password")
            {
                textBoxPasswordNueva.Text = "";
                textBoxPasswordNueva.ForeColor = Color.White;
                textBoxPasswordNueva.UseSystemPasswordChar = true;
            }
        }
        /// <summary>
        /// Accion cuando deseleccionamos el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPasswordNueva_Leave(object sender, EventArgs e)
        {
            if (textBoxPasswordNueva.Text == "")
            {
                textBoxPasswordNueva.Text = "Password";
                textBoxPasswordNueva.ForeColor = Color.White;
                textBoxPasswordNueva.UseSystemPasswordChar = true;
            }
        }
    }
}
