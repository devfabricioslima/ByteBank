using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class Diretor:Funcionario
    {
        
        public override double GetBonificacao()
        {
            return this.Salario;
        }
    }
}
