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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
            ShowBook();
        }
        void ShowBook()
        {
            listViewBooks.Items.Clear();
            foreach (BooksSet book in Program.CGDb.BooksSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    book.Id.ToString(), book.Autor, book.Name,
                    book.Price
                });
                item.Tag = book;
                listViewBooks.Items.Add(item);
            }
            listViewBooks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BooksSet book = new BooksSet();
            book.Autor = textBoxAutor.Text;
            book.Name = textBoxName.Text;
            book.Price = textBoxPrice.Text;
            Program.CGDb.BooksSet.Add(book);
            Program.CGDb.SaveChanges();
            ShowBook();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 1)
            {
                BooksSet book = listViewBooks.SelectedItems[0].Tag as BooksSet;
                book.Autor = textBoxAutor.Text; 
                book.Name = textBoxName.Text;
                book.Price = textBoxPrice.Text;
                Program.CGDb.SaveChanges();
                ShowBook();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBooks.SelectedItems.Count == 1)
                {
                    BooksSet book = listViewBooks.SelectedItems[0].Tag as BooksSet;
                    Program.CGDb.BooksSet.Remove(book);
                    Program.CGDb.SaveChanges();
                    ShowBook();
                }
                textBoxAutor.Text = "";
                textBoxName.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 1)
            {
                BooksSet book = listViewBooks.SelectedItems[0].Tag as BooksSet;
                textBoxAutor.Text = book.Autor;
                textBoxName.Text = book.Name;
                textBoxPrice.Text = book.Price;
            }
            else
            {
                textBoxAutor.Text = "";
                textBoxName.Text = "";
                textBoxPrice.Text = "";
            }
        }
    }
}
