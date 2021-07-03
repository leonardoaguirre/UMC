using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_login17_04
{
    public partial class Login : Form
    {
        public ToolStripMenuItem itemcadstros { get; set; }
        public ToolStripMenuItem itemlogin { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario objusuario = new Usuario();
            objusuario.email = txtEmail.Text;
            objusuario.senha = txtSenha.Text;

            if (objusuario.logar())
            {
                itemcadstros.Visible = true;
                itemlogin.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário invalido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
