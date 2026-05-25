using System;

class URI {
    static void Main(string[] args) {
        // Lê a linha única e divide os 3 valores pelos espaços
        string[] linha = Console.ReadLine().Split(' ');
        int A = int.Parse(linha[0]);
        int B = int.Parse(linha[1]);
        int C = int.Parse(linha[2]);

        // 1. Aplica a fórmula para achar o maior entre A e B
        int maiorAB = (A + B + Math.Abs(A - B)) / 2;

        // 2. Compara o maior encontrado antes com o valor de C
        int maiorGeral = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

        // Imprime o resultado final exatamente no formato exigido
        Console.WriteLine(maiorGeral + " eh o maior");
    }
}
