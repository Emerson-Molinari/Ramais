using Ramais.scripts;
using System.Data.SQLite;
using System.Data;
using System.ComponentModel.Design.Serialization;

namespace Ramais
{
    public partial class ramais : Form
    {
        public static int selectedGroup = 0;
        public static int selectedUser = 0;

        public ramais()
        {
            InitializeComponent();
        }

        public void GetGroups()
        {
            var repository = new Group();

        }







        private void btn_reload_Click(object sender, EventArgs e)
        {
            reloadGroups();
            reloadUsers();
        }

        private void ramais_Load(object sender, EventArgs e)
        {
            Connection.dataGrouplist();
            reloadGroups();
            reloadUsers();
        }

        private void reloadGroups()
        {
            Connection.dataGrouplist();
            dataGridView1.DataSource = Connection.dt_group;
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Visible = false;

            Connection.dataUserlist(selectedGroup);
            dgv_userlist.DataSource = Connection.dt_Users;
        }

        private void reloadUsers()
        {
            Connection.dataUserlist(selectedGroup);
            dgv_userlist.DataSource = Connection.dt_Users;
            dgv_userlist.Columns[0].Width = 200;
            dgv_userlist.Columns[1].Width = 50;
            dgv_userlist.Columns[2].Visible = false;
        }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            selectedGroup = int.Parse(selectedRow.Cells[1].Value.ToString());
            reloadUsers();
        }

        private void dgv_userlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_userlist.Rows[index];

            selectedUser = int.Parse(selectedRow.Cells[2].Value.ToString());
        }

        private void delete_user_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo DELETAR o ramal?", "Deletar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Connection.deleteUser(selectedUser);
                reloadUsers();
            }
        }

        private void add_group_Click(object sender, EventArgs e)
        {
            add_group addg = new add_group();
            addg.ShowDialog();
        }

        private void remove_group_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo DELETAR o grupo", "Deletar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Connection.deleteGroup(selectedGroup);
                reloadGroups();
            }
        }
    }
}
