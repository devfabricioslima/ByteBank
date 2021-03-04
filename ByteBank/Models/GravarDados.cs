using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class GravarDados
    {

        public void GuardarDado()
        {
            string enderecoDoArquivo = "contas.txt";
            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            var buffer = new byte[1024]; // 1kb
            var numeroDeBytesLidos = -1;

            while(numeroDeBytesLidos !=0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            }

            
        }

    }
}
