using System; 

class URI {

    static void Main(string[] args) { 
Console.WriteLine("Digite o mês: ");
int m = int.Parse(Console.ReadLine());

string m1 = "a";
string t = "aa";
                  
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

if (m <= 3)
  t = "primeiro";
if (m < 3 && m <= 6)
  t = "segundo";
if (m > 7 && m < 10)
  t = "terceiro";
if (m > 9)
  t = "quarto";

Console.WriteLine($"O mês de {m1} é do {t} trimestre do ano");
    }

}