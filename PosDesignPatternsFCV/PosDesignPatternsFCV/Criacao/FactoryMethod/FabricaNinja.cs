using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.FactoryMethod
{
    class FabricaNinja : Fabrica
    {
        public override IMoto FabricarMoto()
        {
            return new Ninja();
        }
    }
}
