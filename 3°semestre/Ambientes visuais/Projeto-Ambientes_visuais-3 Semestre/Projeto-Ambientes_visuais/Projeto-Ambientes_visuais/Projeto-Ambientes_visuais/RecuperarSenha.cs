using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Ambientes_visuais
{
    public partial class RecuperarSenha : Form
    {
        public Usuario usuario { get; set; }
        public RecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtSenhaConfirma.Text)
            {
                usuario.senha = txtSenha.Text;
                usuario.recuperar();

                MessageBox.Show("Dados cadastratados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
            }
            else
            {
                MessageBox.Show("As senhas não estão iguais!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void RecuperarSenha_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            txtSenhaConfirma.UseSystemPasswordChar = true;
        }
    }
}
