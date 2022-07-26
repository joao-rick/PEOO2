using System; 

public class Program {

  public static double Diagonal(double b, double h){
    double q = Math.Sqrt(b*b + h*h);
    return q;
  }
  
  public static void Main(string[] args) {
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(x, y));
  }
}