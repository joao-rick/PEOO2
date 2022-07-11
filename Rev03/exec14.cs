using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var x = Console.ReadLine().Split();

         for (int i = 0; i < x.Length; i++) {
            var y = x[i].ToCharArray();
            Array.Reverse(y);
            Console.WriteLine(new string(y));
         }   
    }
}