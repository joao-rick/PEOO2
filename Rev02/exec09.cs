using System; 

class URI {

    static void Main(string[] args) { 

Console.WriteLine("Digite o horário no formato hh:mm");     
string s = Console.ReadLine();
string[] v = s.Split(":");
int h = int.Parse(v[0]);
int m = int.Parse(v[1]);

if (h > 23 || m >= 60)
Console.WriteLine("Hora inválida");

int ang = ((60*h)-(11*m))/2;

if (ang > 180)
ang = 360 - ang;
      
Console.WriteLine($"Menor ângulo entre os ponteiros = {-ang} graus");

  
    }

}