namespace ChitayGorod_project
{
    partial class FormUchetProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPos = new System.Windows.Forms.ComboBox();
            this.comboBoxProd = new System.Windows.Forms.ComboBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.labelPos = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.labelBook = new System.Windows.Forms.Label();
            this.listViewUchet = new System.Windows.Forms.ListView();
            this.idpos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.пос = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idprod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.прод = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idbook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.авторназв = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPos
            // 
            this.comboBoxPos.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPos.FormattingEnabled = true;
            this.comboBoxPos.Location = new System.Drawing.Point(12, 65);
            this.comboBoxPos.Name = "comboBoxPos";
            this.comboBoxPos.Size = new System.Drawing.Size(179, 21);
            this.comboBoxPos.TabIndex = 0;
            // 
            // comboBoxProd
            // 
            this.comboBoxProd.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxProd.FormattingEnabled = true;
            this.comboBoxProd.Location = new System.Drawing.Point(12, 133);
            this.comboBoxProd.Name = "comboBoxProd";
            this.comboBoxProd.Size = new System.Drawing.Size(179, 21);
            this.comboBoxProd.TabIndex = 1;
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(12, 206);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(179, 21);
            this.comboBoxBook.TabIndex = 2;
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos.Location = new System.Drawing.Point(9, 49);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(67, 13);
            this.labelPos.TabIndex = 3;
            this.labelPos.Text = "Посетитель";
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProd.Location = new System.Drawing.Point(9, 117);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(58, 13);
            this.labelProd.TabIndex = 4;
            this.labelProd.Text = "Продавец";
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBook.Location = new System.Drawing.Point(9, 190);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(37, 13);
            this.labelBook.TabIndex = 5;
            this.labelBook.Text = "Книга";
            // 
            // listViewUchet
            // 
            this.listViewUchet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idpos,
            this.пос,
            this.idprod,
            this.прод,
            this.idbook,
            this.авторназв});
            this.listViewUchet.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewUchet.FullRowSelect = true;
            this.listViewUchet.GridLines = true;
            this.listViewUchet.HideSelection = false;
            this.listViewUchet.Location = new System.Drawing.Point(253, 49);
            this.listViewUchet.MultiSelect = false;
            this.listViewUchet.Name = "listViewUchet";
            this.listViewUchet.Size = new System.Drawing.Size(637, 281);
            this.listViewUchet.TabIndex = 6;
            this.listViewUchet.UseCompatibleStateImageBehavior = false;
            this.listViewUchet.View = System.Windows.Forms.View.Details;
            this.listViewUchet.SelectedIndexChanged += new System.EventHandler(this.listViewUchet_SelectedIndexChanged);
            // 
            // idpos
            // 
            this.idpos.Text = "IdPosetitel";
            this.idpos.Width = 66;
            // 
            // пос
            // 
            this.пос.Text = "Фамилия посетителя";
            this.пос.Width = 123;
            // 
            // idprod
            // 
            this.idprod.Text = "IdProdavec";
            this.idprod.Width = 71;
            // 
            // прод
            // 
            this.прод.Text = "Фамилия продавца";
            this.прод.Width = 116;
            // 
            // idbook
            // 
            this.idbook.Text = "IdBook";
            // 
            // авторназв
            // 
            this.авторназв.Text = "Автор и название книги";
            this.авторназв.Width = 195;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(518, 390);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 48);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(644, 390);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 48);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(770, 390);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(120, 48);
            this.buttonDel.TabIndex = 9;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChitayGorod_project.Properties.Resources._1556107486_8157;
            this.pictureBox1.Location = new System.Drawing.Point(12, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormUchetProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewUchet);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.labelPos);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.comboBoxProd);
            this.Controls.Add(this.comboBoxPos);
            this.Name = "FormUchetProd";
            this.Text = "Учет продаж";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPos;
        private System.Windows.Forms.ComboBox comboBoxProd;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.ListView listViewUchet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader idpos;
        private System.Windows.Forms.ColumnHeader пос;
        private System.Windows.Forms.ColumnHeader idprod;
        private System.Windows.Forms.ColumnHeader прод;
        private System.Windows.Forms.ColumnHeader idbook;
        private System.Windows.Forms.ColumnHeader авторназв;
    }
}