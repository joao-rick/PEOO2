using System; 

class URI {

    static void Main(string[] args) { 

Console.WriteLine("Escreva quatro valores inteiros: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4 = int.Parse(Console.ReadLine());

int maior = 0;
int menor = 0;
int smaior = 0;
int smenor = 0;
      
if (n1 == n2 || n1 == n3 || n1 == n4 || n2 == n3 || n2 == n4 || n3 == n4)
Console.WriteLine("Erro: valores iguais");

if (n1 > n2 && n1 > n3 && n1 > n4)
maior = n1;
if (n2 > n1 && n2 > n3 && n2 > n4)
maior = n2;
if (n3 > n1 && n3 > n2 && n3 > n4)
maior = n3;
if (n4 > n1 && n4 > n2 && n4 > n3)
maior = n4;

if (n1 < n2 && n1 < n3 && n1 < n4)
menor = n1;
if (n2 < n1 && n2 < n3 && n2 < n4)
menor = n2;
if (n3 < n1 && n3 < n2 && n3 < n4)
menor = n3;
if (n4 < n1 && n4 < n2 && n4 < n3)
menor = n4;

if (n1 > n2 && n1 > n3 && n1 < n4)
smaior = n1;
if (n1 > n2 && n1 < n3 && n1 > n4)
smaior = n1;
if (n1 < n2 && n1 > n3 && n1 > n4)
smaior = n1;

if (n2 > n1 && n2 > n3 && n2 < n4)
smaior = n2;
if (n2 > n1 && n2 < n3 && n2 > n4)
smaior = n2;
if (n2 < n1 && n2 > n3 && n2 > n4)
smaior = n2;

if (n3 > n2 && n3 > n1 && n3 < n4)
smaior = n3;
if (n3 > n2 && n3 < n1 && n3 > n4)
smaior = n3;
if (n3 < n2 && n3 > n1 && n3 > n4)
smaior = n3;

if (n4 > n2 && n4 > n3 && n4 < n1)
smaior = n4;
if (n4 > n2 && n4 < n3 && n4 > n1)
smaior = n4;
if (n4 < n2 && n4 > n3 && n4 > n1)
smaior = n4;

if (n1 < n2 && n1 < n3 && n1 > n4)
smenor = n1;
if (n1 < n2 && n1 > n3 && n1 < n4)
smenor = n1;
if (n1 > n2 && n1 < n3 && n1 < n4)
smenor = n1;

if (n2 < n1 && n2 < n3 && n2 > n4)
smenor = n2;
if (n2 < n1 && n2 > n3 && n2 < n4)
smenor = n2;
if (n2 > n1 && n2 < n3 && n2 < n4)
smenor = n2;

if (n3 < n2 && n3 < n1 && n3 > n4)
smenor = n3;
if (n3 < n2 && n3 > n1 && n3 < n4)
smenor = n3;
if (n3 > n2 && n3 < n1 && n3 < n4)
smenor = n3;

if (n4 < n2 && n4 < n3 && n4 > n1)
smenor = n4;
if (n4 < n2 && n4 > n3 && n4 < n1)
smenor = n4;
if (n4 > n2 && n4 < n3 && n4 < n1)
smenor = n4;

Console.WriteLine($"Maior valor = {maior}");
Console.WriteLine($"Menor valor = {menor}");
Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {smaior+smenor}");

      
    }

}