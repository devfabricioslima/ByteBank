using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class GerenteConta:FuncionarioAutenticavel
    {
        public GerenteConta()
        {
            this.Cargo = "Gerente de Conta";
        }

        public override double GetBonificacao()
        {
            return this.Salario *= 1.8;
        }

        public override void AumentarSalario()
        {
            //base.AumentarSalario();
            this.Salario *= 1.8;
        }
    }
}
