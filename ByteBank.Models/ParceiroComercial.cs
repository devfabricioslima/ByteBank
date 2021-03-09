using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class ParceiroComercial:IAutenticavel
    {
        private readonly AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.ComparaSenhas(Senha, senha);
        }
    }
}
