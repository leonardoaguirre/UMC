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
    public partial class consultaUsuario : Form
    {
        public consultaUsuario()
        {
            InitializeComponent();
        }

        private void consultaUsuario_Load(object sender, EventArgs e)
        {
            atualizarGrids();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
            if (us.excluir())
            {
                MessageBox.Show("A pessoa de id:" + us.id + " foi excluida com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                atualizarGrids();
            }
            else
            {
                MessageBox.Show("Opa, aconteceu algum erro tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void atualizarGrids()
        {
            Usuario us = new Usuario();

            var lista = new BindingList<Usuario>(us.listarUsuarios());
            dgvUsuarios.DataSource = lista;

            dgvUsuarios.AutoResizeColumns();

            dgvUsuarios.AutoGenerateColumns = false;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarUsuario alt = new alterarUsuario();
            this.Hide();
            alt.id= Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
            alt.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            string pes;
            if (rbNome.Checked == true)
            {
                dgvUsuarios.DataSource = us.buscarUsuario(txtPesquisa.Text.Trim(), "nome");
            }
            else if (rbCPF.Checked == true)
            {
                pes = Regex.Replace(txtPesquisa.Text, "[^0-9a-zA-Z]+", "");
                dgvUsuarios.DataSource = us.buscarUsuario(pes, "cpf");
            }
            else
            {
                pes = Regex.Replace(txtPesquisa.Text, "[^0-9a-zA-Z]+", "");
                dgvUsuarios.DataSource = us.buscarUsuario(pes, "rg");
            }
        }

        private void rbRG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRG.Checked == true)
            {
                txtPesquisa.Mask = "00,000,000-0";
            }
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked == true)
            {
                txtPesquisa.Mask = "000,000,000-00";
            }
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

        private void txtPesquisa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.ForeColor = Color.Black;
        }
    }
}
