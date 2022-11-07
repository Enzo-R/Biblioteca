namespace QbitTeste
{
    partial class Biblioteca
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLivrosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLivrosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLivrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLivrosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.DataView = new System.Windows.Forms.DataGridView();
            this.btnObterLivro = new System.Windows.Forms.Button();
            this.tableLivrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TituloBox = new System.Windows.Forms.ComboBox();
            this.AutorBox = new System.Windows.Forms.ComboBox();
            this.CategoriaBox = new System.Windows.Forms.ComboBox();
            this.EditoraBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Editora:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PesquisarLivro_btn);
            // 
            // tableLivrosBindingSource3
            // 
            this.tableLivrosBindingSource3.DataMember = "table_Livros";
            // 
            // tableLivrosBindingSource4
            // 
            this.tableLivrosBindingSource4.DataMember = "table_Livros";
            // 
            // tableLivrosBindingSource
            // 
            this.tableLivrosBindingSource.DataMember = "table_Livros";
            // 
            // tableLivrosBindingSource2
            // 
            this.tableLivrosBindingSource2.DataMember = "table_Livros";
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(238, 12);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidth = 62;
            this.DataView.RowTemplate.Height = 28;
            this.DataView.Size = new System.Drawing.Size(1040, 400);
            this.DataView.TabIndex = 18;
            // 
            // btnObterLivro
            // 
            this.btnObterLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterLivro.Location = new System.Drawing.Point(12, 361);
            this.btnObterLivro.Name = "btnObterLivro";
            this.btnObterLivro.Size = new System.Drawing.Size(220, 51);
            this.btnObterLivro.TabIndex = 19;
            this.btnObterLivro.Text = "Obter";
            this.btnObterLivro.UseVisualStyleBackColor = true;
            this.btnObterLivro.Click += new System.EventHandler(this.btnObterLivro_Click);
            // 
            // tableLivrosBindingSource1
            // 
            this.tableLivrosBindingSource1.DataMember = "table_Livros";
            // 
            // TituloBox
            // 
            this.TituloBox.FormattingEnabled = true;
            this.TituloBox.Location = new System.Drawing.Point(12, 32);
            this.TituloBox.Name = "TituloBox";
            this.TituloBox.Size = new System.Drawing.Size(220, 28);
            this.TituloBox.TabIndex = 20;
            // 
            // AutorBox
            // 
            this.AutorBox.FormattingEnabled = true;
            this.AutorBox.Location = new System.Drawing.Point(12, 101);
            this.AutorBox.Name = "AutorBox";
            this.AutorBox.Size = new System.Drawing.Size(220, 28);
            this.AutorBox.TabIndex = 21;
            // 
            // CategoriaBox
            // 
            this.CategoriaBox.FormattingEnabled = true;
            this.CategoriaBox.Location = new System.Drawing.Point(12, 168);
            this.CategoriaBox.Name = "CategoriaBox";
            this.CategoriaBox.Size = new System.Drawing.Size(220, 28);
            this.CategoriaBox.TabIndex = 22;
            // 
            // EditoraBox
            // 
            this.EditoraBox.FormattingEnabled = true;
            this.EditoraBox.Location = new System.Drawing.Point(12, 234);
            this.EditoraBox.Name = "EditoraBox";
            this.EditoraBox.Size = new System.Drawing.Size(220, 28);
            this.EditoraBox.TabIndex = 23;
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 421);
            this.Controls.Add(this.EditoraBox);
            this.Controls.Add(this.CategoriaBox);
            this.Controls.Add(this.AutorBox);
            this.Controls.Add(this.TituloBox);
            this.Controls.Add(this.btnObterLivro);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Biblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLivrosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button btnObterLivro;
        private System.Windows.Forms.BindingSource tableLivrosBindingSource;
        private System.Windows.Forms.BindingSource tableLivrosBindingSource1;
        private System.Windows.Forms.BindingSource tableLivrosBindingSource2;
        private System.Windows.Forms.BindingSource tableLivrosBindingSource3;
        private System.Windows.Forms.BindingSource tableLivrosBindingSource4;
        private System.Windows.Forms.ComboBox TituloBox;
        private System.Windows.Forms.ComboBox AutorBox;
        private System.Windows.Forms.ComboBox CategoriaBox;
        private System.Windows.Forms.ComboBox EditoraBox;
    }
}