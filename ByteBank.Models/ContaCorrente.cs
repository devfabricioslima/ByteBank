﻿using System;
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

        //public Cliente(string nome, string cPF)
        //{
        //    Nome = nome;
        //    CPF = cPF;
        //}
    }

    public class Agencia
    {
        public int Conta { get; set; }
        public int NumAgencia{ get; set; }

        //public Agencia(int conta, int numAgencia)
        //{
        //    Conta = conta;
        //    NumAgencia = numAgencia;
        //}
    }

    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank. 
    /// </summary>
    public class ContaCorrente
    {
        public double TaxaOperacao { get; set; }

        public int Id { get; set; }
        public Cliente Titular { get; set; }
        public Agencia Agencia { get; set; }
        public double Valor { get; set; }

        public int ContadorSaqueNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidos { get; private set; }


        public double Saldo { get; set; }

        //public ContaCorrente()
        //{
        //    Id++;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"> O <paramref name="valor"/> informado deve ser maior que 0 e menor que o <see cref="Saldo" /> da conta</param>
        /// <returns>Retorna o saldo menos o valor sacado</returns>
        public double Sacar(double valor)
        {

            if (valor < 0)
            {
                throw new ArgumentException(" Valor inválido para o saque.", nameof(valor));
            }
            if (this.Saldo < valor)
            {
                ContadorSaqueNaoPermitidos++;
                throw new SaldoInsuficienteException("Saldo Insuficente para o valor de" + valor);
            }
            else
            {
                this.Saldo -= valor;

                return Saldo;
            }

        }

        public double Depositar(double valor)
        {
            this.Saldo += valor;

            return this.Saldo;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para tranferencia", nameof(valor));
            }
            try
            {

            }
            catch (SaldoInsuficienteException ex)
            {
                Sacar(valor);
                ContadorTransferenciasNaoPermitidos++;
                throw new OperacaoFinanceriaException("Operação não realizada", ex);
            }
            contaDestino.Depositar(valor);
                
        }
    }
}
