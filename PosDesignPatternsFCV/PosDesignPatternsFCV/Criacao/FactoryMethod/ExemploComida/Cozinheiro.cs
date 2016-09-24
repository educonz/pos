using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.FactoryMethod.ExemploComida
{
    public abstract class Cozinheiro
    {
        public void Cozinhar()
        {

        }
        public abstract Comida CriarComida();
    }
}
