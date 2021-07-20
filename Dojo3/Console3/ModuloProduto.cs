using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public class ModuloProduto : Tela
    {
        Operacoes operacao = new Operacoes();

        public ModuloProduto() : base("Produto")
        {
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }

        

        private void Escolha(int escolha)
        {
            Console.Clear();
            this.Cabecalho();
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
