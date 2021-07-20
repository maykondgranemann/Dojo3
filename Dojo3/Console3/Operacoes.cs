using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    class Operacoes
    {
        Produto produto = new Produto();
        public void CadastrarProduto()
        {
            Console.WriteLine("Insira as ID do produto");
            produto.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o nome do produto");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Insira o valor do produto");
            produto.Valor = Convert.ToDecimal(Console.ReadLine());

        }
        public void Update(int id)
        {

        }
        public void Delete(int id)
        {

        }
        public void Listar()
        {

        }
    }
}
