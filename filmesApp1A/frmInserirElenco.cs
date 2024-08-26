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
    public partial class frmInserirElenco : Form
    {
        Filme filme;
        Contexto db;
        public frmInserirElenco(Filme filme, Contexto db)
        {
            InitializeComponent();
            this.filme = filme;
            this.db = db;
        }
        private void frmInserirElenco_Load(object sender, EventArgs e)
        {
            List<Ator> atores = this.db.Ator.ToList();
            cbxAtor.DataSource = atores;
            
            
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbxAtor.SelectedIndex > -1)
            {
                Ator ator = this.db.Ator.
                    Where(
                        p => cbxAtor.SelectedItem.ToString() == p.Nome
                    )
                .First();
                filme.Atores.Add(ator);
                this.db.Filme.Update(filme);
                this.db.SaveChanges();
                MessageBox.Show("Adicionado com sucesso!");
            }
        }

        private void cbxAtor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
