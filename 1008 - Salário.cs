using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante o ponto (.) como separador decimal padrão
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // 1. Lê os dados de entrada
        int numero = int.Parse(Console.ReadLine());
        int horasTrabalhadas = int.Parse(Console.ReadLine());
        double valorPorHora = double.Parse(Console.ReadLine());

        // 2. Calcula o salário total
        double salario = horasTrabalhadas * valorPorHora;

        // 3. Imprime as duas linhas de saída com os espaços exatos
        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
    }
}
