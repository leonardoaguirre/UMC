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
    public partial class Form2 : Form
    {
        bool devePintar=false;
        public Form2()
        {
            InitializeComponent();
        }

        private void MouseEvents_MouseMove(object sender, MouseEventArgs e)
        {
            if (devePintar)
            {
                Graphics grap = CreateGraphics();
                grap.FillEllipse(new SolidBrush(Color.BlueViolet),e.X,e.Y,4,4);
            }
        }

        private void MouseEvents_MouseDown(object sender, MouseEventArgs e)
        {
            devePintar = true;
        }

        private void MouseEvents_MouseUp(object sender, MouseEventArgs e)
        {
            devePintar = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
