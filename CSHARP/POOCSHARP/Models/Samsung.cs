using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCSHARP.Models
{
    public class Samsung : Smartphone
    {
        public Samsung(string numero, string modelo, string iMEI, string memoria) : base(numero, modelo, iMEI, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na Google Play Store...");
        }
    }
    
}
