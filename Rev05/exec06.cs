using System; 

public class Program {

  public static double Frete(double massa, double distancia){
    double x = massa*distancia/100;
    return x;
  }
  
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine($"R$ {Frete(a, b):f2}");
  }
}