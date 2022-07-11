using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var x = Console.ReadLine().Split();

        Console.WriteLine(x.Length);
    }
}