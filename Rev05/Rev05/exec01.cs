using System; 

public class Program {

  public static double Menor(double x, double y) {
    double menor = 0;
    if (x <= y) menor = x;
    if (y <= x) menor = y;
    return menor;
  }
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine(Menor(a, b));
  }
}