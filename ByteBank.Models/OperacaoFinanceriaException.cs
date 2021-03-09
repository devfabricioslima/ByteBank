using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class OperacaoFinanceriaException : Exception
    {

        public OperacaoFinanceriaException()
        {

        }

        public OperacaoFinanceriaException(string mensagem) : base(mensagem)
        {

        }

        public OperacaoFinanceriaException( string mensagem,Exception excecaoInterna) : base(mensagem , excecaoInterna)
        {

        }
    }
}
