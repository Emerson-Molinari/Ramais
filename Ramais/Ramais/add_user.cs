using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
            loader();
        }


        private void loader()
        {
            User_add user_Add = new User_add();
            tb_group.Text = user_Add.group.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ramais r = new ramais();
            User_add user = new User_add();
            user.Name = tb_name.Text;
            user.ramal = tb_ramal.Text;

            Connection.setUser(user,ramais.selectedGroup);
        }
    }
}
