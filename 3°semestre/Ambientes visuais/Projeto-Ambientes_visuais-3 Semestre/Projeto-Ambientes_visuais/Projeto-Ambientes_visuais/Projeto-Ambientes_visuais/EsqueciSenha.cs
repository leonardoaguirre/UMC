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
    public partial class EsqueciSenha : Form
    {
        public EsqueciSenha()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.ShowDialog();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if(txtCPF.MaskCompleted==true && txtRG.MaskCompleted==true && txtEmail.BackColor==Color.White)
            {
                Usuario us = new Usuario();
                us.usuario = txtEmail.Text;
                us.cpf = txtCPF.Text;
                us.rg = txtRG.Text;
                if (us.procurar())
                {
                    MessageBox.Show("Usuario encontrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecuperarSenha re = new RecuperarSenha();
                    re.usuario = us;
                    this.Hide();
                    re.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Informações inválidas, por favor corrija e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informações inválidas, por favor corrija e tente novamente!", "Erro!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar(txtEmail.Text);
        }
        
    }
}
