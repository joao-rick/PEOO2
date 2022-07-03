using System; 

public class Program {

  public static void Main(string[] args) {
    
    int num = int.Parse(Console.ReadLine());
    
    for (int i = 1; i <= num; i++) {
      string[] n = Console.ReadLine().Split(' ');
      double x = double.Parse(n[0]);
      double y = double.Parse(n[1]);
      double result = x/y;
      if (y != 0) Console.WriteLine($"{result:0.0}");
      
      else 
        Console.WriteLine("divisao impossivel");
    }
  } 
}