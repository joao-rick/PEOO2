using System; 

public class Program {

  public static void Main(string[] args) {
    for (int e = 1; e <= 10; e++) {
      Console.WriteLine($"Tabuada de {e}");
      for (int d = 1; d <= 10; d++) {
        Console.WriteLine(e + " x " + d + " = " + e*d);
      }
      Console.WriteLine(); 
    }
  }
}