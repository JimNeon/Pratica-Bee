using System;

class URI {
    static void Main(string[] args) {
        // Lê a distância informada (valor inteiro)
        int distancia = int.Parse(Console.ReadLine());

        // Calcula o tempo necessário multiplicando por 2
        int tempo = distancia * 2;

        // Imprime o resultado acompanhado da mensagem " minutos"
        Console.WriteLine(tempo + " minutos");
    }
}
