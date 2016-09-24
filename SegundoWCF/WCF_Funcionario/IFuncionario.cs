using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Funcionario
{
    [ServiceContract]
    public interface IFuncionario
    {
        [OperationContract]
        List<Funcionario> ListarFuncionario();

        [OperationContract]
        Funcionario SelecionarFuncionario(int id);
    }
}
