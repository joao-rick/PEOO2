using System; 

class URI {

    static void Main(string[] args) { 

    Console.WriteLine("Digite a base e a altura do retângulo: ");
    string b1 = Console.ReadLine();
    string h1 = Console.ReadLine();
    double x = double.Parse(b1);
    double y = double.Parse(h1);
    double area = x*y;
    double peri = x+y;
    double expo = Math.Pow(x, 2);
    double expo2 = Math.Pow(y, 2);
    double diag = expo + expo2;
    double result = Math.Sqrt(diag);

    Console.WriteLine("Área = " + area);
    Console.WriteLine("Perímetro = " + peri);
    Console.WriteLine("Diagonal = " + result);
      
    }

}