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
    public partial class frmEditarFilme : Form
    {
        Filme filme;
        public frmEditarFilme(Filme filme)
        {
            InitializeComponent();
            this.filme = filme;
        }
        Contexto db;
        private void frmEditarFilme_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            txtNome.Text = filme.Nome;
            cbxNacionalidade.DataSource = this.db.Pais.ToList();
            cbxNacionalidade.SelectedIndex = cbxNacionalidade.FindStringExact(filme.Nacionalidade.Nome);
            numAno.Value = filme.AnoLancamento;
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            filme.Nome = txtNome.Text;
            Pais pais = this.db.Pais.Where(
                p => p.Nome == cbxNacionalidade.SelectedItem.ToString()).First();
            filme.Nacionalidade = pais;
            filme.AnoLancamento = (int) numAno.Value;
            this.db.Filme.Update(filme);
            this.db.SaveChanges();
        }
    }
}
