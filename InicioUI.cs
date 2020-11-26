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
    
    public partial class InicioUI : Form
    {
        private MenuPrincipal menuPrincipal;

        public InicioUI()
        {
            InitializeComponent();
            menuPrincipal = new MenuPrincipal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text;
            if(contraseña.Length != 0)
            {
                if (contraseña.Equals("123"))
                {
                    menuPrincipal.Show();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
