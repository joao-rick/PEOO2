using System; 

class URI {

    static void Main(string[] args) { 
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

int m = (a+b+c+d)/4;
Console.WriteLine("Média = " + m);
Console.WriteLine("Menores que a média");
      
if (a < m)
  Console.WriteLine(a);
if (b < m)
  Console.WriteLine(b);
if (c < m)
  Console.WriteLine(c);
if (d < m)
  Console.WriteLine(d);
Console.WriteLine("Maiores que a média");
if (a > m)
      Console.WriteLine(a);
if (b > m)
      Console.WriteLine(b);
if (c > m)
      Console.WriteLine(c);
if (d > m)
      Console.WriteLine(d);
      
      
    }

}