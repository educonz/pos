using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.FactoryMethod.Exemplo2
{
    public abstract class VeiculoFactory
    {
        public abstract IFactory GetVeiculo(string veiculo);
    }
}
