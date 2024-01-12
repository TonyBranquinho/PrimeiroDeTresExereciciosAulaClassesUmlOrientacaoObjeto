using PrimeiroDeTresExereciciosAulaClassesUmlOrientacaoObjeto;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a largura e altura do retangulo:");
            retangulo.largura = double.Parse(Console.ReadLine(), CI);
            retangulo.altura = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CI));
            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CI));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CI));
        }
    }
}