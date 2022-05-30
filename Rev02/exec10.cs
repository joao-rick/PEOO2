using System; 

class URI {

    static void Main(string[] args) { 

Console.WriteLine("Digite uma data no formato dd/mm/aaaa"); 
string s = Console.ReadLine();
string[] v = s.Split("/");
int d = int.Parse(v[0]);
int m = int.Parse(v[1]);
int a = int.Parse(v[2]);

if (d > 31 || a < 1900 || a > 2100 || m < 1 || m > 12)
Console.WriteLine("A data informada não é válida");

    }

}