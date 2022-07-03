using System; 

class MainClass {
  public static bool Aprovado(int n1, int n2) {
    double m = (n1 + n2) / 2;
    if (m >= 60) return true;
    else return false;
  }

  public static void Main(string[] args) {
    int x1 = int.Parse(Console.ReadLine());
    int x2 = int.Parse(Console.ReadLine());
    bool x3 = Aprovado(x1, x2);
    Console.WriteLine(x3);
  }
}