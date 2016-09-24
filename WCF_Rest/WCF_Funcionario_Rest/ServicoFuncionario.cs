using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Funcionario_Rest
{
    public class ServicoFuncionario : IFuncionario
    {
        private RepositorioFuncionario repositorio;

        public ServicoFuncionario()
        {
            repositorio = new RepositorioFuncionario();
        }

        public bool InserirFuncionario(string id, string nome, string salario)
        {
            return repositorio.InserirFuncionario(new Funcionario() { Id = Convert.ToInt32(id), Nome = nome, Salario = Convert.ToDouble(salario), DataCadastro = DateTime.Today });
        }

        public List<Funcionario> ListarFuncionario()
        {
            return repositorio.ListarFuncionario();
        }

        public Funcionario SelecionarFuncionario(string id)
        {
            return repositorio.SelecionarFuncionario(id);
        }
    }
}
