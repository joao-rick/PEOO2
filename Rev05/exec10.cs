using System; 

public class Program {
  
  public static void Main(string[] args) {
    string s = Console.ReadLine();
    char[] x = s.ToCharArray();
    string p = "AEIOUaeiou";    
    char[] vogais = p.ToCharArray();

    for(int i=0; i<s.Length;i++){
      for(int j=0; j<p.Length; j++){
        if(x[i] == vogais[j]){
          Console.Write(vogais[j]);
        }
      }
    }
  }
}
