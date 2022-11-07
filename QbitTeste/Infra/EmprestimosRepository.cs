using QbitTeste.Infra.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeQbit.Models;
using testeQbit.View;
using QbitTeste;

namespace testeQbit.Infra
{
    public class EmprestimosRepository
    {


        public async Task ObterLivro()
        {
            String sql = "INSERT INTO table_Emprestimos( DataDeRetirada, DataDeEntrega ) " +
                            "VALUES ( @DataDeRetirada, @DataDeEntrega)";

            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@DataDeRetirada", SqlDbType.Date).Value = DateTime.Now;
                        cmd.Parameters.Add("@DataDeEntrega", SqlDbType.Date).Value = DateTime.Now.AddDays(15);
                        await cmd.ExecuteScalarAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    conn.Close();
                }
            }
        }
    }
}
