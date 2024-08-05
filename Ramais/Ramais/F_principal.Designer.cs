namespace Ramais
{
    partial class F_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgv_users = new DataGridView();
            dgv_groups = new DataGridView();
            splitContainer2 = new SplitContainer();
            label1 = new Label();
            btn_att = new Button();
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            cfg = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_groups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgv_users, 0, 1);
            tableLayoutPanel1.Controls.Add(dgv_groups, 0, 3);
            tableLayoutPanel1.Controls.Add(splitContainer2, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(310, 626);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_users
            // 
            dgv_users.AllowUserToAddRows = false;
            dgv_users.AllowUserToDeleteRows = false;
            dgv_users.AllowUserToResizeColumns = false;
            dgv_users.AllowUserToResizeRows = false;
            dgv_users.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.ColumnHeadersVisible = false;
            dgv_users.Dock = DockStyle.Fill;
            dgv_users.Location = new Point(3, 33);
            dgv_users.Name = "dgv_users";
            dgv_users.ReadOnly = true;
            dgv_users.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_users.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgv_users.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_users.Size = new Size(304, 371);
            dgv_users.TabIndex = 6;
            // 
            // dgv_groups
            // 
            dgv_groups.AllowUserToAddRows = false;
            dgv_groups.AllowUserToDeleteRows = false;
            dgv_groups.AllowUserToResizeColumns = false;
            dgv_groups.AllowUserToResizeRows = false;
            dgv_groups.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_groups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_groups.ColumnHeadersVisible = false;
            dgv_groups.Dock = DockStyle.Fill;
            dgv_groups.EnableHeadersVisualStyles = false;
            dgv_groups.Location = new Point(3, 440);
            dgv_groups.Name = "dgv_groups";
            dgv_groups.ReadOnly = true;
            dgv_groups.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_groups.RowHeadersVisible = false;
            dgv_groups.Size = new Size(304, 183);
            dgv_groups.TabIndex = 7;
            dgv_groups.CellClick += dgv_groups_CellClick;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btn_att);
            splitContainer2.Size = new Size(304, 24);
            splitContainer2.SplitterDistance = 101;
            splitContainer2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 3;
            label1.Text = "Ramais";
            // 
            // btn_att
            // 
            btn_att.Dock = DockStyle.Fill;
            btn_att.Location = new Point(0, 0);
            btn_att.Name = "btn_att";
            btn_att.Size = new Size(199, 24);
            btn_att.TabIndex = 1;
            btn_att.Text = "Atualizar";
            btn_att.UseVisualStyleBackColor = true;
            btn_att.Click += btn_att_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 410);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(cfg);
            splitContainer1.Size = new Size(304, 24);
            splitContainer1.SplitterDistance = 101;
            splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 3;
            label2.Text = "Grupos";
            // 
            // cfg
            // 
            cfg.Dock = DockStyle.Fill;
            cfg.Location = new Point(0, 0);
            cfg.Name = "cfg";
            cfg.Size = new Size(199, 24);
            cfg.TabIndex = 0;
            cfg.Text = "Configurar";
            cfg.UseVisualStyleBackColor = true;
            cfg.Click += cfg_Click;
            // 
            // F_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 626);
            Controls.Add(tableLayoutPanel1);
            Name = "F_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ramais [M.S.]";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_groups).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer2;
        private Label label1;
        private SplitContainer splitContainer1;
        private Label label2;
        private Button cfg;
        public DataGridView dgv_groups;
        private DataGridView dgv_users;
        private Button btn_att;
    }
}