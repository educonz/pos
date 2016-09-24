﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.FactoryMethod
{
    public class FabricaCG : Fabrica
    {
        public override IMoto FabricarMoto()
        {
            return new CG();
        }
    }
}