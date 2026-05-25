using System;

class URI {
    static void Main(string[] args) {
        // Lê os quatro valores inteiros da entrada
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        
        // Calcula a diferença dos produtos usando a fórmula dada
        int diferenca = (A * B) - (C * D);
        
        // Imprime o resultado com a palavra em maiúsculo e os espaços corretos
        Console.WriteLine("DIFERENCA = " + diferenca);
    }
}
