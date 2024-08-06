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

namespace Ramais
{
    public partial class F_principal : Form
    {
        public static int selectedGroup = 999;

        public F_principal()
        {
            InitializeComponent();
            reloadUsers();
            reloadGroups();
        }

        private void reloadGroups()
        {
            Connection.Get("select name,id from r_group");
            dgv_groups.DataSource = Connection.getList;

            if (dgv_groups.Rows.Count == 0)
            {
                return;
            }
            else
            {
                dgv_groups.Columns[0].Width = 280;
                dgv_groups.Columns[1].Visible = false;
            }
        }

        public void reloadUsers()
        {
            if (selectedGroup == 999)
            {
                Connection.Get("select name,ramal,id from r_user");

                dgv_users.DataSource = Connection.getList;
                dgv_users.Columns[0].Width = 200;
                dgv_users.Columns[1].Width = 80;
                dgv_users.Columns[2].Visible = false;
                dgv_users.Sort(dgv_users.Columns[0], ListSortDirection.Ascending);

            }

            Connection.Get("select name,ramal,id from r_user where u_group  =" + selectedGroup);
            dgv_users.DataSource = Connection.getList;
            
            if(dgv_groups.Rows.Count == 0)
            {
                return;
            }
            else
            {
            dgv_users.Columns[0].Width = 200;
            dgv_users.Columns[1].Width = 80;
            dgv_users.Columns[2].Visible = false;
            }
        }

        private void dgv_groups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_groups.Rows[index];

            selectedGroup = int.Parse(selectedRow.Cells[1].Value.ToString());
            reloadUsers();
        }

        private void btn_att_Click(object sender, EventArgs e)
        {
            reloadUsers();
            reloadGroups();
        }

        private void cfg_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.ShowDialog();
        }
    }
}
