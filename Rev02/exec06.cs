using System; 

class URI {

    static void Main(string[] args) { 
Console.WriteLine("Digite três valores inteiros: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int menor = 0;
int maior = 0;

if (n1 > n2 && n1 > n3)
  maior = n1;
if (n2 > n1 && n2 > n3)
  maior = n2;
if (n3 > n1 && n3 > n2)
  maior = n3;

if (n1 < n2 && n1 < n3)
  menor = n1;
if (n2 < n1 && n2 < n3)
  menor = n2;
if (n3 < n1 && n3 < n2)
  menor = n3;

Console.WriteLine($"A soma do maior com o menor número é {maior + menor}.");


    }

}