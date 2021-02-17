using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class DadosFuncionario
    {
        private static List<Funcionario> Lista_Funcionarios = new List<Funcionario>();

        public static void CadastrarFuncionario(Funcionario funcionario)
        {
            funcionario.Id = 0;
            if(Lista_Funcionarios.Count != 0)
            {
                funcionario.Id = Lista_Funcionarios.Last<Funcionario>().Id + 1;
            }

            Lista_Funcionarios.Add(funcionario);

        }

        public static void DeletarFuncinario(int id)
        {
            var item = Lista_Funcionarios.First<Funcionario>(i => i.Id == id);

            Lista_Funcionarios.Remove(item);
        }
    }
}
