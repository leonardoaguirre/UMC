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
    public partial class manterEndereco : Form
    {
        public int id { get; set; }
        public int idcli { get; set; }
        public string acao { get; set; }
        public manterEndereco()
        {
            InitializeComponent();
        }

        private void manterEndereco_Load(object sender, EventArgs e)
        {
            Endereco end = new Endereco();
            cbEstado.DataSource = end.listarEstados();
            cbEstado.DisplayMember = "estado";
            if (acao == "Novo")
            {
                lblTitulo.Text = acao + " Endereco";
            }
            else{
                lblTitulo.Text = acao + " Endereco";

                end.idcli = this.idcli;
                end.buscarEndereco();

                txtCEP.Text = end.cep;
                txtLogradouro.Text = end.logradouro;
                txtNumero.Text = end.numero.ToString();
                txtBairro.Text = end.bairro;
                txtCidade.Text = end.cidade;
                cbEstado.Text = end.estado;
            }      
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco();
            end.id = this.id;
            end.idcli = this.idcli;
            end.numero =Convert.ToInt32(txtNumero.Text);
            end.bairro = txtBairro.Text;
            end.cep = txtCEP.Text;
            end.cidade = txtCidade.Text;
            end.estado = cbEstado.Text;
            end.logradouro = txtLogradouro.Text;
            if (txtCEP.MaskCompleted && txtBairro.TextLength>4 && txtCidade.TextLength>2 && txtLogradouro.TextLength>3 && txtNumero.TextLength>=1)
            {
                if (acao == "Novo")
                {

                    end.cadastrar();
                }
                else
                {
                    end.alterar();
                }
                MessageBox.Show(acao + " com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dados Incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
