using System; 

public class Program {

  public static void AntecessorSucessor (int x, out int antecessor, out int sucessor){
    antecessor = x-1;
    sucessor = x+1;
  }
  
  public static void Main(string[] args) {
    int x = int.Parse(Console.ReadLine());
    int a, s;
    AntecessorSucessor(x, out a, out s);
    Console.WriteLine($"{a}, {s}");
    
  }
}