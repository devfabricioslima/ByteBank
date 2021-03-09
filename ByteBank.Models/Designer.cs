using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class Designer : Funcionario
    {

        public Designer()
        {
            this.Cargo = "Designer";
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.2 ;
        }

        public override double GetBonificacao()
        {
            return this.Salario *= 1.2;
        }
    }
}
