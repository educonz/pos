using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace AplicacaoWebService
{
    /// <summary>
    /// Summary description for Servico
    /// </summary>
    [WebService(Namespace = "http://TESTE/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Servico : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string CadastraAluno(string nome)
        {
            return $"Aluno {nome} cadastrado com sucesso";
        }

        [WebMethod]
        public List<string> CarregaAlunos()
        {
            List<string> lista = new List<string>();
            lista.Add("João");
            lista.Add("Maria");
            lista.Add("Gabriel");
            lista.Add("Larissa");

            return lista;
        }
    }
}
