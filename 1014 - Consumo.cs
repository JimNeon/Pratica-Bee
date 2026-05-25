using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante o ponto (.) como separador decimal padrão
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // Lê a distância (inteiro) e o combustível gasto (double)
        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine());

        // Calcula o consumo médio
        double consumoMedio = distancia / combustivel;

        // Imprime o resultado com 3 casas decimais seguido de " km/l"
        Console.WriteLine(consumoMedio.ToString("F3") + " km/l");
    }
}
