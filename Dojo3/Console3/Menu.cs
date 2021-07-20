using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public class Menu
    {
        Operacoes operacao = new Operacoes();
        public void Cabecalho()
        {
            Console.WriteLine("************************Bem vindo**************************" +
                            "\n***********************************************************");
        }
        
        public void Opcoes()
        {
            Console.WriteLine("1-Cadastra Produto\n2-Cadastra Vendedor\n0-Sair");
            Console.WriteLine("***********************************************************");
        }
        public void CriarMenu()
        {
            int escolha = 0;

            Cabecalho();
            Opcoes();
            do
            {
                Console.Write("Opção:");
                try
                {
                    escolha = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                }
                switch (escolha)
                {
                    case 1:
                        operacao.CadastrarProduto();
                        Cabecalho();
                        Opcoes();
                        break;
                    case 2:
                        operacao.CadastrarVendedor();
                        Cabecalho();
                        Opcoes();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (escolha != 0);
        }

        
    }
}
