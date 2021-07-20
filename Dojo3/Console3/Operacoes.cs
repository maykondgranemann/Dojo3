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
            vendedor.Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o nome do vendedor:");
            vendedor.Nome = Console.ReadLine();
            Console.WriteLine("Insira a matricula do vendedor:");
            vendedor.Matricula = Console.ReadLine();
            Console.WriteLine("Insira o setor do vendedor:");
            vendedor.Setor = Console.ReadLine();

            vendedores.Add(vendedor);
        }
        public void Update(int id)
        {

        }
        public void DeletaProduto(int id)
        {
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
        }
        public void Listar()
        {

        }
    }
}
