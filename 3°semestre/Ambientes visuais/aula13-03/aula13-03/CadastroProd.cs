using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula13_03
{
    public partial class CadastroProd : Form
    {
        public CadastroProd()
        {
            InitializeComponent();
        }

        private void CadastroProd_Load(object sender, EventArgs e)
        {
            Departamento objDep = new Departamento();
            cbxDepartamento.DataSource = objDep.listar();
            cbxDepartamento.DisplayMember = "descricao";
            cbxDepartamento.ValueMember = "id";
        }
    }
}
