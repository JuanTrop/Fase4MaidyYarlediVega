using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4MaidyYarlediVega
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEscenario1_Click(object sender, EventArgs e)
        {
            Escenario1 escenario1 = new Escenario1();

            escenario1.Show();
        }
    }
}
