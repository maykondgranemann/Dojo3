using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Produto : BaseModel
    { 
        public decimal Valor { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, decimal valor)
        {
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;
        }

        public override string ToString()
        {
            return ($"Id: {Id}, Nome: {Nome}, Valor: {Valor}\n--------");
        }
    }
}
