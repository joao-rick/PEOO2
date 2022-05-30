using System; 

class URI {

    static void Main(string[] args) { 
Console.WriteLine("Digite o primeiro horário no formato hh:mm");
string s = Console.ReadLine();
string[] v = s.Split(":");
int h = int.Parse(v[0]);
int m = int.Parse(v[1]);
Console.WriteLine("Digite o segundo horário no formato hh:mm");
string s1 = Console.ReadLine();
string[] v1 = s1.Split(":");
int h1 = int.Parse(v1[0]);
int m1 = int.Parse(v1[1]);

int horas = h + h1;
int minutos = 0;
int minr = (m + m1) % 60;
if (m + m1 >= 60)
  horas = horas + 1;
if (m + m1 >= 60)
  minutos = minr;
else minutos = m + m1;
Console.WriteLine(string.Format("Total de horas = {0:00}:{1:00}", horas, minutos));

    }

}