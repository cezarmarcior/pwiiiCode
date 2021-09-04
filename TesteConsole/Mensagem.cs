using System;
namespace TesteConsole
{
    public class Mensagem
    {
        private String textoMensagem;

        public String InserirTexto
        {
            set { textoMensagem = value; }
            get { return textoMensagem;  }
        }

        public Mensagem()
        {
            textoMensagem = String.Empty;
        }
        public void NovaMensagem()
        {
            Console.WriteLine(textoMensagem);
        }

        public void ParaConsole()
        {
            Console.ReadKey();
        }

        public void ConexaoAberta()
        {
            Console.WriteLine("Conexao aberta...");
        }

        public void ConexaoFechada()
        {
            Console.WriteLine("Conexao fechada...");
        }
    }
}
