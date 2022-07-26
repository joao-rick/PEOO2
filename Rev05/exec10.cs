using System; 

public class Program {

public static string Vogais(string s){
    char[] x = s.ToCharArray();
    string p = "AEIOUaeiou";    
    char[] vogais = p.ToCharArray();
    string vog = "";

    for(int i=0; i<s.Length;i++){
      for(int j=0; j<p.Length; j++){
        if(x[i] == vogais[j]){
          Console.Write(vogais[j]);
        }
      }
    }
    return vog;
  }
  
  public static void Main(string[] args) {
    string s = Console.ReadLine();
    Console.WriteLine(Vogais(s));
  }
}
  
