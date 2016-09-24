using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Funcionario
{
    public class RepositorioFuncionario
    {
        private static List<FuncionarioModel> listaFuncionario;

        public RepositorioFuncionario()
        {
            listaFuncionario = new List<FuncionarioModel>()
            {
                new FuncionarioModel()
                {
                    Id = 1,
                    Nome = "Vitor",
                    Salario = 5000,
                    DataCadastro = DateTime.Today
                },
                new FuncionarioModel()
                {
                    Id = 2,
                    Nome = "Maria",
                    Salario = 1000,
                    DataCadastro = DateTime.Today.AddDays(-5)
                },
            };
        }

        public List<FuncionarioModel> ListarFuncionario()
        {
            return listaFuncionario;
        }

        public FuncionarioModel SelecionarFuncionario(int id)
        {
            return listaFuncionario.Find(x => x.Id == id);
        }
    }
}