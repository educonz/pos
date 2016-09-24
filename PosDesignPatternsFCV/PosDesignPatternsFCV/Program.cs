using PosDesignPatternsFCV.Criacao.AbstractFactory;
using PosDesignPatternsFCV.Criacao.FactoryMethod;
using PosDesignPatternsFCV.Criacao.FactoryMethod.ExemploComida;
using PosDesignPatternsFCV.Criacao.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> par = new Dictionary<string, string>();
            //par.Add("BD", "ORACLE");
            //par.Add("USER", "TESTE");
            //par.Add("PASS", "SENHA");
            //Conexao con = Conexao.Instance;
            //con.Config = par;
            ////Console.WriteLine(con.Open());

            //Conexao con2 = Conexao.Instance;
            //con2.Config = par;


            ////Console.WriteLine(con2.Open());
            //if (con.Equals(con2))
            //    Console.WriteLine("IGUAL");
            //else
            //    Console.WriteLine("DIFERENTE");
            //Console.ReadKey();

            //Crepusculo crep = new Crepusculo();
            //StarWars wars = new StarWars();
            //Cinema cinema = new Cinema();
            //cinema.EntrarCinema(crep);
            //cinema.EntrarCinema(wars);

            //var fabrica = new FabricarMoto();
            //var cg = fabrica.FabricarModelo(EMotos.CG);
            //var ybr = fabrica.FabricarModelo(EMotos.YBR);

            //List<Fabrica> lst = new List<Fabrica>();
            //lst.Add(new FabricaCG());
            //lst.Add(new FabricaYBR());
            //lst.Add(new FabricaNinja());
            //lst.Add(new FabricaBmw());

            //foreach(Fabrica item in lst)
            //    Console.WriteLine(item
            //        .FabricarMoto().ExibirModelo());

            //Cozinheiro coz = new Pizzaiolo();
            //Console.WriteLine(coz.CriarComida());

            FabricaMotoHonda fb = new FabricaMotoHonda();
            Console.WriteLine(fb.CriarMotoLuxo().ExibirInfoLuxo());

            FabricaMotoYamaha fb2 = new FabricaMotoYamaha();
            Console.WriteLine(fb2.CriarMotoPopular().ExibirInfoPopular());

            Console.ReadKey();
        }
    }
}
