using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCSHARP.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        public string Modelo { get; set; }

        public string IMEI { get; set; }

        public string Memoria { get; set; }

        public Smartphone(string numero, string modelo, string iMEI, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

    }
}
