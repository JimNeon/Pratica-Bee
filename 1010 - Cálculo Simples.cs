using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante o ponto (.) como separador decimal padrão
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // --- PRIMEIRA LINHA ---
        // Lê a linha 1 e divide os valores pelos espaços
        string[] linha1 = Console.ReadLine().Split(' ');
        int codigo1 = int.Parse(linha1[0]);
        int qte1 = int.Parse(linha1[1]);
        double valor1 = double.Parse(linha1[2]);

        // --- SEGUNDA LINHA ---
        // Lê a linha 2 e divide os valores pelos espaços
        string[] linha2 = Console.ReadLine().Split(' ');
        int codigo2 = int.Parse(linha2[0]);
        int qte2 = int.Parse(linha2[1]);
        double valor2 = double.Parse(linha2[2]);

        // --- CÁLCULO ---
        double total = (qte1 * valor1) + (qte2 * valor2);

        // --- SAÍDA ---
        // Exibe o resultado com duas casas decimais
        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
    }
}
