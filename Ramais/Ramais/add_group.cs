using Npgsql;
using Ramais.scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ramais
{
    public partial class add_group : Form
    {
        public add_group()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Set("INSERT INTO r_group (name) values ('" + tb_groupName.Text + "')");
                MessageBox.Show("Criado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao criar o grupo!" + ex);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
