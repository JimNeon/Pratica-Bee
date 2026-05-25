using System;

class URI {
    static void Main(string[] args) {
        int totalSegundos = int.Parse(Console.ReadLine());

        int horas = totalSegundos / 3600;
        int resto = totalSegundos % 3600;

        int minutos = resto / 60;
        int segundos = resto % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
    }
}
