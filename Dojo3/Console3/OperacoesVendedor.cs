using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Console3
{
    public class OperacoesVendedor : Crud
    {
        public OperacoesVendedor()
        {
            this.createOperation = Cadastrar;
            this.readOperation = Listar;
            this.updateOperation = Alterar;
            this.deleteOperation = Deletar;
        }
      
        private void Cadastrar()
        {
            Vendedor vendedor = new Vendedor();
            Console.WriteLine("Insira o ID do vendedor:");
            vendedor.Id = Convert.ToInt32(Console.ReadLine());
            CadastroAlterar(vendedor);
            lista.Add(vendedor);
        }

        private void CadastroAlterar(Vendedor vendedor)
        {
            Console.WriteLine("Insira o nome do vendedor:");
            vendedor.Nome = Console.ReadLine();
            Console.WriteLine("Insira a matricula do vendedor:");
            vendedor.Matricula = Console.ReadLine();
            Console.WriteLine("Insira o setor do vendedor:");
            vendedor.Setor = Console.ReadLine();
        }

        private void Listar()
        {
            if (lista.Count > 0)
            {
                foreach (Vendedor vendedor in lista)
                {
                    Console.WriteLine(vendedor);
                }
            }
            else
            {
                Console.WriteLine("Nenhum vendedor cadastrado.");
            }
            PausarImpressao();
        }

        private void Alterar()
        {
            Vendedor model = new Vendedor();
            Listar();
            Console.WriteLine("Digite um Id para Alterar:");
            int IdV = Convert.ToInt32(Console.ReadLine());
            foreach (Vendedor vend in lista)
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
                CadastroAlterar(model);
            }
        }
        
        private void Deletar()
        { 
        }       
           
    }
}
