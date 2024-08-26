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
    public partial class frmNovoAtor : Form
    {
        public frmNovoAtor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Contexto db;
        private void frmNovoAtor_Load(object sender, EventArgs e)
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
                Ator novo = new Ator();
                novo.Nome = txtNome.Text;
                novo.Nacionalidade = pais;
                this.db.Ator.Add(novo);
                this.db.SaveChanges();
                MessageBox.Show("Sucesso");
                this.Close();
            }
        }
    }
}
