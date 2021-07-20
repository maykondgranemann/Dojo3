using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public class Menu : Tela
    {
        private ModuloProduto modProduto;
        private ModuloVendedor moduloVendedor;
        public Menu() : base("Bem-Vindo")
        {
            modProduto = new ModuloProduto();
            moduloVendedor = new ModuloVendedor();
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }
      
        
        private int Opcoes()
        {
            int escolha;
            Console.WriteLine("[1] - Modulo Produto" +
                            "\n[2] - Modulo Vendedor" +
                            "\n[0] - Sair");
            Console.WriteLine("***********************************************************");
            Console.Write("Opção:");
            escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }
        

        private void Escolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    modProduto.Executa();
                    break;
                case 2:
                    moduloVendedor.Executa();
                    break; 
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

    }
}
