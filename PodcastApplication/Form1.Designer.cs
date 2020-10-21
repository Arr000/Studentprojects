namespace PodcastApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchPodcast = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listPodcast = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Titel = new System.Windows.Forms.ColumnHeader();
            this.Episode = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.listCategory = new System.Windows.Forms.ListBox();
            this.Kategori = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtInsertCategory = new System.Windows.Forms.TextBox();
            this.listEpisodes = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChooseCategory = new System.Windows.Forms.TextBox();
            this.cbxFrekvens = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchPodcast
            // 
            this.btnSearchPodcast.Location = new System.Drawing.Point(31, 33);
            this.btnSearchPodcast.Name = "btnSearchPodcast";
            this.btnSearchPodcast.Size = new System.Drawing.Size(147, 23);
            this.btnSearchPodcast.TabIndex = 0;
            this.btnSearchPodcast.Text = "Sök Podcast";
            this.btnSearchPodcast.UseVisualStyleBackColor = true;
            this.btnSearchPodcast.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 23);
            this.textBox1.TabIndex = 1;
            // 
            // listPodcast
            // 
            this.listPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Titel,
            this.Episode,
            this.columnHeader1,
            this.columnHeader2});
            this.listPodcast.HideSelection = false;
            this.listPodcast.Location = new System.Drawing.Point(31, 105);
            this.listPodcast.Name = "listPodcast";
            this.listPodcast.Size = new System.Drawing.Size(245, 189);
            this.listPodcast.TabIndex = 2;
            this.listPodcast.UseCompatibleStateImageBehavior = false;
            this.listPodcast.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Titel
            // 
            this.Titel.Text = "Titel";
            // 
            // Episode
            // 
            this.Episode.Text = "Episode";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Frekvens";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            // 
            // listCategory
            // 
            this.listCategory.FormattingEnabled = true;
            this.listCategory.ItemHeight = 15;
            this.listCategory.Location = new System.Drawing.Point(447, 33);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(170, 94);
            this.listCategory.TabIndex = 3;
            this.listCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listCategory_MouseDown);
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Location = new System.Drawing.Point(447, 13);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(51, 15);
            this.Kategori.TabIndex = 5;
            this.Kategori.Text = "Kategori";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(447, 168);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Lägg Till";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtInsertCategory
            // 
            this.txtInsertCategory.Location = new System.Drawing.Point(447, 134);
            this.txtInsertCategory.Name = "txtInsertCategory";
            this.txtInsertCategory.Size = new System.Drawing.Size(170, 23);
            this.txtInsertCategory.TabIndex = 7;
            // 
            // listEpisodes
            // 
            this.listEpisodes.FormattingEnabled = true;
            this.listEpisodes.ItemHeight = 15;
            this.listEpisodes.Location = new System.Drawing.Point(447, 208);
            this.listEpisodes.Name = "listEpisodes";
            this.listEpisodes.Size = new System.Drawing.Size(371, 169);
            this.listEpisodes.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ändra Kategori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(31, 313);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(58, 23);
            this.txtTitel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titel";
            // 
            // txtChooseCategory
            // 
            this.txtChooseCategory.Location = new System.Drawing.Point(198, 314);
            this.txtChooseCategory.Name = "txtChooseCategory";
            this.txtChooseCategory.Size = new System.Drawing.Size(78, 23);
            this.txtChooseCategory.TabIndex = 11;
            // 
            // cbxFrekvens
            // 
            this.cbxFrekvens.FormattingEnabled = true;
            this.cbxFrekvens.Location = new System.Drawing.Point(112, 313);
            this.cbxFrekvens.Name = "cbxFrekvens";
            this.cbxFrekvens.Size = new System.Drawing.Size(66, 23);
            this.cbxFrekvens.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Frekvens";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Visa avsnitt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Radera";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxFrekvens);
            this.Controls.Add(this.txtChooseCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listEpisodes);
            this.Controls.Add(this.txtInsertCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.listCategory);
            this.Controls.Add(this.listPodcast);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearchPodcast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPodcast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listPodcast;
        private System.Windows.Forms.ColumnHeader Titel;
        private System.Windows.Forms.ColumnHeader Episode;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListBox listCategory;
        private System.Windows.Forms.Label Kategori;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtInsertCategory;
        private System.Windows.Forms.ListBox listEpisodes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChooseCategory;
        private System.Windows.Forms.ComboBox cbxFrekvens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelete;
    }
}

