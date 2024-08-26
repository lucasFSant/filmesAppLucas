using filmesApp1A.Models;
using System.Linq.Expressions;

namespace filmesApp1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btAtores_Click_1(object sender, EventArgs e)
        {
            frmAtores a = new frmAtores(this);
            a.Show();
            this.Hide();
        }

        private void btFilmes_Click(object sender, EventArgs e)
        {
            frmFilmes f = new frmFilmes(this);
            f.Show();
            this.Hide();
        }
    }
}
