using QbitTeste.Infra.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QbitTeste.Infra
{
    //Criar tabelas com valores default
    internal class CreateTables
    {

        public async static void Create(String SqlComands)
        {
            String cmd = SqlComands;

            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                conn.Open();

                using (SqlCommand _Command = new SqlCommand(cmd, conn))
                {
                    _Command.CommandType = CommandType.Text;
                    SqlDataReader dataReader;
                    using (dataReader = await _Command.ExecuteReaderAsync())
                    {
                         dataReader.Close();
                    }
                }
                conn.Close();
            }
        }
        public static void CreateTableAlunos()
        {
            string cmd = 
                "IF OBJECT_ID('table_Alunos', 'U') IS NOT NULL" +
                "\r\n   PRINT 'VALIDATE'" +
                "\r\n   ELSE" +
                "\r\n   CREATE TABLE table_Alunos " +
                "(\r\n  Ra int NOT NULL PRIMARY KEY IDENTITY(1,1)," +
                "\r\n   Nome varchar(50)," +
                "\r\n   Email varchar(50)," +
                "\r\n   Telefone varchar(20)," +
                "\r\n   DataDeNascimento date," +
                ");";
            Create(cmd);
        }
        public static void CreateTableLivros()
        {
            string cmd =
                "IF OBJECT_ID('table_Livros', 'U') IS NOT NULL" +
                "\r\n   PRINT 'VALIDATE'" +
                "\r\n   ELSE" +
                "\r\n   CREATE TABLE table_Livros(" +
                "\r\n   LivrosId int NOT NULL PRIMARY KEY IDENTITY(1,1)," +
                "\r\n   Titulo varchar(30)," +
                "\r\n   Autor varchar(50)," +
                "\r\n   Categoria varchar(20)," +
                "\r\n   Editora varchar(20)," +
                ")";
            Create(cmd);
        }        
        public static void CreateTableEmprestimo()
        {
            string cmd = 
                "IF OBJECT_ID('table_Emprestimos', 'U') IS NOT NULL" +
                "\r\n   PRINT 'VALIDATE'" +
                "\r\n   ELSE" +
                "\r\n   CREATE TABLE table_Emprestimos " +
                "(\r\n  EmprestimosId int NOT NULL PRIMARY KEY IDENTITY(1,1)," +
                "\r\n   DataDeRetirada datetime," +
                "\r\n   DataDeEntrega datetime," +
                ")";
            Create(cmd);
        }

    }
}