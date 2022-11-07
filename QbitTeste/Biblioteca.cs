using QbitTeste.Infra.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeQbit.Infra;
using testeQbit.Models;
using testeQbit.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QbitTeste
{
    public partial class Biblioteca : Form, ILivros
    {

        public Biblioteca()
        {
            InitializeComponent();
            TutiloList();
            AutorList();
            CategoriaList();
            EditoraList();
        }


        public string TituloTxt { get { return TituloBox.Text; } set { TituloBox.Text = value; } }
        public string AutorTxt { get { return AutorBox.Text; } set { AutorBox.Text = value; } }
        public string CategoriaTxt { get { return CategoriaBox.Text; } set { CategoriaBox.Text = value; } }
        public string EditoraTxt { get { return EditoraBox.Text; } set { EditoraBox.Text = value; } }



        private void PesquisarLivro_btn(object sender, EventArgs e)
        {
            LivrosRepository lr = new LivrosRepository(this);

            if (AutorBox.Text != "" && TituloBox.Text != "" && EditoraBox.Text != "" && CategoriaBox.Text != "")
            {
                _ = lr.PesquisaLivro();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }

        }

        private void btnObterLivro_Click(object sender, EventArgs e)
        {
            EmprestimosRepository emprestimos = new EmprestimosRepository();

            string tit = TituloBox.Text;
            string aut = AutorBox.Text;
            string cat = CategoriaBox.Text;
            string edi = EditoraBox.Text;

            if (tit != "" && aut != "" && cat != "" && edi != "")
            {
                _ = emprestimos.ObterLivro();
                ListaGrid();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
        }

        public void ListaGrid()
        {

            DataTable table = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT Titulo, Autor, Categoria, Editora FROM table_Livros ORDER BY LivrosId DESC";

                    using (SqlCommand _Command = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(_Command))
                        {

                            da.Fill(table);

                            DataView.DataSource = table;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void TutiloList()
        {
            String _sql = "SELECT LivrosId, Titulo FROM table_Livros ORDER BY Titulo";
            
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(_sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dataReader;
                        using (dataReader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(dataReader);

                            TituloBox.DisplayMember = "Titulo";
                            TituloBox.ValueMember = "LivrosId";
                            TituloBox.DataSource = table;

                            dataReader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void AutorList()
        {
            String _sql = "SELECT LivrosId, Autor FROM table_Livros ORDER BY Titulo";

            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(_sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dataReader;
                        using (dataReader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(dataReader);

                            AutorBox.DisplayMember = "Autor";
                            AutorBox.ValueMember = "LivrosId";
                            AutorBox.DataSource = table;

                            dataReader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void CategoriaList()
        {
            String _sql = "SELECT LivrosId, Categoria FROM table_Livros ORDER BY Titulo";

            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(_sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dataReader;
                        using (dataReader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(dataReader);

                            CategoriaBox.DisplayMember = "Categoria";
                            CategoriaBox.ValueMember = "LivrosId";
                            CategoriaBox.DataSource = table;

                            dataReader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void EditoraList()
        {
            String _sql = "SELECT LivrosId, Editora FROM table_Livros ORDER BY Titulo";

            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(_sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dataReader;
                        using (dataReader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(dataReader);

                            EditoraBox.DisplayMember = "Editora";
                            EditoraBox.ValueMember = "LivrosId";
                            EditoraBox.DataSource = table;

                            dataReader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
