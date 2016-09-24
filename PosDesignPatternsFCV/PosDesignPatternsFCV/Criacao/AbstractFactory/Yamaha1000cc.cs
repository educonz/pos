using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.AbstractFactory
{
    public class Yamaha1000cc : IMotoLuxo
    {
        public string ExibirInfoLuxo()
        {
            return "Yamaha 1000cc de luxo";
        }
    }
}
