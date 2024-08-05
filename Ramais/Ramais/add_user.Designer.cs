namespace Ramais
{
    partial class add_user
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
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            tb_group = new TextBox();
            Ramal = new Label();
            label1 = new Label();
            tb_ramal = new TextBox();
            tb_name = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(tb_group);
            splitContainer1.Panel1.Controls.Add(Ramal);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(tb_ramal);
            splitContainer1.Panel1.Controls.Add(tb_name);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(489, 190);
            splitContainer1.SplitterDistance = 116;
            splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Grupo";
            // 
            // tb_group
            // 
            tb_group.Location = new Point(12, 33);
            tb_group.Name = "tb_group";
            tb_group.ReadOnly = true;
            tb_group.ShortcutsEnabled = false;
            tb_group.Size = new Size(229, 23);
            tb_group.TabIndex = 99;
            tb_group.TabStop = false;
            // 
            // Ramal
            // 
            Ramal.AutoSize = true;
            Ramal.Location = new Point(378, 59);
            Ramal.Name = "Ramal";
            Ramal.Size = new Size(40, 15);
            Ramal.TabIndex = 3;
            Ramal.Text = "Ramal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // tb_ramal
            // 
            tb_ramal.Location = new Point(378, 77);
            tb_ramal.Name = "tb_ramal";
            tb_ramal.Size = new Size(99, 23);
            tb_ramal.TabIndex = 1;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(12, 77);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(360, 23);
            tb_name.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(489, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(238, 64);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(247, 3);
            button1.Name = "button1";
            button1.Size = new Size(239, 64);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // add_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 190);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "add_user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_user";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label Ramal;
        private Label label1;
        private TextBox tb_ramal;
        private TextBox tb_name;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Button button1;
        private Label label2;
        private TextBox tb_group;
    }
}