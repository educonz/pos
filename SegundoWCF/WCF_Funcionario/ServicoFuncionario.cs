using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Funcionario
{
    public class ServicoFuncionario : IFuncionario
    {
        private RepositorioFuncionario repositorio;

        public ServicoFuncionario()
        {
            repositorio = new RepositorioFuncionario();
        }

        public List<Funcionario> ListarFuncionario()
        {
            return repositorio.ListarFuncionario();
        }

        public Funcionario SelecionarFuncionario(int id)
        {
            return repositorio.SelecionarFuncionario(id);
        }
    }
}
