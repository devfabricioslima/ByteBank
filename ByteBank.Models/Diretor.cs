using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class Diretor:FuncionarioAutenticavel
    {
        public Diretor()
        {
            this.Cargo = "Diretor";
        }

        public override double GetBonificacao()
        {
            return this.Salario *= 1.5;
        }

        public override void AumentarSalario()
        {
            //base.AumentarSalario();
            this.Salario *= 1.5;
        }

    }
}
