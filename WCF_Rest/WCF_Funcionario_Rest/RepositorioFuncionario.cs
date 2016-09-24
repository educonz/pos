using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Funcionario_Rest
{
    public class RepositorioFuncionario
    {
        private static List<Funcionario> listaFuncionario;

        public RepositorioFuncionario()
        {
            listaFuncionario = new List<Funcionario>()
            {
                new Funcionario()
                {
                    Id = 1,
                    Nome = "Vitor",
                    Salario = 5000,
                    DataCadastro = DateTime.Today
                },
                new Funcionario()
                {
                    Id = 2,
                    Nome = "Maria",
                    Salario = 1000,
                    DataCadastro = DateTime.Today.AddDays(-5)
                },
            };
        }

        public List<Funcionario> ListarFuncionario()
        {
            return listaFuncionario;
        }

        public Funcionario SelecionarFuncionario(string id)
        {
            return listaFuncionario.Find(x => x.Id == Convert.ToInt32(id));
        }

        public bool InserirFuncionario(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                listaFuncionario.Add(funcionario);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
