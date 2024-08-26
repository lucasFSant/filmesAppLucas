namespace filmesApp1A
{
    partial class frmAtores
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
            components = new System.ComponentModel.Container();
            txtBuscar = new TextBox();
            btBuscar = new Button();
            dgvAtores = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            btCadastrar = new Button();
            btRemover = new Button();
            btEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Verdana", 15.75F);
            txtBuscar.Location = new Point(12, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(520, 33);
            txtBuscar.TabIndex = 0;
            // 
            // btBuscar
            // 
            btBuscar.Font = new Font("Verdana", 15.75F);
            btBuscar.Location = new Point(538, 10);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(100, 35);
            btBuscar.TabIndex = 1;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // dgvAtores
            // 
            dgvAtores.AutoGenerateColumns = false;
            dgvAtores.BackgroundColor = Color.FromArgb(255, 128, 255);
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvAtores.DataSource = atorBindingSource;
            dgvAtores.Location = new Point(12, 53);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.Size = new Size(597, 221);
            dgvAtores.TabIndex = 2;
            dgvAtores.CellClick += dgvAtores_CellClick;
            dgvAtores.CellContentClick += dgvAtores_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // btCadastrar
            // 
            btCadastrar.Font = new Font("Verdana", 15.75F);
            btCadastrar.Location = new Point(12, 298);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(92, 34);
            btCadastrar.TabIndex = 3;
            btCadastrar.Text = "Novo Ator";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Font = new Font("Verdana", 15.75F);
            btRemover.Location = new Point(520, 298);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(118, 34);
            btRemover.TabIndex = 4;
            btRemover.Text = "Remover Ator";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Font = new Font("Verdana", 15.75F);
            btEditar.Location = new Point(419, 298);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(85, 34);
            btEditar.TabIndex = 5;
            btEditar.Text = "Editar Ator";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // frmAtores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(710, 354);
            Controls.Add(btEditar);
            Controls.Add(btRemover);
            Controls.Add(btCadastrar);
            Controls.Add(dgvAtores);
            Controls.Add(btBuscar);
            Controls.Add(txtBuscar);
            MaximizeBox = false;
            Name = "frmAtores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atores";
            FormClosing += frmAtores_FormClosing;
            Load += frmAtores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btBuscar;
        private DataGridView dgvAtores;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
        private Button btCadastrar;
        private Button btRemover;
        private Button btEditar;
    }
}