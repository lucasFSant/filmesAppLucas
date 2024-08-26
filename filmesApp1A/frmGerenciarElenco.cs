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
    public partial class frmGerenciarElenco : Form
    {
        Filme filme; Contexto db;

        public frmGerenciarElenco(Filme filme, Contexto db)
        {
            InitializeComponent(); this.filme = filme; this.db = db;
        }

        private void frmGerenciarElenco_Load(object sender, EventArgs e)
        {
            lblFilme.Text = filme.Nome; Recarregar();
        }

        public void Recarregar()
        {
            dgvElenco.DataSource = this.db.Ator
                .Where(a => a.Filmes.Contains(filme)).ToList();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            frmInserirElenco f = new frmInserirElenco(filme, db); f.ShowDialog();
            Recarregar();
        }

        Ator selecionado;

        private void dgvElenco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvElenco.SelectedCells[0].RowIndex;
            int id = (int)dgvElenco.Rows[linha].Cells[0].Value;
            selecionado = this.db.Ator.Where(a => a.Id == id).First();
            btExcluir.Enabled = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo excluir o ator "
                + selecionado.Nome + "?", "", MessageBoxButtons.YesNo
            );

            if (r == DialogResult.Yes)
            {
                filme.Atores.Remove(selecionado); this.db.Filme.Update(filme);
                this.db.SaveChanges(); MessageBox.Show("Sucesso");
                Recarregar(); btExcluir.Enabled = false;
            }
        }
    }
}
