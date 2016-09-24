using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.AbstractFactory
{
    public class HondaBiz : IMotoPopular
    {
        public string ExibirInfoPopular()
        {
            return "Honda Biz popular";
        }
    }
}
