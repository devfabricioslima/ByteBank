using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public static class Dados
    {
        private static List<ContaCorrente> Lista_Correntes = new List<ContaCorrente>();


        //Devolve todos os dados da lista
        public static IEnumerable<ContaCorrente> Todos_Correntes
        {
            get
            {
                return Lista_Correntes;
            }

        }


        public static void adicionarCliente(ContaCorrente conta)
        {
            Lista_Correntes.Add(conta);
        }



    }
}
