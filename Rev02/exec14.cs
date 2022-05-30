using System; 

class URI {

    static void Main(string[] args) { 
Console.WriteLine("Digite três valores: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a < Math.Abs(b-c) || a < Math.Abs(c-b))
  Console.WriteLine("Esses valores não formam um triângulo");
if else (b < Math.Abs(a-c) || b < Math.Abs(c-a))
  Console.WriteLine("Esses valores não formam um triângulo");
if else(c < Math.Abs(a-b) || c < Math.Abs(b-a))
  Console.WriteLine("Esses valores não formam um triângulo");

if else(a == b && a == c)
  Console.WriteLine("Tipo equilátero");
if else(a == b && a != c)
  Console.WriteLine("Tipo isóceles");
if else(a == c && a != b)
  Console.WriteLine("Tipo isóceles");
if else(b != c)
  Console.WriteLine("Tipo isóceles");
if else(b != a && b == c)
  Console.WriteLine("Tipo isóceles");

if else(a != b && a != c)
  Console.WriteLine("Tipo escaleno");
      
      
}

      
    }
