using System; 

class URI {

    static void Main(string[] args) { 

int t = int.Parse(Console.ReadLine());
int vm = int.Parse(Console.ReadLine());

double d = vm*t;
double l = d/12;

Console.WriteLine($"{l:f3}");

    }

}
