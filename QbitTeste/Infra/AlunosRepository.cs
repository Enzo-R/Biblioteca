using QbitTeste;
using QbitTeste.Infra;
using QbitTeste.Infra.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using testeQbit.Models;
using testeQbit.View;

namespace testeQbit.Infra
{
    public class AlunosRepository 
    {
        IAlunos alunosView;

        public AlunosRepository(IAlunos alunos)
        {
            this.alunosView = alunos;
        }

        public async Task Post()
        {
            Alunos aluno = new Alunos();
            aluno.Nome = alunosView.NomeTxt;
            aluno.Email = alunosView.EmailTxt;
            aluno.Telefone = alunosView.TelefoneTxt;
            aluno.DataDeNascimento = alunosView.DataDeNascimentoData;

            String sql = "INSERT INTO table_Alunos( Nome, Email, Telefone, DataDeNascimento) " +
                            "VALUES ( @Nome, @Email, @Telefone, @DataDeNascimento)";

            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = aluno.Nome;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = aluno.Email;
                        cmd.Parameters.Add("@Telefone", SqlDbType.VarChar, 20).Value = aluno.Telefone;
                        cmd.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = aluno.DataDeNascimento;

                        await cmd.ExecuteScalarAsync();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            
        }
        public void Listar()
        {
            throw new NotImplementedException();
        }

    }
}
