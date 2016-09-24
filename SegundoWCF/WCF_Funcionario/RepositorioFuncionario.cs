using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Funcionario
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

        public Funcionario SelecionarFuncionario(int id)
        {
            return listaFuncionario.Find(x => x.Id == id);
        }
    }
}
