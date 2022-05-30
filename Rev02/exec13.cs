using System; 

class URI {

    static void Main(string[] args) { 
Console.WriteLine("Digite dez valores inteiros: ");
string s = Console.ReadLine();
string[] v = s.Split();
int n1 = int.Parse(v[0]);
int n2 = int.Parse(v[1]);
int n3 = int.Parse(v[2]);
int n4 = int.Parse(v[3]);
int n5 = int.Parse(v[4]);
int n6 = int.Parse(v[5]);
int n7 = int.Parse(v[6]);
int n8 = int.Parse(v[7]);
int n9 = int.Parse(v[8]);
int n10 = int.Parse(v[9]);

int maior = 0;
int menor = 0;

                  
if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5 && n1 > n6 && n1 > n7 && n1 > n8 && n1 > n9 && n1 > n10)
  maior = n1;
if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5 && n2 > n6 && n2 > n7 && n2 > n8 && n2 > n9 && n2 > n10)
  maior = n2;
if (n3 > n2 && n3 > n1 && n3 > n4 && n3 > n5 && n3 > n6 && n3 > n7 && n3 > n8 && n3 > n9 && n3 > n10)
  maior = n3;
if (n4 > n2 && n4 > n3 && n4 > n1 && n4 > n5 && n4 > n6 && n4 > n7 && n4 > n8 && n4 > n9 && n4 > n10)
  maior = n4;
if (n5 > n2 && n5 > n3 && n5 > n4 && n5 > n1 && n5 > n6 && n5 > n7 && n5 > n8 && n5 > n9 && n5 > n10)
  maior = n5;
if (n6 > n2 && n6 > n3 && n6 > n4 && n6 > n5 && n6 > n1 && n6 > n7 && n6 > n8 && n6 > n9 && n6 > n10)
  maior = n6;
if (n7 > n2 && n7 > n3 && n7 > n4 && n7 > n5 && n7 > n6 && n7 > n1 && n7 > n8 && n7 > n9 && n7 > n10)
  maior = n7;
if (n8 > n2 && n8 > n3 && n8 > n4 && n8 > n5 && n8 > n6 && n8 > n7 && n8 > n1 && n8 > n9 && n8 > n10)
  maior = n8;
if (n9 > n2 && n9 > n3 && n9 > n4 && n9 > n5 && n9 > n6 && n9 > n7 && n9 > n8 && n9 > n1 && n9 > n10)
  maior = n9;
if (n10 > n2 && n10 > n3 && n10 > n4 && n10 > n5 && n10 > n6 && n10 > n7 && n10 > n8 && n10 > n9 && n10 > n1)
  maior = n10;

if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5 && n1 < n6 && n1 < n7 && n1 < n8 && n1 < n9 && n1 < n10)
  menor = n1;
if (n2 < n1 && n2 < n3 && n2 < n4 && n2 < n5 && n2 < n6 && n2 < n7 && n2 < n8 && n2 < n9 && n2 < n10)
  menor = n2;
if (n3 < n2 && n3 < n1 && n3 < n4 && n3 < n5 && n3 < n6 && n3 < n7 && n3 < n8 && n3 < n9 && n3 < n10)
  menor = n3;
if (n4 < n2 && n4 < n3 && n4 < n1 && n4 < n5 && n4 < n6 && n4 < n7 && n4 < n8 && n4 < n9 && n4 < n10)
  menor = n4;
if (n5 < n2 && n5 < n3 && n5 < n4 && n5 < n1 && n5 < n6 && n5 < n7 && n5 < n8 && n5 < n9 && n5 < n10)
  menor = n5;
if (n6 < n2 && n6 < n3 && n6 < n4 && n6 < n5 && n6 < n1 && n6 < n7 && n6 < n8 && n6 < n9 && n6 < n10)
  menor = n6;
if (n7 < n2 && n7 < n3 && n7 < n4 && n7 < n5 && n7 < n6 && n7 < n1 && n7 < n8 && n7 < n9 && n7 < n10)
  menor = n7;
if (n8 < n2 && n8 < n3 && n8 < n4 && n8 < n5 && n8 < n6 && n8 < n7 && n8 < n1 && n8 < n9 && n8 < n10)
  menor = n8;
if (n9 < n2 && n9 < n3 && n9 < n4 && n9 < n5 && n9 < n6 && n9 < n7 && n9 < n8 && n9 < n1 && n9 < n10)
  menor = n9;
if (n10 < n2 && n10 < n3 && n10 < n4 && n10 < n5 && n10 < n6 && n10 < n7 && n10 < n8 && n10 < n9 && n10 < n1)
  menor = n10;

Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");
                  
                  
    }

}