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
        private int _agencia;
        public int Conta { get; set; }
        public int NumAgencia
        {
            get { return _agencia; }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _agencia = value;
                }
            }
        }

        public Agencia(int conta, int numAgencia)
        {
            Conta = conta;
            NumAgencia = numAgencia;
        }
    }
    public class ContaCorrente
    {
        private double _saldo = 100;

        public static int Id { get; private set; }
        public Cliente Titular { get; set; }
        public Agencia Agencia { get; set; }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {

                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(Cliente titular, Agencia agencia)
        {
            Titular = titular;
            Agencia = agencia;

            Id++;
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

        public double Depositar(double valor)
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
