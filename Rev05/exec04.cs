using System; 

public class Program {

  public static double VolumeEsfera(double r){
    return (4*3.14*Math.Pow(r, 3))/3;
  }
  
  public static void Main(string[] args) {
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeEsfera(r));
  }
}