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
            if (conta.Agencia.Conta <= 0)
            {
                throw new ArgumentException("O argumento conta deve ser maior que 0,", nameof(conta.Agencia.Conta));
            }
            if (conta.Agencia.NumAgencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0,", nameof(conta.Agencia.NumAgencia));
            }
            

            if(Lista_Correntes.Count != 0)
            {
              conta.Id =  Lista_Correntes.Last<ContaCorrente>().Id +1;
            }

            //conta.TaxaOperacao = 30 / conta.Id;
            Lista_Correntes.Add(conta);
        }

        public static void EliminarConta(int id)
        {
            var item = Lista_Correntes.First<ContaCorrente>(i => i.Id == id);

            Lista_Correntes.Remove(item);
        }

        public static ContaCorrente DadosCliente(int id)
        {
            var conta = Lista_Correntes.Where(i => i.Id == id).FirstOrDefault();

            return conta;
        }

        public static void Depositar(int id, double valor)
        {
            var conta = DadosCliente(id);
            conta.Depositar(valor);    
        }

        public static void Sacar(int id, double valor)
        {
            var conta = DadosCliente(id);
            conta.Sacar(valor);
        }


    }
}
