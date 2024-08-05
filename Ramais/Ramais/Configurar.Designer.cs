namespace Ramais
{
    partial class ramais
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ramais));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_reload = new Button();
            remove_group = new Button();
            add_group = new Button();
            delete_user = new Button();
            add_user = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dgv_userlist = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_userlist).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(442, 539);
            splitContainer1.SplitterDistance = 161;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btn_reload, 0, 4);
            tableLayoutPanel1.Controls.Add(remove_group, 0, 3);
            tableLayoutPanel1.Controls.Add(add_group, 0, 2);
            tableLayoutPanel1.Controls.Add(delete_user, 0, 1);
            tableLayoutPanel1.Controls.Add(add_user, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(161, 539);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_reload
            // 
            btn_reload.Dock = DockStyle.Fill;
            btn_reload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reload.Image = (Image)resources.GetObject("btn_reload.Image");
            btn_reload.Location = new Point(3, 431);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(155, 105);
            btn_reload.TabIndex = 5;
            btn_reload.Text = "Recarregar";
            btn_reload.TextAlign = ContentAlignment.BottomCenter;
            btn_reload.UseVisualStyleBackColor = true;
            btn_reload.Click += btn_reload_Click;
            // 
            // remove_group
            // 
            remove_group.Dock = DockStyle.Fill;
            remove_group.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove_group.Image = Properties.Resources.Frame_31;
            remove_group.Location = new Point(3, 324);
            remove_group.Name = "remove_group";
            remove_group.Size = new Size(155, 101);
            remove_group.TabIndex = 4;
            remove_group.Text = "Remover Grupo";
            remove_group.TextAlign = ContentAlignment.BottomCenter;
            remove_group.UseVisualStyleBackColor = true;
            remove_group.Click += remove_group_Click;
            // 
            // add_group
            // 
            add_group.Dock = DockStyle.Fill;
            add_group.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_group.Image = Properties.Resources.Frame_4;
            add_group.Location = new Point(3, 217);
            add_group.Name = "add_group";
            add_group.Size = new Size(155, 101);
            add_group.TabIndex = 3;
            add_group.Text = "Adicional Grupo";
            add_group.TextAlign = ContentAlignment.BottomCenter;
            add_group.UseVisualStyleBackColor = true;
            add_group.Click += add_group_Click;
            // 
            // delete_user
            // 
            delete_user.Dock = DockStyle.Fill;
            delete_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_user.Image = Properties.Resources.Frame_2;
            delete_user.Location = new Point(3, 110);
            delete_user.Name = "delete_user";
            delete_user.Size = new Size(155, 101);
            delete_user.TabIndex = 2;
            delete_user.Text = "Remover Usuario";
            delete_user.TextAlign = ContentAlignment.BottomCenter;
            delete_user.UseVisualStyleBackColor = true;
            delete_user.Click += delete_user_Click;
            // 
            // add_user
            // 
            add_user.Dock = DockStyle.Fill;
            add_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_user.Image = Properties.Resources.Frame_11;
            add_user.Location = new Point(3, 3);
            add_user.Name = "add_user";
            add_user.Size = new Size(155, 101);
            add_user.TabIndex = 1;
            add_user.Text = "Adicional Usuario";
            add_user.TextAlign = ContentAlignment.BottomCenter;
            add_user.UseVisualStyleBackColor = true;
            add_user.Click += add_user_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(dgv_userlist, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.22517F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.7748337F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(277, 539);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(271, 162);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Ramais";
            // 
            // dgv_userlist
            // 
            dgv_userlist.AllowUserToAddRows = false;
            dgv_userlist.AllowUserToDeleteRows = false;
            dgv_userlist.AllowUserToResizeColumns = false;
            dgv_userlist.AllowUserToResizeRows = false;
            dgv_userlist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_userlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_userlist.ColumnHeadersVisible = false;
            dgv_userlist.Dock = DockStyle.Fill;
            dgv_userlist.Location = new Point(3, 23);
            dgv_userlist.Name = "dgv_userlist";
            dgv_userlist.ReadOnly = true;
            dgv_userlist.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_userlist.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgv_userlist.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_userlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_userlist.Size = new Size(271, 321);
            dgv_userlist.TabIndex = 5;
            dgv_userlist.CellClick += dgv_userlist_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 347);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 7;
            label2.Text = "Grupos";
            // 
            // ramais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 539);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ramais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Central de controle da Lista de Ramais [Molinari Systems]";
            Load += ramais_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_userlist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button add_user;
        private Button remove_group;
        private Button add_group;
        private Button delete_user;
        private Label label1;
        private DataGridView dgv_userlist;
        private Button btn_reload;
        public DataGridView dataGridView1;
        private Label label2;
    }
}
