using System; 

class URI {

    static void Main(string[] args) { 

Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

double b2 = Math.Pow(b, 2);
double d = b2-4*a*c;
double bk1 = (-b + Math.Sqrt(d))/(2*a);
double bk2 = (-b - Math.Sqrt(d))/(2*a);

if (d < 0 && a == 0) Console.WriteLine("Impossivel calcular");
else Console.WriteLine(string.Format("As raízes são {0} e {1}", bk1, bk2));
      
    }

}