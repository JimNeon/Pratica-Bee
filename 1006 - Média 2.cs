using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Define o ponto (.) como separador decimal padrão
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // Lê as três notas de dupla precisão (double)
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        // Calcula a média com seus respectivos pesos
        double media = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;

        // Exibe o resultado com uma casa decimal (F1) e os espaços corretos
        Console.WriteLine("MEDIA = " + media.ToString("F1"));
    }
}
