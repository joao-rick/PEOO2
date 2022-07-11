using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase:");
        var x = Console.ReadLine();
        var y = x.Substring(1) + x[0];
        while (y != x) {
            Console.WriteLine(y);
            y = y.Substring(1) + y[0];
        }
        Console.WriteLine(y);
    }
}