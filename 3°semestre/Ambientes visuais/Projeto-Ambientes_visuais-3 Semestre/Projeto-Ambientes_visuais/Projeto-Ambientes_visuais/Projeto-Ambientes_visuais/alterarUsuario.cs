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

namespace Projeto_Ambientes_visuais
{
    public partial class alterarUsuario : Form
    {
        public alterarUsuario()
        {
            InitializeComponent();
        }
        public int id { get; set; }

        private void alterarUsuario_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.id = this.id;
            us.preencher();
            txtNome.Text = us.nome;
            txtEmail.Text = us.usuario;
            txtEmail.BackColor = Color.White;
            txtRG.Text = us.rg;
            txtCPF.Text = us.cpf;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar(txtEmail.Text);
        }
        public void verificar(string email)
        {
            Regex re = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match ma = re.Match(email);
            if (ma.Success)
            {
                txtEmail.BackColor = Color.White;
            }
            else
            {
                txtEmail.BackColor = Color.Red;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.id = this.id;
            us.nome = txtNome.Text;
            us.usuario = txtEmail.Text;
            us.rg = txtRG.Text;
            us.cpf = txtCPF.Text;
            if (us.alterar())
            {
                consultaUsuario cons = new consultaUsuario();
                MessageBox.Show("Usuario alterado com sucesso!", "Confirmado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                cons.ShowDialog();
            }
            else
            {
                MessageBox.Show("Algo de errado aconteceu!", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
