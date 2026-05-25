using System;

class URI {
    static void Main(string[] args) {
        // Lê a quantidade total de dias
        int totalDias = int.Parse(Console.ReadLine());

        // 1. Calcula os anos e guarda o resto
        int anos = totalDias / 365;
        int resto = totalDias % 365;

        // 2. Calcula os meses e os dias a partir do que sobrou
        int meses = resto / 30;
        int dias = resto % 30;

        // 3. Imprime as três linhas de saída no formato exato exigido
        Console.WriteLine(anos + " ano(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");
    }
}
