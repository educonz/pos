using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFuncionarios.ServiceReference1;

namespace WebApplicationFuncionarios
{
    public partial class Funcionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtCarregar_Click(object sender, EventArgs e)
        {
            ServicoFuncionarioSoapClient servico = new ServicoFuncionarioSoapClient();

            try
            {
                var retorno = servico.GetFuncionarios(txtProcurar.Text);
                grvFuncionario.DataSource = retorno;
                grvFuncionario.DataBind();
                servico.Close();
            }
            catch (Exception ex)
            {
                lblRetornoTexto.Text = ex.Message;
            }
        }
    }
}