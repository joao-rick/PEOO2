using System; 

public class Program {

  public static int Soma(int inicio, int fim) {
    int soma = fim*(inicio+fim)/2;
    return soma;
  }
  
  public static void Main(string[] args) {
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine(Soma(x, y));
  }
}