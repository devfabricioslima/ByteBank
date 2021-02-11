using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Models;

namespace ByteBank.Models
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; } = 100;

        


        public bool Sacar(double valor)
        {
            
            if (this.Saldo < valor)
            {
                return false;
            }
            else
            {
                this.Saldo -= valor;

                return true;
            }

        }

        public double Depositar( double valor)
        {
            this.Saldo += valor;

            return this.Saldo;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.Saldo < valor)
            {
                return false;
            }
            else
            {
                this.Saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
