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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroUsuario cad = new CadastroUsuario();
            cad.ShowDialog();
        }

        private void timer1Segundo_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = (DateTime.Now.ToLongTimeString());
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblTempo.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();

            pnMenu.BackgroundImage = Properties.Resources._1;
            lbUsu.Text = Usuario.nomeUsu+" !";
        }

        private void timer15segundos_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int n = ran.Next(1, 10);

            switch (n) { 
            case 1: pnMenu.BackgroundImage = Properties.Resources._1; break;
            case 2: pnMenu.BackgroundImage = Properties.Resources._2; break;
            case 3: pnMenu.BackgroundImage = Properties.Resources._3; break;
            case 4: pnMenu.BackgroundImage = Properties.Resources._4; break;
            case 5: pnMenu.BackgroundImage = Properties.Resources._5; break;
            case 6: pnMenu.BackgroundImage = Properties.Resources._6; break;
            case 7: pnMenu.BackgroundImage = Properties.Resources._7; break;
            case 8: pnMenu.BackgroundImage = Properties.Resources._8; break;
            case 9: pnMenu.BackgroundImage = Properties.Resources._9; break;
            case 10: pnMenu.BackgroundImage = Properties.Resources._10; break;
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cad = new CadastroCliente();
            cad.ShowDialog();
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer15segundos.Enabled = false;
            timer1Segundo.Enabled = false;
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void lblTempo_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCliente con = new ConsultaCliente();
            con.ShowDialog();
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            consultaUsuario con = new consultaUsuario();
            con.ShowDialog();
        }
    }
}
