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
            conta.Id = 0;

            if(Lista_Correntes.Count != 0)
            {
              conta.Id =  Lista_Correntes.Last<ContaCorrente>().Id +1;
            }

            Lista_Correntes.Add(conta);
        }

        public static void EliminarConta(int id)
        {
            var item = Lista_Correntes.First<ContaCorrente>(i => i.Id == id);

            Lista_Correntes.Remove(item);
        }


    }
}
