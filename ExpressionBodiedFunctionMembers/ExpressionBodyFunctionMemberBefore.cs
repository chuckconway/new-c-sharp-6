public class ExpressionBodyFunctionMemberBefore
{
   public int Add(int x, int y)
   {
     return x + y;
   }

   public static int operator +(int a, int b)
   {
     return a + b;
   }

   public static implicit operator int(string value)
   {           
      return Convert.ToInt32(value);
   }
}
