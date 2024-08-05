using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramais
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if(tb_pass.Text == "0009")
            {
                ramais r = new ramais();
                r.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("A senha está errada! tente novamente.");
            }
        }
    }
}
