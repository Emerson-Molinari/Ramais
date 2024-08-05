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
            group_add g = new group_add();
            g.groupName = tb_groupName.Text;

            Connection.setGroup(g);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
