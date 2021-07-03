using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gpbEmpresario_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnCNPJ.Visible = false;
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            pnCNPJ.Visible = true;

        }

        private void rbSim_Click(object sender, EventArgs e)
        {
            //pnCNPJ.Visible = true;
        }

        private void rbNao_Click(object sender, EventArgs e)
        {
            //pnCNPJ.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo com sucesso!");
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            pnCNPJ.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form2 form = new Form2();
            form.Show();
            
        }
    }
}
