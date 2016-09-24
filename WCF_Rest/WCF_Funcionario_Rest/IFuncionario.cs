using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Funcionario_Rest
{
    [ServiceContract]
    public interface IFuncionario
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Funcionarios")]
        List<Funcionario> ListarFuncionario();

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetFuncionario/{id}")]
        Funcionario SelecionarFuncionario(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "InserirFuncionario/{id};{nome};{salario}")]
        bool InserirFuncionario(string id, string nome, string salario);
    }
}
