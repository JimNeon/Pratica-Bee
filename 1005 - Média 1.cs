using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante o ponto (.) como separador decimal
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // Lê as duas notas como double
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        // Calcula a média ponderada
        double media = ((A * 3.5) + (B * 7.5)) / 11.0;

        // Imprime o resultado com espaços e exatamente 5 casas decimais (F5)
        Console.WriteLine("MEDIA = " + media.ToString("F5"));
    }
}
