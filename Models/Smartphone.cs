using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenger_poo.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public void Ligar(string numero){
            Console.WriteLine("Ligando para o número: " + numero);
        }

        public void ReceberLigacao() {
            Console.WriteLine("Recebendo ligação");
        }

        public abstract void InstalarAplicativo(string aplicativo);
    }
}