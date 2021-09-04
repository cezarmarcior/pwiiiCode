using System;
using System.Data.SqlClient;
using System.Text;

namespace TesteConsole
{
    public class Dados
    {
        private String textoConexao;
        private SqlConnection sqlConnection;

        public Dados()
        {
            sqlConnection = null;
            textoConexao = String.Empty;
            textoConexao = TextoConexao();
        }

        public void FecharConexao()
        {
            sqlConnection.Close();
        }

        public void AbrirConexao()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = textoConexao;
            sqlConnection.Open();
        }

        private String TextoConexao()
        {
            StringBuilder retornoTextoConexao = new StringBuilder();

            retornoTextoConexao.Append("Data Source = localhost;");
            retornoTextoConexao.Append("Initial Catalog = AULATESTE;");
            retornoTextoConexao.Append("User ID=sa;");
            retornoTextoConexao.Append("Password = reallyStrongPwd123;");

            return retornoTextoConexao.ToString();
        }
    }
}
