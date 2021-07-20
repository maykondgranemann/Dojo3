using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public class ModuloVendedor : Tela
    {
        public ModuloVendedor() : base("Vendedor")
        {
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }
        Operacoes operacao = new Operacoes();
       

        private void Escolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    operacao.CadastrarProduto();
                    break;
                case 2:
                    operacao.ListarProduto();
                    break;
                case 3:
                    operacao.UpdateProduto();
                    break;
                case 4:
                    operacao.DeletaProduto();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

        private int Opcoes()
        {
            int escolha;
            Console.WriteLine("[1] -Cadastrar" +
                            "\n[2] -Listar" +
                            "\n[3] -Editar" +
                            "\n[4] -Deletar" +
                            "\n[0] -Sair");
            Console.WriteLine("**********************************************************");
            Console.Write("Opção:");
            escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }
        
    }
}
