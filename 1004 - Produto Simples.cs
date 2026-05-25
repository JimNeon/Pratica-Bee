using System;

class URI {
    static void Main(string[] args) {
        // Lê os dois valores inteiros da entrada
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = int.Parse(Console.ReadLine());
        
        // Calcula o produto (multiplicação) entre eles
        int PROD = valor1 * valor2;
        
        // Imprime o resultado mantendo os espaços antes e depois do igual
        Console.WriteLine("PROD = " + PROD);
    }
}
