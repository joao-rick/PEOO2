using System; 

class URI {

    static void Main(string[] args) { 

    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina: ");
    string s4 = Console.ReadLine();
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina: ");
    string s5 = Console.ReadLine();
    int m1 = int.Parse(s4);
    int m2 = int.Parse(s5);
    
    int m = (m1*2+m2*3)/5 ;
    Console.WriteLine("Média Parcial: " + m);
      
    }

}