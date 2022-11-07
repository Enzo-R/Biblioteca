using QbitTeste.Infra.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using testeQbit.Models;
using QbitTeste;
using System.Threading.Tasks;
using testeQbit.View;
using System.Windows.Forms;

namespace testeQbit.Infra
{
    public class LivrosRepository 
    {
        ILivros ilivrosView;
        public LivrosRepository(ILivros ilivrosView)
        {
            this.ilivrosView = ilivrosView;
        }

        public async Task PesquisaLivro()
        {
            Livros livros = new Livros();

            livros.Titulo = ilivrosView.TituloTxt;
            livros.Autor = ilivrosView.AutorTxt;
            livros.Categoria = ilivrosView.CategoriaTxt;
            livros.Editora = ilivrosView.EditoraTxt;

            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT Titulo, Autor FROM table_Livros WHERE Titulo = '"+livros.Titulo+"' AND Autor = '"+ livros.Autor +"'";

                    using (SqlCommand _Command = new SqlCommand(sql, conn))
                    {
                        _Command.CommandType = CommandType.Text;

                        using (SqlDataReader dr = _Command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                MessageBox.Show("Seu livro "+livros.Titulo+" escrito pelo autor "+livros.Autor+" foi encontrado!!");
                                //verifica se os dados da tabela são iguais aos parametros 
                                //caso contrario insere novos dados.
                            }
                            else
                            {
                                if (!dr.IsClosed) { dr.Close(); }

                                sql = "INSERT INTO table_Livros(Titulo, Autor, Categoria, Editora) " +
                                "VALUES (@Titulo, @Autor, @Categoria, @Editora)";

                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                {
                                    cmd.CommandType = CommandType.Text;
                                    int id = livros.LivrosId;

                                    cmd.Parameters.Add("@Titulo", SqlDbType.VarChar, 30).Value = livros.Titulo;
                                    cmd.Parameters.Add("@Autor", SqlDbType.VarChar, 50).Value = livros.Autor;
                                    cmd.Parameters.Add("@Categoria", SqlDbType.VarChar, 20).Value = livros.Categoria;
                                    cmd.Parameters.Add("@Editora", SqlDbType.VarChar, 20).Value = livros.Editora;

                                    await cmd.ExecuteScalarAsync();


                                    MessageBox.Show("Seu livro " + livros.Titulo + " foi adicionado com sucesso" + "\n" + "     Clique em Obter para retira-lo");

                                }
                            }
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
