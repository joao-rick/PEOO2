using System; 

class URI {

    static void Main(string[] args) { 

string s = Console.ReadLine();
string[] v = s.Split();
double x1 = double.Parse(v[0]);
double y1 = double.Parse(v[1]);

string s1 = Console.ReadLine();
string[] v1 = s1.Split();
double x2 = double.Parse(v1[0]);
double y2 = double.Parse(v1[1]);
double p = Math.Pow(x2-x1, 2);
double p1 = Math.Pow(y2-y1, 2);
double form = p+p1;
double result = Math.Sqrt(form);

Console.WriteLine($"{result:f4}");

    }

}