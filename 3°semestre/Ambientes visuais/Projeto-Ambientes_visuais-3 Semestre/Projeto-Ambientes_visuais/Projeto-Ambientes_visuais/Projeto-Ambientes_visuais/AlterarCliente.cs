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
    public partial class AlterarCliente : Form
    {
        public AlterarCliente()
        {
            InitializeComponent();
        }
        public int idcli { get; set; }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            pes.id = this.idcli;
            pes.nome=txtNome.Text;
            pes.email=txtEmail.Text;
            pes.rg=txtRG.Text;
            pes.cpf=txtCPF.Text;

            if (pes.alterar())
            {
                ConsultaCliente cons = new ConsultaCliente();
                MessageBox.Show("Cliente alterado com sucesso!", "Confirmado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ConsultaCliente con = new ConsultaCliente();
            this.Hide();
            con.ShowDialog();
            
        }

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            pes.id = this.idcli;
            pes.preencher();

            txtNome.Text=pes.nome;
            txtEmail.Text=pes.email;
            txtRG.Text=pes.rg;
            txtCPF.Text=pes.cpf;

            atualizaGrids();
        }
        public void atualizaGrids()
        {
            Endereco end = new Endereco();
            Celular cel = new Celular();

            cel.idcli= this.idcli;
            var lista = new BindingList<Celular>(cel.buscarCelulares());
            dgvCelular.DataSource = lista;

            end.idcli = this.idcli;
            var lista2 = new BindingList<Endereco>(end.buscarEndereco());
            dgvEndereco.DataSource = lista2;
        }

        private void btnExcluirEnde_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco();
            end.id = this.idcli;
            if (end.excluir())
            {
                MessageBox.Show("Endereço excluido com sucesso!", "Confirmado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaGrids();
            }
            else
            {
                MessageBox.Show("Algo de errado aconteceu!", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirCel_Click(object sender, EventArgs e)
        {
            Celular cel = new Celular();
            cel.id = this.idcli;
            if (cel.excluir())
            {
                MessageBox.Show("Celular excluido com sucesso!", "Confirmado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaGrids();
            }
            else
            {
                MessageBox.Show("Algo de errado aconteceu!", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoEnde_Click(object sender, EventArgs e)
        {
            manterEndereco ma = new manterEndereco();
            ma.acao = "Novo";
            Pessoa.idclifk = this.idcli;
            ma.ShowDialog();

        }

        private void btnNovoCel_Click(object sender, EventArgs e)
        {
            ManterCelular ma = new ManterCelular();
            ma.acao = "Novo";
            Pessoa.idclifk = this.idcli;
            ma.ShowDialog();
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

        private void btnAlterarEndereco_Click(object sender, EventArgs e)
        {
            manterEndereco ma = new manterEndereco();
            ma.acao = "Alterar";
            ma.id = Convert.ToInt32(dgvEndereco.CurrentRow.Cells[0].Value);
            ma.ShowDialog();
        }

        private void btnAlterarCelular_Click(object sender, EventArgs e)
        {
            ManterCelular ma = new ManterCelular();
            ma.acao = "Alterar";
            ma.id = Convert.ToInt32(dgvCelular.CurrentRow.Cells[0].Value);
            ma.ShowDialog();
        }

        private void AlterarCliente_Activated(object sender, EventArgs e)
        {
            atualizaGrids();
        }

    }
}
