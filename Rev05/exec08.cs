using System; 

public class Program {

  public static int MenorInteiro(double x){
    int y = (int)(Math.Ceiling((x)));
    return y;
  }
  
  public static void Main(string[] args) {
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(x));
  }
}