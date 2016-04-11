using System;

class Program
{
   static int a = 2;

   static void Main()
   {
       MyMethod();
   }

   static void MyMethod()
   {
       void Nested(ref int b) => ++b;
       Nested(ref a);
       Console.WriteLine(a); // 3
   }
}
