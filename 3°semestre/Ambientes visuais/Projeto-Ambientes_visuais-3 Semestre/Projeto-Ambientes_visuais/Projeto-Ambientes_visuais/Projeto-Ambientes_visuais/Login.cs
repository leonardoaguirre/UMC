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
using Npgsql; 

namespace Projeto_Ambientes_visuais
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "Usuário";
            txtSenha.Text = "Senha";

            txtSenha.ForeColor = Color.Gray;
            txtLogin.ForeColor = Color.Gray;          
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.usuario = txtLogin.Text;
            usu.senha = txtSenha.Text;

            if (usu.logar())
            {
                this.Hide();
                Menu mn = new Menu();
                mn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro! Usuário e senha incorretos!", "Erro de login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Usuário";
                txtLogin.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Usuário")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.Black;
            }
        }

        private void lblEsqueci_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EsqueciSenha es = new EsqueciSenha();
            es.ShowDialog();
            
        }
        public void verificar(string email)
        {
            Regex re = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match ma = re.Match(email);
            if (ma.Success)
            {
                txtLogin.BackColor = Color.White;
            }
            else
            {
                txtLogin.BackColor = Color.Red;
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar(txtLogin.Text);
        }
    }
}
