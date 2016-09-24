using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.AbstractFactory
{
    public class FabricaMotoHonda : IFabricaMoto
    {
        public IMotoLuxo CriarMotoLuxo()
        {
            return new Honda1000cc();
        }

        public IMotoPopular CriarMotoPopular()
        {
            return new HondaBiz();
        }
    }
}
