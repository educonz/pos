using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF_Funcionario;

namespace SelfHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServicoFuncionario));
            host.AddServiceEndpoint(typeof(IFuncionario), new BasicHttpBinding(), new Uri("http://localhost:8081"));
            try
            {
                host.Open();

                Console.WriteLine($"O servico {host.Description.ServiceType} está online");
                host.Description.Endpoints.ToList().ForEach(x =>
                    Console.WriteLine(x.Address)
                );

                Console.ReadLine();
                host.Close();
            }
            catch(Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
