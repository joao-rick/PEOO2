using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase:");
        var x = Console.ReadLine().Split();

        foreach (string y in x) {
            Console.Write(y[y.Length-1]);
        }
    }
}