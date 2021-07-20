using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Setor { get; set; }


        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string matricula, string setor)
        {
            this.Id = id;
            this.Nome = nome;
            this.Matricula = matricula;
            this.Setor = setor;
        }

        public override string ToString()
        {
            return $"ID: {this.Id} \nNome: {this.Nome} \nMatrícula: {this.Matricula} \nSetor: {this.Setor}";
        }
    }
}
