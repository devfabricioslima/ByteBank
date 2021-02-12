using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Models;

namespace ByteBank.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
    }

    public class Agencia
    {
        public int NumAgencia { get; set; }
        public int Conta { get; set; }

        
    }
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public Agencia Agencia { get; set; }
        private double Saldo { get; set; } = 100;



        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {

            }
            else
            {
                this.Saldo = saldo;
            }
        }
        public double ObterSaldo()
        {
            return this.Saldo;
        }

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
