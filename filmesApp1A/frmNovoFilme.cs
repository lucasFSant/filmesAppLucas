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
    public partial class frmNovoFilme : Form
    {
        public frmNovoFilme()
        {
            InitializeComponent();
        }
        Contexto db;
        private void frmNovoFilme_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            if (cbxNacionalidade.SelectedIndex > -1)
            {
                Pais pais = this.db.Pais.
                    Where(
                    p => cbxNacionalidade.SelectedItem.ToString() == p.Nome
                    )
                .First();
                Filme novo = new Filme();
                novo.Nome = txtNome.Text;
                novo.Nacionalidade = pais;
                novo.AnoLancamento = (int)numAno.Value;
                this.db.Filme.Add(novo);
                this.db.SaveChanges();
                MessageBox.Show("Sucesso");
                this.Close();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
