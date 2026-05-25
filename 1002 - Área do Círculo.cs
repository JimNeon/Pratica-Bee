using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante que o programa use ponto (.) como separador decimal em qualquer sistema
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // 1. O enunciado define o valor de n (Pi) como constante
        double n = 3.14159;

        // 2. Lê a entrada do usuário e converte para double
        double raio = double.Parse(Console.ReadLine());

        // 3. Calcula a área: n multiplicado por raio ao quadrado (raio * raio)
        double area = n * (raio * raio);

        // 4. Imprime o resultado com a mensagem "A=" e exatamente 4 casas decimais
        Console.WriteLine("A=" + area.ToString("F4"));
    }
}
