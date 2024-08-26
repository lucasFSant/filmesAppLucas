namespace filmesApp1A
{
    partial class frmGerenciarElenco
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
            dgvElenco = new DataGridView();
            btInserir = new Button();
            btExcluir = new Button();
            label1 = new Label();
            lblFilme = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvElenco).BeginInit();
            SuspendLayout();
            // 
            // dgvElenco
            // 
            dgvElenco.BackgroundColor = Color.FromArgb(255, 128, 255);
            dgvElenco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElenco.Location = new Point(12, 77);
            dgvElenco.Name = "dgvElenco";
            dgvElenco.Size = new Size(427, 240);
            dgvElenco.TabIndex = 0;
            dgvElenco.CellClick += dgvElenco_CellClick;
            // 
            // btInserir
            // 
            btInserir.Font = new Font("Verdana", 15.75F);
            btInserir.Location = new Point(21, 358);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(158, 47);
            btInserir.TabIndex = 1;
            btInserir.Text = "Inserir Ator";
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // btExcluir
            // 
            btExcluir.Enabled = false;
            btExcluir.Font = new Font("Verdana", 15.75F);
            btExcluir.Location = new Point(215, 358);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(142, 47);
            btExcluir.TabIndex = 2;
            btExcluir.Text = "Excluir Ator";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 3;
            label1.Text = "Elenco do filme:";
            // 
            // lblFilme
            // 
            lblFilme.AutoSize = true;
            lblFilme.Font = new Font("Verdana", 15.75F);
            lblFilme.Location = new Point(123, 49);
            lblFilme.Name = "lblFilme";
            lblFilme.Size = new Size(0, 25);
            lblFilme.TabIndex = 4;
            // 
            // frmGerenciarElenco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(641, 431);
            Controls.Add(lblFilme);
            Controls.Add(label1);
            Controls.Add(btExcluir);
            Controls.Add(btInserir);
            Controls.Add(dgvElenco);
            MaximizeBox = false;
            Name = "frmGerenciarElenco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar ELenco";
            Load += frmGerenciarElenco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvElenco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvElenco;
        private Button btInserir;
        private Button btExcluir;
        private Label label1;
        private Label lblFilme;
    }
}