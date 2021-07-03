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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void ckbSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSenha.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenhaConfirma.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                txtSenhaConfirma.UseSystemPasswordChar = true;
            }
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            txtSenhaConfirma.UseSystemPasswordChar = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.usuario = txtEmail.Text;
            usu.senha = txtSenha.Text;
            usu.nome = txtNome.Text;
            usu.rg = txtRG.Text;
            usu.cpf = txtCPF.Text;

            if (txtSenha.Text == txtSenhaConfirma.Text && txtEmail.BackColor == Color.White && txtNome.TextLength>3 && txtCPF.MaskCompleted && txtRG.MaskCompleted)
            {
                if (usu.cadastrar())
                {
                    this.Close();
                    MessageBox.Show("Dados cadastratados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!", "Erros com dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Os dados cadastrais estão incorretos!", "Erros com dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
