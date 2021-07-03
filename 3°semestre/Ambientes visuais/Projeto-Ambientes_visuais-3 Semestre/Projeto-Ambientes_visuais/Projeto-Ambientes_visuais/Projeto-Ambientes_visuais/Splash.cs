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

    public partial class Splash : Form
    {
        
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
            timer1.Enabled = false;
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
