namespace filmesApp1A
{
    partial class frmNovoFilme
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
            cbxNacionalidade = new ComboBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btCriar = new Button();
            label3 = new Label();
            numAno = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAno).BeginInit();
            SuspendLayout();
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.AccessibleRole = AccessibleRole.OutlineButton;
            cbxNacionalidade.Font = new Font("Verdana", 15.75F);
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(238, 77);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(121, 33);
            cbxNacionalidade.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.AccessibleRole = AccessibleRole.OutlineButton;
            txtNome.Font = new Font("Verdana", 15.75F);
            txtNome.Location = new Point(238, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 33);
            txtNome.TabIndex = 8;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.OutlineButton;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F);
            label2.Location = new Point(61, 77);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 7;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.OutlineButton;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F);
            label1.Location = new Point(148, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // btCriar
            // 
            btCriar.AccessibleRole = AccessibleRole.OutlineButton;
            btCriar.Font = new Font("Verdana", 15.75F);
            btCriar.Location = new Point(197, 184);
            btCriar.Name = "btCriar";
            btCriar.Size = new Size(91, 36);
            btCriar.TabIndex = 5;
            btCriar.Text = "Criar";
            btCriar.UseVisualStyleBackColor = true;
            btCriar.Click += btCriar_Click;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.OutlineButton;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F);
            label3.Location = new Point(34, 118);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 10;
            label3.Text = "Ano Lançamento:";
            // 
            // numAno
            // 
            numAno.AccessibleRole = AccessibleRole.OutlineButton;
            numAno.Font = new Font("Verdana", 15.75F);
            numAno.Location = new Point(239, 116);
            numAno.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numAno.Name = "numAno";
            numAno.Size = new Size(120, 33);
            numAno.TabIndex = 11;
            // 
            // frmNovoFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(512, 232);
            Controls.Add(numAno);
            Controls.Add(label3);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCriar);
            MaximizeBox = false;
            Name = "frmNovoFilme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNovoFilme";
            Load += frmNovoFilme_Load;
            ((System.ComponentModel.ISupportInitialize)numAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxNacionalidade;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Button btCriar;
        private Label label3;
        private NumericUpDown numAno;
    }
}