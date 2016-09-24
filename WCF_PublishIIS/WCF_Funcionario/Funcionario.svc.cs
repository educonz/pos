using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Funcionario
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Funcionario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Funcionario.svc or Funcionario.svc.cs at the Solution Explorer and start debugging.
    public class Funcionario : IFuncionario
    {
        private static RepositorioFuncionario repositorio;

        public Funcionario()
        {
            repositorio = new RepositorioFuncionario();
        }

        public List<FuncionarioModel> ListarFuncionario()
        {
            return repositorio.ListarFuncionario();
        }

        public FuncionarioModel SelecionarFuncionario(int id)
        {
            return repositorio.SelecionarFuncionario(id);
        }
    }
}
