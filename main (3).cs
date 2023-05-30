/******************************************************************************
Вариант 25
*******************************************************************************/
using System;
class HelloWorld {
  public const double PI = 3.1415926535897931;
  static void Main() {
      
      Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ x");
      int  x = Convert.ToInt32(Console.ReadLine());
      if (Math.Sin(2*(x*180/PI)) == 2*Math.Sin(x*180/PI)*Math.Cos(x*180/PI)){
        Console.WriteLine("YES");  
      }
      else {
        Console.WriteLine("NO");  
      }
 
  }
}