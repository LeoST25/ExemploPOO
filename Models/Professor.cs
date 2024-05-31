using System;
using System.Globalization;

namespace ExemploPOO.Models {
    public class Professor : Pessoa { //Herança da classe Pessoa
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade}, sou um professor e recebo {Salario.ToString("C", CultureInfo.CurrentCulture)}.");
        }
    }
}
