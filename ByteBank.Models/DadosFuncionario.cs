using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public static class DadosFuncionario
    {
        private static List<Funcionario> Lista_Funcionarios = new List<Funcionario>();

        public static IOrderedEnumerable<Funcionario> TodosFuncionarios()
        {
            var funcionarios = Lista_Funcionarios.OrderBy(f => f.Cargo);
            return funcionarios;
        }


        public static IEnumerable<Funcionario> TodosCargo(string cargo)
        {
            var designers = Lista_Funcionarios.Where(d => d.Cargo == cargo);
            return designers;
        }

        public static void CadastrarFuncionario(Funcionario funcionario)
        {
            funcionario.Id = 0;
            if (Lista_Funcionarios.Count != 0)
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

        //public static void FuncionarioCargo(string cargo)
        //{


        //    if (ListaCargos.Count !=0)
        //    {
        //       var item = Lista_Funcionarios.Select<>(i => i.Cargo == cargo);
        //        ListaCargos.Add(item);
        //    }

        //}
    }
}

