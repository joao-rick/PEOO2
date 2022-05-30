using System; 

class URI {

    static void Main(string[] args) { 

Console.WriteLine("Digite uma data no formato dd/mm/aaaa"); 
string s = Console.ReadLine();
string[] v = s.Split("/");
int d = int.Parse(v[0]);
int m = int.Parse(v[1]);
int a = int.Parse(v[2]);
string m1 = "a";
      
if (m == 1)
    m1 = "janeiro";
if (m == 2)
    m1 = "fevereiro";
if (m == 3)
    m1 = "março";
if (m == 4)
    m1 = "abril";
if (m == 5)
    m1 = "maio";
if (m == 6)
    m1 = "junho";
if (m == 7)
    m1 = "julho";                 
if (m == 8)
    m1 = "agosto";
if (m == 9)
    m1 = "setembro";
if (m == 10)
    m1 = "outubro";
if (m == 11)
    m1 = "novembro";
if (m == 12)
    m1 = "dezembro";

Console.WriteLine($"A data é {d} de {m1} de {a}");
  
  
    }

}