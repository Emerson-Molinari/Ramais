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
            try
            {
                if(tb_group.Text == "999")
                {
                    MessageBox.Show("Este Não é um grupo válido, Favor selecionar outro");
                    Close();
                    return;
                }
                Connection.Set("INSERT INTO r_user (name,ramal,u_group) values ('" + tb_name.Text + "','" + tb_ramal.Text + "','" + tb_group.Text + "')");
                MessageBox.Show("Usuário Definido");
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao definir o Usuário!" + ex);
            }


        }
    }
}
