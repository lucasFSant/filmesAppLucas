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
    public partial class frmAtores : Form
    {
        Form anterior;
        public frmAtores(Form anterior)
        {
            InitializeComponent();
            this.anterior = anterior;
        }
        Contexto db;
        private void frmAtores_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            this.db.Database.EnsureCreated();
            Recarregar("");
        }
        public void Recarregar(string busca)
        {
            List<Ator> atores = this.db.Ator.
                Where(a => a.Nome.ToUpper().Contains(busca.ToUpper())).ToList();
            dgvAtores.DataSource = atores;
        }
        private void frmAtores_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoAtor f = new frmNovoAtor();
            f.ShowDialog();
            Recarregar(txtBuscar.Text);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBuscar.Text);
        }
        Ator selecionado;
        private void dgvAtores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvAtores.SelectedCells[0].RowIndex;
            int id = (int)dgvAtores.Rows[linha].Cells[0].Value;
            selecionado = this.db.Ator.Where(a => a.Id == id).First();
            btRemover.Enabled = true;
            btEditar.Enabled = true;
        }

        private void dgvAtores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show
                ("Deseja mesmo excluir o ator "
                + selecionado.Nome + "?", "", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.db.Ator.Remove(selecionado);
                this.db.SaveChanges();
                MessageBox.Show("Sucesso");
                Recarregar("");

                btEditar.Enabled = false;
                btRemover.Enabled = false;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarAtor f = new frmEditarAtor(selecionado, this.db);
            f.ShowDialog();
            Recarregar(txtBuscar.Text);
        }
    }
}
