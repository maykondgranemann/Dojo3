using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Console3
{
    class Operacoes
    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Vendedor> vendedores = new List<Vendedor>();

        public void CadastrarProduto()
        {
            Produto produto = new Produto();
            Console.WriteLine("Insira as ID do produto");
            produto.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o nome do produto");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Insira o valor do produto");
            produto.Valor = Convert.ToDecimal(Console.ReadLine());
            produtos.Add(produto);
        }
        public void CadastrarVendedor()
        {
            Vendedor vendedor = new Vendedor();
            Console.WriteLine("Insira o ID do venmdedor:");
            vendedor.Id = Convert.ToInt32(Console.ReadLine());
            CadastroEdita(vendedor);

            vendedores.Add(vendedor);
        }

        private static void CadastroEdita(Vendedor vendedor)
        {
            Console.WriteLine("Insira o nome do vendedor:");
            vendedor.Nome = Console.ReadLine();
            Console.WriteLine("Insira a matricula do vendedor:");
            vendedor.Matricula = Console.ReadLine();
            Console.WriteLine("Insira o setor do vendedor:");
            vendedor.Setor = Console.ReadLine();
        }

        public void UpdateVendedor()
        {
            Vendedor model = new Vendedor();
            ListarVendedor();
            Console.WriteLine("Digite um Id para Alterar:");
            int IdV = Convert.ToInt32(Console.ReadLine());
            foreach (Vendedor vend in vendedores)
            {
                if (IdV.Equals(vend.Id))
                {
                    model = vend;
                    Console.WriteLine("Item Localizado!");
                    break;
                }
                Console.WriteLine("Vendedor não encontrado!");
            }
            if (model.Id == 0)
            {
                Console.WriteLine("Não tem nada aqui");
            }
            else 
            {
                CadastroEdita(model);
            }
        }
        public void UpdateProduto()
        {
        }
        public void DeletaVendedor()
        { 
        }
        public void DeletaProduto()
        {
            ListarProduto();
            Console.Write("Digite o id do produto que deseja deletar: ");
            int id = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            foreach (var produto in produtos)
            {
                if (produto.ID.Equals(id))
                {
                    encontrado = true;
                    produtos.Remove(produto);
                    Console.WriteLine("Produto deletado");
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        public void ListarProduto()
        {
            if (produtos.Count > 0)
            {
                foreach (Produto produto in produtos)
                {
                    Console.WriteLine(produto.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            PausarImpressao();
        }       

        public void ListarVendedor()
        {
            if(vendedores.Count > 0)
            {
                foreach (var vendedor in vendedores)
                {
                    Console.WriteLine(vendedor.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhum vendedor cadastrado.");
            }
            PausarImpressao();
        }

        private static void PausarImpressao()
        {
            Console.Write("Precione qualquer tecla para continuar!");
            Console.ReadLine();
        }
    }
}
