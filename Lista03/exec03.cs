using System; 

class URI {

    static void Main(string[] args) { 

double r = double.Parse(Console.ReadLine());
double raio = r*r*r;
double form = (4/3.0)*3.14159*raio;
Console.WriteLine($"VOLUME = {form:f3}");
    }

}