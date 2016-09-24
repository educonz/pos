using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.FactoryMethod.Exemplo2
{
    public class ConcreteVeiculoFactory : VeiculoFactory
    {
        public override IFactory GetVeiculo(string veiculo)
        {
            switch (veiculo)
            {
                case "Scooter":
                    return new Scooter();
                case "Bicicleta":
                    return new Bicicleta();
                default:
                    return null;
            }
        }
    }
}
