using System; 

class URI {

    static void Main(string[] args) { 

string s = Console.ReadLine();
string[] v = s.Split();
int a = int.Parse(v[0]);
int b = int.Parse(v[1]);

int p = a % b;
Console.WriteLine(p);

    }

}