using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationAlunos.ServiceReference1;

namespace WebApplicationAlunos
{
    public partial class Alunos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblRetorno.Text = "";
            lblRetornoTexto.Text = "";
        }

        protected void txtCarregar_Click(object sender, EventArgs e)
        {
            ServicoAlunoSoapClient servico = new ServicoAlunoSoapClient();
            
            try
            {
                var retorno = servico.CarregaAluno();
                grvAluno.DataSource = retorno;
                grvAluno.DataBind();
                servico.Close();
            }
            catch(Exception ex)
            {
                lblRetornoTexto.Text = ex.Message;
            }
        }
    }
}