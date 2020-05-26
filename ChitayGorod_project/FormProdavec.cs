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
    public partial class FormProdavec : Form
    {
        public FormProdavec()
        {
            InitializeComponent();
            ShowProdavec();
        }
        void ShowProdavec()
        {
            listViewProdavec.Items.Clear();
            foreach (ProdavecSet prod in Program.CGDb.ProdavecSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    prod.Id.ToString(), prod.Name, prod.Surname,
                    prod.Phone, prod.Position
                });
                item.Tag = prod;
                listViewProdavec.Items.Add(item);
            }
            listViewProdavec.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProdavecSet prod = new ProdavecSet();
            prod.Name = textBoxName.Text;
            prod.Surname = textBoxSurname.Text;
            prod.Position = comboBoxPosition.Text;
            prod.Phone = textBoxPhone.Text;
            Program.CGDb.ProdavecSet.Add(prod);
            Program.CGDb.SaveChanges();
            ShowProdavec();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProdavec.SelectedItems.Count == 1)
            {
                ProdavecSet prod = listViewProdavec.SelectedItems[0].Tag as ProdavecSet;
                prod.Name = textBoxName.Text;
                prod.Surname = textBoxSurname.Text;
                prod.Position = comboBoxPosition.Text;
                prod.Phone = textBoxPhone.Text;
                Program.CGDb.SaveChanges();
                ShowProdavec();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProdavec.SelectedItems.Count == 1)
                {
                    ProdavecSet prod = listViewProdavec.SelectedItems[0].Tag as ProdavecSet;
                    Program.CGDb.ProdavecSet.Remove(prod);
                    Program.CGDb.SaveChanges();
                    ShowProdavec();
                }
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                comboBoxPosition.Text = null;
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewProdavec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProdavec.SelectedItems.Count == 1)
            {
                ProdavecSet prod = listViewProdavec.SelectedItems[0].Tag as ProdavecSet;
                textBoxName.Text = prod.Name;
                textBoxSurname.Text = prod.Surname;
                comboBoxPosition.Text = prod.Position;
                textBoxPhone.Text = prod.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                comboBoxPosition.Text = null;
                textBoxPhone.Text = "";
            }
        }
    }
}
