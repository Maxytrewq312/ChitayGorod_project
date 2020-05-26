namespace ChitayGorod_project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonPosetitel = new System.Windows.Forms.Button();
            this.buttonProdavec = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonUchet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHello.Location = new System.Drawing.Point(144, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(34, 14);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Hello";
            // 
            // buttonPosetitel
            // 
            this.buttonPosetitel.BackColor = System.Drawing.Color.Yellow;
            this.buttonPosetitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosetitel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPosetitel.Location = new System.Drawing.Point(12, 216);
            this.buttonPosetitel.Name = "buttonPosetitel";
            this.buttonPosetitel.Size = new System.Drawing.Size(369, 48);
            this.buttonPosetitel.TabIndex = 3;
            this.buttonPosetitel.Text = "Посетитель";
            this.buttonPosetitel.UseVisualStyleBackColor = false;
            this.buttonPosetitel.Click += new System.EventHandler(this.buttonPosetitel_Click);
            // 
            // buttonProdavec
            // 
            this.buttonProdavec.BackColor = System.Drawing.Color.Yellow;
            this.buttonProdavec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdavec.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProdavec.Location = new System.Drawing.Point(12, 292);
            this.buttonProdavec.Name = "buttonProdavec";
            this.buttonProdavec.Size = new System.Drawing.Size(369, 48);
            this.buttonProdavec.TabIndex = 4;
            this.buttonProdavec.Text = "Продавец";
            this.buttonProdavec.UseVisualStyleBackColor = false;
            this.buttonProdavec.Click += new System.EventHandler(this.buttonProdavec_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.Yellow;
            this.buttonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooks.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBooks.Location = new System.Drawing.Point(12, 372);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(369, 48);
            this.buttonBooks.TabIndex = 5;
            this.buttonBooks.Text = "Книги";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonUchet
            // 
            this.buttonUchet.BackColor = System.Drawing.Color.Yellow;
            this.buttonUchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUchet.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUchet.Location = new System.Drawing.Point(12, 455);
            this.buttonUchet.Name = "buttonUchet";
            this.buttonUchet.Size = new System.Drawing.Size(369, 48);
            this.buttonUchet.TabIndex = 6;
            this.buttonUchet.Text = "Учет продаж";
            this.buttonUchet.UseVisualStyleBackColor = false;
            this.buttonUchet.Click += new System.EventHandler(this.buttonUchet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChitayGorod_project.Properties.Resources.CHitay_gorod;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(393, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUchet);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.buttonProdavec);
            this.Controls.Add(this.buttonPosetitel);
            this.Controls.Add(this.labelHello);
            this.Name = "Menu";
            this.Text = "Главная страница";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonPosetitel;
        private System.Windows.Forms.Button buttonProdavec;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonUchet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

