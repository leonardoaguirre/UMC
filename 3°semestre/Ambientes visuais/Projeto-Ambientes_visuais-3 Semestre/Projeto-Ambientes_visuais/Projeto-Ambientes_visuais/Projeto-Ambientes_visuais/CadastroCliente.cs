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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            Endereco end = new Endereco();
            cbEstado.DataSource = end.listarEstados();
            cbEstado.DisplayMember = "estado";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != "" && txtEmail.BackColor == Color.White && txtCelular.MaskCompleted == true && txtCPF.MaskCompleted == true && txtRG.MaskCompleted == true && txtCEP.MaskCompleted == true && txtLogradouro.Text != "" && txtNumero.TextLength > 0)
            {
                Pessoa pe = new Pessoa();
                pe.nome = txtNome.Text;
                pe.email = txtEmail.Text;
                pe.cpf = txtCPF.Text;
                pe.rg = txtRG.Text;

                Celular cel = new Celular();
                cel.numero = txtCelular.Text;

                Endereco en = new Endereco();
                en.logradouro = txtLogradouro.Text;
                en.numero = Convert.ToInt32(txtNumero.Text.Trim());
                en.estado = cbEstado.Text;
                en.bairro = txtBairro.Text;
                en.cidade = txtCidade.Text;
                en.cep = txtCEP.Text;

                if (pe.cadastrar() && cel.cadastrar() && en.cadastrar())
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!"+Pessoa.idclifk, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar cliente!"+Pessoa.idclifk, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Dados incorretos, revise os dados e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
