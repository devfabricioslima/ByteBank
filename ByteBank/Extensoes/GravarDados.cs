using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Extensoes
{
    public class GravarDados
    {

        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxodeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "";
                var enconding = Encoding.UTF8;

                var bytes = enconding.GetBytes(contaComoString);
            }
        }


        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo, Encoding.UTF8))
            {
                escritor.WriteLine();
                escritor.Flush();

            }
        }
    }
}
