using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.FactoryMethod
{
    public class Cinema
    {
        public void EntrarCinema(IBilhete bilhete)
        {
            if (bilhete.Validar())
            {
                Console.WriteLine("Acesso permitido");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
            Console.ReadKey();
        }
    }

    public class Crepusculo : IBilhete
    {
        public bool Validar()
        {
            return false;
        }
    }

    public class StarWars : IBilhete
    {
        public bool Validar()
        {
            return true;
        }
    }

    public interface IBilhete
    {
        bool Validar();
    }
}
