using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma Frase:");
    string p = Console.ReadLine();
    int x = p.Length;
    for (int i = 1; i <= x; i++) {
      Console.WriteLine($"{i} - {p}");
    }
  }
}