using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante o ponto (.) como separador decimal padrão
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // 1. Lê o raio como double
        double raio = double.Parse(Console.ReadLine());

        // 2. Define o valor de pi dado pelo enunciado
        double pi = 3.14159;

        // 3. Calcula o volume usando 4.0/3.0 para não perder os decimais
        double volume = (4.0 / 3.0) * pi * (raio * raio * raio);

        // 4. Imprime o resultado com espaços e exatamente 3 casas decimais
        Console.WriteLine("VOLUME = " + volume.ToString("F3"));
    }
}
