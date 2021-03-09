using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Models;

namespace ByteBank.Extensoes
{
    public class LerDados
    {
        string enderecoDoArquivo = "contas.txt";

        //public void GuardarDado()
        //{

        //    using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        //    {
        //        var buffer = new byte[1024]; // 1kb
        //        var numeroDeBytesLidos = -1;

        //        while (numeroDeBytesLidos != 0)
        //        {
        //            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
        //            EscreverBuffer(buffer, numeroDeBytesLidos);
        //        }
        //    }
        //}

        public static void LerStream()
        {
            using (var fluxoDoArquivo = new FileStream("contas.txt", FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var cliente = ConverterParaContaCorrente(linha);
                    Dados.adicionarCliente(cliente);
                }
            }
        }

        public static ContaCorrente ConverterParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(",");
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.',',');
            var nomeTitular = campos[3];

            var Agencia = int.Parse(agencia);
            var Numero = int.Parse(numero);
            var Saldo = double.Parse(saldo);

            var resultado = new ContaCorrente();
            var conta = new Agencia();
            var cliente = new Cliente();

            conta.NumAgencia = Agencia;
            conta.Conta = Numero;
            resultado.Saldo = Saldo;
            cliente.Nome = nomeTitular;

            resultado.Agencia = conta;
            resultado.Titular = cliente;

            return resultado;
        }
        public void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = new UTF8Encoding();

            var texto = utf8.GetString(buffer, 0, bytesLidos);
        }

    }
}
