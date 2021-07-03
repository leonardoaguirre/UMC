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
    public partial class ManterCelular : Form
    {
        public int id { get; set; }
        public string acao { get; set; }
        public int idcli { get; set; }
        public ManterCelular()
        {
            InitializeComponent();
        }

        private void ManterCelular_Load(object sender, EventArgs e)
        {
            if (acao == "Novo")
            {
                lblTitulo.Text = acao + " Celular";
            }
            else
            {
                lblTitulo.Text = acao + " Celular";

                Celular cel = new Celular();
                cel.id = this.id;
                cel.buscarUnicoCelular();

                txtCelular.Text = cel.numero;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Celular cel = new Celular();
            cel.id = this.id;
            cel.idcli = this.idcli;
            cel.numero = txtCelular.Text;
            if (txtCelular.MaskCompleted) {
                if (acao == "Novo")
                {

                    cel.cadastrar();
                }
                else
                {
                    cel.alterar();
                }
                MessageBox.Show(acao + " com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dados Incorretos!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
