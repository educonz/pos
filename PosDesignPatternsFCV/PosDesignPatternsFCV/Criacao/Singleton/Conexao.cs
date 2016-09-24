using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Criacao.Singleton
{
    public class Conexao
    {
        protected Conexao() { }

        private static Conexao instance = null;
        public static Conexao Instance
        {
            get
            {
                if (instance == null) instance = new Conexao();
                return instance;
            }
            private set { }
        }

        public Dictionary<string, string> Config = new Dictionary<string, string>();

        public string Open()
        {
            string values = "";
            foreach (string key in Config.Keys) values += key + " = " + Config[key] + "|";
            return "conexão aberta: "+values;
        }
    }
}
