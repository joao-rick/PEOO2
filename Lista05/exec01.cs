using System; 

class URI {

    static void Main(string[] args) { 

string s = Console.ReadLine();
string[] v = s.Split();
double a = double.Parse(v[0]);
double b = double.Parse(v[1]);
double c = double.Parse(v[2]);

double b2 = Math.Pow(b, 2);
double d = b2-4*a*c;
double bk1 = (-b + Math.Sqrt(d))/(2*a);
double bk2 = (-b - Math.Sqrt(d))/(2*a);

if (d < 0 && a == 0) Console.WriteLine("Impossivel calcular");
else Console.WriteLine(string.Format("R1 = {0:0.00000} \r\nR2 = {1:0.00000}", bk1, bk2));

    }
}