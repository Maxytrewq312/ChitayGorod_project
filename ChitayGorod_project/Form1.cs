using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChitayGorod_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPosetitel_Click(object sender, EventArgs e)
        {
            Form formPos = new FormPosetitel();
            formPos.Show();
        }

        private void buttonProdavec_Click(object sender, EventArgs e)
        {
            Form formProd = new FormProdavec();
            formProd.Show();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            Form formbook = new FormBooks();
            formbook.Show();
        }

        private void buttonUchet_Click(object sender, EventArgs e)
        {
            Form formuchet = new FormUchetProd();
            formuchet.Show();
        }
    }
}
