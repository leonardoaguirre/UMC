using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Projeto_Ambientes_visuais
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNome.Checked == true)
            {
                txtPesquisa.ForeColor = Color.Gray;
                txtPesquisa.Text = "Nome...";
                txtPesquisa.Mask = "";
            }
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.ForeColor = Color.Black;
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked == true)
            {
                txtPesquisa.Mask = "000,000,000-00";
            }
        }

        private void rbRG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRG.Checked == true)
            {
                txtPesquisa.Mask = "00,000,000-0";
            }
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {

            atualizarGrids();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pessoa pe = new Pessoa();
            string pes;
            if (rbNome.Checked == true)
            {
                dgvClientes.DataSource = pe.buscarCli(txtPesquisa.Text.Trim(),"nome");
            }else if (rbCPF.Checked == true)
            {
                pes = Regex.Replace(txtPesquisa.Text, "[^0-9a-zA-Z]+", "");
                dgvClientes.DataSource = pe.buscarCli(pes,"cpf");
            }
            else
            {
                pes = Regex.Replace(txtPesquisa.Text, "[^0-9a-zA-Z]+", "");
                dgvClientes.DataSource = pe.buscarCli(pes,"rg");
            }
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Endereco end = new Endereco();
            Celular cel = new Celular();
            Pessoa pes = new Pessoa();
            
            cel.idcli= Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            var lista = new BindingList<Celular>(cel.buscarCelulares());
            dgvCelular.DataSource = lista;

            end.idcli= Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            var lista2 = new BindingList<Endereco>(end.buscarEndereco());
            dgvEndereco.DataSource = lista2;
        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa pe = new Pessoa();
            pe.id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            if (pe.excluir())
            {
                MessageBox.Show("A pessoa de id:"+pe.id+" foi excluida com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                atualizarGrids();
            }
            else
            {
                MessageBox.Show("Opa, aconteceu algum erro tente novamente!","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarCliente alt = new AlterarCliente();
            alt.idcli = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            this.Hide();
            alt.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void atualizarGrids()
        {
            Pessoa pes = new Pessoa();
            Endereco end = new Endereco();
            Celular cel = new Celular();

            var lista = new BindingList<Pessoa>(pes.listarClientes());
            dgvClientes.DataSource = lista;
            var lista2 = new BindingList<Endereco>(end.preencher());
            dgvEndereco.DataSource = lista2;
            var lista3 = new BindingList<Celular>(cel.listarCelulares());
            dgvCelular.DataSource = lista3;

            dgvClientes.AutoResizeColumns();
            dgvEndereco.AutoResizeColumns();
            dgvCelular.AutoResizeColumns();
            dgvClientes.AutoGenerateColumns = false;
            dgvCelular.AutoGenerateColumns = false;
            dgvEndereco.AutoGenerateColumns = false;
        }
    }
}
