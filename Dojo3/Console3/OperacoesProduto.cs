using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public class OperacoesProduto : Crud
    {
        public OperacoesProduto()
        {
            this.createOperation = Cadastrar;
            this.readOperation = Listar;
            this.updateOperation = Alterar;
            this.deleteOperation = Deletar;
        }
        private void Cadastrar()
        {
            Produto produto = new Produto();
            Console.WriteLine("Insira as ID do produto");
            produto.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o nome do produto");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Insira o valor do produto");
            produto.Valor = Convert.ToDecimal(Console.ReadLine());
            lista.Add(produto);
        }
        private void Listar()
        {
            if (lista.Count > 0)
            {
                foreach (Produto produto in lista)
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
        private void Alterar()
        {
        }
        private void Deletar()
        {
            Listar();
            Console.Write("Digite o id do produto que deseja deletar: ");
            int id = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            foreach (Produto produto in lista)
            {
                if (produto.Id.Equals(id))
                {
                    encontrado = true;
                    lista.Remove(produto);
                    Console.WriteLine("Produto deletado");
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

    }
}
