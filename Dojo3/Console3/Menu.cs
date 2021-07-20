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
            Console.WriteLine("1-Cadastra Produto\n2-Cadastra Vendedor\n3-Listar Produtos\n4-Listar Vendedores\n5-Deletar Produto por id\n0-Sair");
            Console.WriteLine("***********************************************************");
        }
        public void CriarMenu()
        {
                int escolha = 0;
            do
            {
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
                        break;
                    case 4:
                        operacao.ListarVendedor();
                        break;
                    case 5:
                        Console.Clear();
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
