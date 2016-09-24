using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercicio.Models
{
    public class CalcPrecoPrazo
    {
        public int Id { get; set; }
        public string CdEmpresa { get; set; }
        public string DsSenha { get; set; }
        public string CdServico { get; set; }
        public string CepOrigem { get; set; }
        public string CepDestino { get; set; }
        public string VlPeso { get; set; }
        public int CdFormato { get; set; }
        public decimal VlComprimento { get; set; }
        public decimal VlAltura { get; set; }
        public decimal VlLargura { get; set; }
        public decimal VlDiametro { get; set; }
        public string CdMaoPropria { get; set; }
        public decimal VlValorDeclarado { get; set; }
        public string CdAvisoRecebimento { get; set; }
    }
}