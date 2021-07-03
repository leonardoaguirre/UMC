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
    public partial class CadastroTurmas : Form
    {
        public CadastroTurmas()
        {
            InitializeComponent();
        }

        private void CadastroTurmas_Load(object sender, EventArgs e)
        {
            Turmas objTurmas = new Turmas();
            cbxCurso.DataSource = objTurmas.listarCursos();
            cbxCurso.DisplayMember = "curso";
            cbxCurso.ValueMember = "id";

            cbxPeriodo.DataSource = objTurmas.listarPeriodos();
            cbxPeriodo.DisplayMember = "periodo";
            cbxCurso.ValueMember = "id";
        }
    }
}
