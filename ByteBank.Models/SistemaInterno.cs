using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class SistemaInterno
    {
        public string Mensagem { get;private set; }
        public bool Logar(IAutenticavel funcionario , string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                this.Mensagem = $"Bem vindo";

                return true;
            }
            else
            {
                this.Mensagem = $"Senha Incorreta";
                return false;
            }
        }
    }
}
