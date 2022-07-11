using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase:");
        var x = Console.ReadLine();
        var y = x.ToCharArray();
        Array.Reverse(y);
        Console.WriteLine(new string(y));
    }
}