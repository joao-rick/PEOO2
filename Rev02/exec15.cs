using System; 

class URI {

    static void Main(string[] args) { 
Console.WriteLine("Digite três valores: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

      
int prim = 0;
int seg = 0;
int terc = 0;

if (n1 > n2 && n1 > n3)
  terc = n1;
if (n2 > n1 && n2 > n3)
  terc = n2;
if (n3 > n2 && n3 > n1)
  terc = n3;

if (n1 > n2 && n1 < n3)
  seg = n1;
if (n1 < n2 && n1 > n3)
  seg = n1;
if (n2 > n1 && n2 < n3)
  seg = n2;
if (n2 < n1 && n2 > n3)
  seg = n2;
if (n3 > n1 && n3 < n2)
  seg = n3;
if (n3 < n1 && n3 > n2)
  seg = n3;

if (n1 < n2 && n1 < n3)
  prim = n1;
if (n2 < n1 && n2 < n3)
  prim = n2;
if (n3 < n1 && n3 < n2)
  prim = n3;

Console.WriteLine($"{prim}, {seg}, {terc}");
      
}

      
    }
