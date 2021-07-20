using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public Produto()
        {

        }

        public Produto(int id,string nome,decimal valor)
        {
            this.ID = id;
            this.Nome = nome;
            this.Valor = valor;
        }

        public override string ToString()
        {
            return ($"Id: {ID}, Nome: {Nome}, Valor: {Valor}\n--------");
        }
    }
}
