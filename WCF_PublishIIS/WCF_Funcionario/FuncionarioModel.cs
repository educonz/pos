using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_Funcionario
{
    [DataContract]
    public class FuncionarioModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public double Salario { get; set; }

        [DataMember]
        public DateTime DataCadastro { get; set; }
    }
}