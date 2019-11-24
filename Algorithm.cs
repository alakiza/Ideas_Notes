using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
      
public class Program{
  public static void Main(){
    //TO DO refactoring
    
    int fa, fb, num;
    float faf, fbf, fres;
    int res;
    String znak;
    
    Console.WriteLine("Enter first argument (1 - 1000000): ");
    fa = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Enter operation (+, -, *, /): ");
    znak = Console.ReadLine();
    
    Console.WriteLine("Enter second argument (1 - 1000000): ");
    fb = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Enter count of ways (1 - 10000): ");
    num = int.Parse(Console.ReadLine());
    
    switch(znak){
      case "+":
        res = fa + fb;
         for(int i = 0; i < num; i++){
             Console.WriteLine((i+1) + ")" + fa + " + " + fb + " = " + res);
                fa++;
                fb--;
         }
      break;
      
       case "-":
         res = fa - fb;
         for(int i = 0; i < num; i++){
             Console.WriteLine((i+1) + ")" + fa + " - " + fb + " = " + res);
                fa++;
                fb++;
         }
      break;
      
       case "*":
         faf = Convert.ToSingle(fa);
         fbf = Convert.ToSingle(fb);
         fres = faf * fbf;
         
         for(int i = 0; i < num; i++){
             Console.WriteLine((i+1) + ")" + faf + " * " + fbf + " = " + fres);
                faf = faf*2;
                fbf = fbf/2;              
         }
      
      break;
      
       case "/":
          faf = Convert.ToSingle(fa);
          fbf = Convert.ToSingle(fb);
          fres = faf / fbf;
          
          for(int i = 0; i < num; i++){
             Console.WriteLine((i+1) + ")" + faf + " / " + fbf + " = " + fres);
                faf = faf*2;
                fbf = fbf*2;              
         }
      break;

      default:
          Console.WriteLine("Incorrect operation!");
      break;
    }
    
    
  }
}



/*http://volatileread.com/utilitylibrary/snippetcompiler?id=119133*/


