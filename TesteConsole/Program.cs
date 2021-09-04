using System;
using System.Data.SqlClient;
using System.Text;

namespace TesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dadosDB = new Dados();
            Mensagem msg = new Mensagem();

            dadosDB.AbrirConexao();
            msg.ConexaoAberta();

            dadosDB.FecharConexao();
            msg.ConexaoFechada();

        }
    }
}
