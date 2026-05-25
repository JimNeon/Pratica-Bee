using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante o uso do ponto (.) como separador decimal
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // Lê o tempo gasto e a velocidade média (ambos inteiros)
        int tempo = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());

        // Calcula a distância total
        int distancia = tempo * velocidade;

        // Calcula a quantidade de litros usando 12.0 para manter os decimais
        double litrosNecessarios = distancia / 12.0;

        // Imprime o resultado formatado com 3 casas decimais
        Console.WriteLine(litrosNecessarios.ToString("F3"));
    }
}
