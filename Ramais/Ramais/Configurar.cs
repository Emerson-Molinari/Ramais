using Ramais.scripts;
using System.Data.SQLite;
using System.Data;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;
using System.ComponentModel;

namespace Ramais
{
    public partial class ramais : Form
    {
        public static int selectedGroup = 999;
        public static int selectedUser = 0;

        public ramais()
        {
            InitializeComponent();
            LoadUsers();
            LoadGroups();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadUsers();
            LoadGroups();
        }

        private void ramais_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadGroups();
        }

        #region Load Grids

        void LoadUsers()
        {
            if (selectedGroup == 999)
            {
                Connection.Get("select name,ramal,id from r_user");
                dgv_userlist.DataSource = Connection.getList;
                dgv_userlist.Columns[0].Width = 200;
                dgv_userlist.Columns[1].Width = 50;
                dgv_userlist.Columns[2].Visible = false;
                dgv_userlist.Sort(dgv_userlist.Columns[0], ListSortDirection.Ascending);

                return;
            }


            dgv_userlist.DataSource = Connection.Get("select name,ramal,id from r_user where u_group = " + selectedGroup);


            if (dgv_userlist.Rows.Count == 0)
            {
                return;
            }
            else
            {
                dgv_userlist.Columns[0].Width = 200;
                dgv_userlist.Columns[1].Width = 50;
                dgv_userlist.Columns[2].Visible = false;
                dgv_userlist.Sort(dgv_userlist.Columns[0], ListSortDirection.Ascending);
            }
        }

        void LoadGroups()
        {
            dgv_groups.DataSource = Connection.Get("SELECT name,id from r_group");

            if (dgv_groups.Rows.Count == 0)
            {
                return;
            }
            else
            {
                dgv_groups.Columns[0].Width = 250;
                dgv_groups.Columns[1].Visible = false;
            }
        }

        #endregion


        #region Grid Index

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_groups.Rows[index];

            selectedGroup = int.Parse(selectedRow.Cells[1].Value.ToString());


            LoadUsers();
        }

        private void dgv_userlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_userlist.Rows[index];

            selectedUser = int.Parse(selectedRow.Cells[2].Value.ToString());
        }

        #endregion


        #region Open outhers forms

        private void add_user_Click(object sender, EventArgs e)
        {

            if (selectedGroup != 0)
            {
                add_user addu = new add_user();
                addu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Deve Selecionar um Grupo");
            }
        }

        private void add_group_Click(object sender, EventArgs e)
        {
            add_group addg = new add_group();
            addg.ShowDialog();
            LoadGroups();
        }

        private void delete_user_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo DELETAR o ramal?", "Deletar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                var sql = "DELETE FROM r_user WHERE id =" + selectedUser;
                Connection.Delete(sql);
                LoadUsers();
            }
        }

        private void remove_group_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo DELETAR o grupo", "Deletar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if(selectedGroup == 999)
                {
                    MessageBox.Show("Este grupo Não pode ser Excluido");
                    return;
                }

                var sql = "DELETE FROM r_group WHERE id =" + selectedGroup;
                Connection.Delete(sql);
                LoadGroups();
            }
        }

        #endregion
    }
}
