using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public abstract class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; protected set; }

        public Funcionario()
        {

        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
        
    }
}
