using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        // Garante o ponto (.) como separador decimal padrão
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // Lê a linha com os três valores e faz a divisão pelo espaço
        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        // Executa os cálculos das áreas
        double triangulo = (A * C) / 2.0;
        double circulo = 3.14159 * (C * C);
        double trapezio = ((A + B) * C) / 2.0;
        double quadrado = B * B;
        double retangulo = A * B;

        // Imprime os resultados mantendo o padrão exigido de espaços e maiúsculas
        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
    }
}
