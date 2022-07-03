using System; 

public class Program {

  public static void Main(string[] args) {
    
int n = int.Parse(Console.ReadLine());
int n1 = 0;
int n2 = 1;
int aux = 0;
    
  if (n < 46)
    Console.WriteLine(n1);
    Console.WriteLine(n2);

  for (int i = 1; i <= (n-2); i++) {
    aux = n1 + n2;
    n1 = n2;
    n2 = aux;
    Console.WriteLine(aux);
    }
  } 
}