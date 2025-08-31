using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCSHARP.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, string memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na App Store...");
        }
    }
}
