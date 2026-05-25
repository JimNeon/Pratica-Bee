using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante o ponto (.) como separador decimal
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // 1. Lê os dados de entrada
        string nome = Console.ReadLine(); // Lê o nome como texto
        double salarioFixo = double.Parse(Console.ReadLine());
        double totalVendas = double.Parse(Console.ReadLine());

        // 2. Calcula o salário final com os 15% de comissão
        double totalReceber = salarioFixo + (totalVendas * 0.15);

        // 3. Imprime o resultado final com duas casas decimais
        Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2"));
    }
}
