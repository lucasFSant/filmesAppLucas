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
    public partial class frmFilmes : Form
    {
        Form anterior; public frmFilmes(Form anterior)
        {
            InitializeComponent(); this.anterior = anterior;
        }

        Contexto db; private void frmFilmes_Load(object sender, EventArgs e)
        {
            this.db = new Contexto(); this.db.Database.EnsureCreated(); Recarregar("");
        }

        Filme selecionado; public void Recarregar(string busca)
        {
            List<Filme> filmes = this.db.Filme
                .Where(a => a.Nome.ToUpper().Contains(busca.ToUpper()))
                .ToList(); dgvFilmes.DataSource = filmes;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBuscar.Text);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoFilme f = new frmNovoFilme(); f.ShowDialog();
            Recarregar(txtBuscar.Text);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarFilme frm = new frmEditarFilme(selecionado); frm.ShowDialog();
            Recarregar(txtBuscar.Text);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "quer excluir o filme " + selecionado.Nome + "?", "",
                MessageBoxButtons.YesNo
            );

            if (r == DialogResult.Yes)
            {
                selecionado.Atores.Clear(); this.db.Filme.Remove(selecionado);
                this.db.SaveChanges(); MessageBox.Show("sucesso");
                Recarregar(""); btEditar.Enabled = false;
                btRemover.Enabled = false; btGerenciar.Enabled = false;
            }
        }

        private void frmFilmes_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementação vazia
        }

        private void dgvFilmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvFilmes.SelectedCells[0].RowIndex;
            int id = (int)dgvFilmes.Rows[linha].Cells[0].Value;
            selecionado = this.db.Filme.Where(a => a.Id == id).First();
            btRemover.Enabled = true; btEditar.Enabled = true;
            btGerenciar.Enabled = true;
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            frmGerenciarElenco f = new frmGerenciarElenco(selecionado, db);
            f.ShowDialog(); Recarregar("");
        }
    }
}
