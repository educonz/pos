using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_ALUNO
{
    /// <summary>
    /// Summary description for ServicoAluno
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicoAluno : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
           return "Hello World";
        }

        [WebMethod]
        public List<Aluno> CarregaAluno()
        {
            List<Aluno> listaAluno = new List<Aluno>()
            {
                new Aluno { Nome = "Maria", Nota = 10.5 },
                new Aluno { Nome = "Evandro", Nota = 6.9 },
                new Aluno { Nome = "Carla", Nota = 7.1 },
                new Aluno { Nome = "Viviani", Nota = 3.0 }
            };

            return listaAluno;
        }
    }
}
