using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.FactoryMethod
{
    public class FabricarMoto
    {
        public IMoto FabricarModelo(EMotos modelo)
        {
            switch (modelo)
            {
                case EMotos.CG:
                    return new CG();
                case EMotos.YBR:
                    return new YBR();
                case EMotos.NINJA:
                    return new Ninja();
                case EMotos.BMW:
                    return new Bmw();
                default:
                    return null;
            }
        }
    }
}

