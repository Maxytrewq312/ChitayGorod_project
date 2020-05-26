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
    public partial class FormPosetitel : Form
    {
        public FormPosetitel()
        {
            InitializeComponent();
            ShowPosetitel();
        }
        void ShowPosetitel()
        {
            listViewPoset.Items.Clear();
            foreach (PosetitelSet pos in Program.CGDb.PosetitelSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pos.Id.ToString(), pos.Name, pos.Surname,
                    pos.Patronymic, pos.Phone
                });
                item.Tag = pos;
                listViewPoset.Items.Add(item);
            }
            listViewPoset.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PosetitelSet pos = new PosetitelSet();
            pos.Name = textBoxName.Text;
            pos.Surname = textBoxSurname.Text;
            pos.Patronymic = textBoxPatronymic.Text;
            pos.Phone = textBoxPhone.Text;
            Program.CGDb.PosetitelSet.Add(pos);
            Program.CGDb.SaveChanges();
            ShowPosetitel();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPoset.SelectedItems.Count == 1)
            {
                PosetitelSet pos = listViewPoset.SelectedItems[0].Tag as PosetitelSet;
                pos.Name = textBoxName.Text;
                pos.Surname = textBoxSurname.Text;
                pos.Patronymic = textBoxPatronymic.Text;
                pos.Phone = textBoxPhone.Text;
                Program.CGDb.SaveChanges();
                ShowPosetitel();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPoset.SelectedItems.Count == 1)
                {
                    PosetitelSet pos = listViewPoset.SelectedItems[0].Tag as PosetitelSet;
                    Program.CGDb.PosetitelSet.Remove(pos);
                    Program.CGDb.SaveChanges();
                    ShowPosetitel();
                }
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewPoset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPoset.SelectedItems.Count == 1)
            {
                PosetitelSet pos = listViewPoset.SelectedItems[0].Tag as PosetitelSet;
                textBoxName.Text = pos.Name;
                textBoxSurname.Text = pos.Surname;
                textBoxPatronymic.Text = pos.Patronymic;
                textBoxPhone.Text = pos.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxPhone.Text = "";
            }
        }
    }
}
