public class ExpressionBodyFunctionMember
{
  //methods
  public int Add(int x, inty) => x + y;

  //operator
  public static int operator +(int a, int b) => a + b;

  //implicit operators
  public static implicit operator int(string value) => Convert.ToInt32(value);

  //Void Methods
  public void Print() => Console.WriteLine("Hello World");

  //Properties
  public string Name => First + " " + Last;

  //indexers
  public Person this[long id] => store.LookupPerson(id);
}
