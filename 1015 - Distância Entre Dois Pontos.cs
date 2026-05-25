using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante o ponto (.) como separador decimal padrão
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // --- PRIMEIRA LINHA (p1) ---
        string[] p1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(p1[0]);
        double y1 = double.Parse(p1[1]);

        // --- SEGUNDA LINHA (p2) ---
        string[] p2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(p2[0]);
        double y2 = double.Parse(p2[1]);

        // --- CÁLCULO ---
        // Calcula os quadrados das diferenças e depois a raiz quadrada de tudo
        double somaDosQuadrados = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
        double distancia = Math.Sqrt(somaDosQuadrados);

        // --- SAÍDA ---
        // Exibe apenas o número com 4 casas decimais (sem nenhuma mensagem antes)
        Console.WriteLine(distancia.ToString("F4"));
    }
}
