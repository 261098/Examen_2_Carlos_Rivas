using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datosexamen;
using Datosexamen.Accesos;
using Datosexamen.Entidades;

namespace Examen_2_Carlos_Rivas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingresarbutton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuarios usuario = new Usuarios();

            usuario = usuarioDA.Login(UsuariotextBox.Text, ClavetextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }
            else if (!usuario.Estado)
            {
                MessageBox.Show("Usuario Inactivo");
                return;
            }

            FrmMenu frmMenu = new FrmMenu();
             frmMenu.Show();
            this.Hide();


        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
    

