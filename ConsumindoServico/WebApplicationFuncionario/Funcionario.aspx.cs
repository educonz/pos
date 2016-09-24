using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFuncionario.FuncionarioServico;

namespace WebApplicationFuncionario
{
    public partial class Funcionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            FuncionarioClient servico = new FuncionarioClient();

            object lista = null;

            if (string.IsNullOrEmpty(idFuncionario.Text))
            {
                lista = servico.ListarFuncionario();
            }
            else
            {
                lista = new List<object>() { servico.SelecionarFuncionario(Convert.ToInt32(idFuncionario.Text)) };
            }
            
            dgFuncionario.DataSource = lista;
            dgFuncionario.DataBind();
        }
    }
}