using System; 

class URI {

    static void Main(string[] args) { 
Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
string s = Console.ReadLine();
string[] v = s.Split('+', '-', '*', '/');
int n1 = int.Parse(v[0]);
int n2 = int.Parse(v[1]);
int op = 0;
      
int p = s.IndexOf('+');
  if (p ==-1) p = s.IndexOf('-');
  if (p ==-1) p = s.IndexOf('*');
  if (p ==-1) p = s.IndexOf('/');
switch(s[p]) {
  case '+':
    op = n1+n2; break;
  case '-': 
    op = n1-n2; break;
  case '*':
    op = n1*n2; break;
  case '/':  
    op = n1/n2; break;
}
Console.WriteLine($"O resultado da operação é {op}");
    
}

      
    }
