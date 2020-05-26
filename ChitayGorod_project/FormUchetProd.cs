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
    public partial class FormUchetProd : Form
    {
        public FormUchetProd()
        {
            InitializeComponent();
            ShowPosetitels();
            ShowProdavecs();
            ShowBooks();
            ShowUchet();
        }
        void ShowPosetitels()
        {
            comboBoxPos.Items.Clear();
            foreach (PosetitelSet pos in Program.CGDb.PosetitelSet)
            {
                string[] item = { pos.Id.ToString() + ".", pos.Surname };
                comboBoxPos.Items.Add(string.Join(" ", item));
            }
        }
        void ShowProdavecs()
        {
            comboBoxProd.Items.Clear();
            foreach (ProdavecSet prod in Program.CGDb.ProdavecSet)
            {
                string[] item = { prod.Id.ToString() + ".", prod.Surname};
                comboBoxProd.Items.Add(string.Join(" ", item));
            }
        }
        void ShowBooks()
        {
            comboBoxBook.Items.Clear();
            foreach (BooksSet book in Program.CGDb.BooksSet)
            {
                string[] item = { book.Id.ToString() + ". ", book.Autor + ". ", book.Name};
                comboBoxBook.Items.Add(string.Join(" ", item));
            }
        }
        void ShowUchet()
        {
            listViewUchet.Items.Clear();
            foreach (UchetProdSet uchet in Program.CGDb.UchetProdSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    uchet.IdPosetitel.ToString(),
                    uchet.PosetitelSet.Surname + " ",
                    uchet.IdProdavec.ToString(),
                    uchet.ProdavecSet.Surname + " ",
                    uchet.IdBook.ToString(),
                    uchet.BooksSet.Autor + " " + uchet.BooksSet.Name + " ",
                });
                item.Tag = uchet;
                listViewUchet.Items.Add(item);
            }
        }
        private void listViewUchet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUchet.SelectedItems.Count == 1)
            {
                UchetProdSet uchet = listViewUchet.SelectedItems[0].Tag as UchetProdSet;
                comboBoxPos.SelectedIndex = comboBoxPos.FindString(uchet.IdPosetitel.ToString());
                comboBoxProd.SelectedIndex = comboBoxProd.FindString(uchet.IdProdavec.ToString());
                comboBoxBook.SelectedIndex = comboBoxBook.FindString(uchet.IdBook.ToString());
            }
            else
            {
                comboBoxPos.SelectedItem = null;
                comboBoxProd.SelectedItem = null;
                comboBoxBook.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxPos.SelectedItem != null && comboBoxProd.SelectedItem != null && comboBoxBook.SelectedItem != null)
            {
                UchetProdSet uchet = new UchetProdSet();
                uchet.IdPosetitel = Convert.ToInt32(comboBoxPos.SelectedItem.ToString().Split('.')[0]);
                uchet.IdProdavec = Convert.ToInt32(comboBoxProd.SelectedItem.ToString().Split('.')[0]);
                uchet.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                Program.CGDb.UchetProdSet.Add(uchet);
                Program.CGDb.SaveChanges();
                ShowUchet();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewUchet.SelectedItems.Count == 1)
            {
                UchetProdSet uchet = listViewUchet.SelectedItems[0].Tag as UchetProdSet;
                uchet.IdPosetitel = Convert.ToInt32(comboBoxPos.SelectedItem.ToString().Split('.')[0]);
                uchet.IdProdavec = Convert.ToInt32(comboBoxProd.SelectedItem.ToString().Split('.')[0]);
                uchet.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                Program.CGDb.SaveChanges();
                ShowUchet();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewUchet.SelectedItems.Count == 1)
                {
                    UchetProdSet uchet = listViewUchet.SelectedItems[0].Tag as UchetProdSet;
                    Program.CGDb.UchetProdSet.Remove(uchet);
                    Program.CGDb.SaveChanges();
                }
                comboBoxPos.SelectedItem = null;
                comboBoxProd.SelectedItem = null;
                comboBoxBook.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
