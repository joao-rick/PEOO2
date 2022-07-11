using System; 

public class Program {

  public static void Main(string[] args) {
    int i = 1;
    while (i <= 30) {
      if (i % 3 == 0) {
        i = i*-1;
      }
      Console.WriteLine(i);
      i = Math.Abs(i) + 1;
    }
  }
}
