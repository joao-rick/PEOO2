using System; 

public class Program {

  public static double AreaCirculo(double raio){
    double r = 3.14*raio*raio;
    return r;
  }
  
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(a));
  }
}