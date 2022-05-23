using System; 

class URI {

    static void Main(string[] args) { 
    string s4 = Console.ReadLine();
    string s5 = Console.ReadLine();
    double m1 = double.Parse(s4);
    double m2 = double.Parse(s5);
    double m = (m1*3.5+m2*7.5)/11 ;
    Console.WriteLine($"MEDIA = {m:f5}");

    }

}