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
            Console.WriteLine("[1] -Cadastra Produto" +
                            "\n[2] -Cadastra Vendedor" +
                            "\n[3] -Listar Produtos" +
                            "\n[4] -Listar Vendedores" +
                            "\n[5] -Editar Vendedor" +
                            "\n[6] -Deletar Produto" +
                            "\n[0] -Sair");
            Console.WriteLine("***********************************************************");
        }
        public void CriarMenu()
        {
                int escolha = 0;
            do
            {
                Console.Clear();
                Cabecalho();
                Opcoes();
                Console.Write("Opção:");
                escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        operacao.CadastrarProduto();
                        break;
                    case 2:
                        operacao.CadastrarVendedor();
                        break;
                    case 3:
                        operacao.ListarProduto();
                        Console.Write("Precione qualquer tecla para continuar!");
                        Console.ReadLine();
                        break;
                    case 4:
                        operacao.ListarVendedor();
                        Console.Write("Precione qualquer tecla para continuar!");
                        Console.ReadLine();
                        break;
                    case 5:
                        operacao.Update();
                        break;
                    case 6:
                        operacao.ListarProduto();
                        Console.Write("Digite o id do produto que deseja deletar: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        operacao.DeletaProduto(id);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (escolha != 0);
        }

        
    }
}
