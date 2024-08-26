namespace filmesApp1A
{
    partial class frmNovoAtor
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
            btCriar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            cbxNacionalidade = new ComboBox();
            SuspendLayout();
            // 
            // btCriar
            // 
            btCriar.Font = new Font("Verdana", 15.75F);
            btCriar.Location = new Point(165, 146);
            btCriar.Name = "btCriar";
            btCriar.Size = new Size(133, 60);
            btCriar.TabIndex = 0;
            btCriar.Text = "Criar";
            btCriar.UseVisualStyleBackColor = true;
            btCriar.Click += btCriar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F);
            label1.Location = new Point(129, 42);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F);
            label2.Location = new Point(42, 92);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 2;
            label2.Text = "Nacionalidade:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Verdana", 15.75F);
            txtNome.Location = new Point(219, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 33);
            txtNome.TabIndex = 3;
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.Font = new Font("Verdana", 15.75F);
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(219, 84);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(121, 33);
            cbxNacionalidade.TabIndex = 4;
            // 
            // frmNovoAtor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(528, 234);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCriar);
            MaximizeBox = false;
            Name = "frmNovoAtor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Ator";
            Load += frmNovoAtor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCriar;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private ComboBox cbxNacionalidade;
    }
}