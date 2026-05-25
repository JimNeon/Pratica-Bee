using System;

class URI {
    static void Main(string[] args) {
        // Lê os dois valores inteiros da entrada
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        
        // Calcula a soma e armazena na variável SOMA
        int SOMA = A + B;
        
        // Imprime o resultado com os espaços obrigatórios antes e depois do igual
        Console.WriteLine("SOMA = " + SOMA);
    }
}
