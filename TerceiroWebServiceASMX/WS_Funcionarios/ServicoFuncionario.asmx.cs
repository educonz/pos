using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_Funcionarios
{
    /// <summary>
    /// Summary description for ServicoFuncionario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicoFuncionario : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Funcionario> GetFuncionarios(string nome)
        {
            var list = new List<Funcionario>()
            {
                new Funcionario() { Nome = "Maria", Salario = 100, DataCadastro = DateTime.Now },
                new Funcionario() { Nome = "Joaquim", Salario = 50, DataCadastro = DateTime.Now },
                new Funcionario() { Nome = "Paulo", Salario = 60, DataCadastro = DateTime.Now }
            };

            if (string.IsNullOrEmpty(nome))
                return list;
            else
                return list.Where(x => x.Nome == nome).ToList();
        }
    }
}
