using System; 

public class Program {

  public static double Maior(double n1, double n2){
    double maior = 0;
    if (n1 > n2)
      maior = n1;
    if (n2 > n1)
      maior = n2;
    return maior;
  }
  
  public static void Main(string[] args) {
    double n1, n2, m;
    n1 = double.Parse(Console.ReadLine());
    n2 = double.Parse(Console.ReadLine());
    m = Maior(n1, n2);
    Console.WriteLine($"O maior número é: {m}");
  }

}