using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Models
{
    public class AutenticacaoHelper
    {
        internal protected bool ComparaSenhas(string senhaVerdaeira, string senhaTentativa)
        {
            return senhaVerdaeira == senhaTentativa;
        }
    }
}
