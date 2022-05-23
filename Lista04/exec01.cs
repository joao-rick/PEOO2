using System; 

class URI {

    static void Main(string[] args) { 

string n = Console.ReadLine();
string[] v = n.Split();
double a = double.Parse(v[0]);
double b = double.Parse(v[1]);
double c = double.Parse(v[2]);

double a1 = (a*c)/2;
double b1 = (c*c)*3.14159;
double c1 = (a+b)*c/2;
double d1 = b*b;
double e1 = a*b;

Console.WriteLine($"TRIANGULO: {a1:f3}");
Console.WriteLine($"CIRCULO: {b1:f3}");
Console.WriteLine($"TRAPEZIO: {c1:f3}");
Console.WriteLine($"QUADRADO: {d1:f3}");
Console.WriteLine($"RETANGULO: {e1:f3}");

    }

}