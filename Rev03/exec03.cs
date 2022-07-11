using System; 

public class Program {

  public static void Main(string[] args) {
    int i = 1;
    while (i <= 10) {
      if (i % 2 == 0) {
        i = i*-1;
      }
      Console.WriteLine(i);
      i = Math.Abs(i) + 1;
    }
  }
}
