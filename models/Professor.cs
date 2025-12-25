using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRAKE.models
{
    public class Professor : Pessoa
    {
         public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário  {Salario}.");
        }
    }
}