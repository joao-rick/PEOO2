using System; 

public class Program {

  public static void Main(string[] args) {
    int j = 1;
    for (int i=1; i <= 10; i++) {
      Console.WriteLine(j);
      j += i;
    }
  }
}
