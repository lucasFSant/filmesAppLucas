using filmesApp1A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp1A
{
    public partial class frmEditarAtor : Form
    {
        Ator ator;
        public frmEditarAtor(Ator ator, Contexto db)
        {
            InitializeComponent();
            this.ator = ator;
            this.db = db;
        }
        Contexto db;
        private void frmEditarAtor_Load(object sender, EventArgs e)
        {
            ator.Filmes = this.db.Filme.Where(filme => filme.Atores.Contains(ator)).ToList();
            txtNome.Text = ator.Nome;
            cbxNacionalidade.DataSource = this.db.Pais.ToList();
            cbxNacionalidade.SelectedIndex = cbxNacionalidade.FindStringExact(ator.Nacionalidade.Nome);
            dgvFilmes.DataSource = ator.Filmes;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ator.Nome = txtNome.Text;
            Pais pais = this.db.Pais.Where(
                p => p.Nome == cbxNacionalidade.SelectedItem.ToString()).First();
            ator.Nacionalidade = pais;
            this.db.Ator.Update(ator);
            this.db.SaveChanges();
            
        }
    }
}
