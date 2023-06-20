internal class Program
{
    private static void Main(string[] args)
    {
        var lamda = new LamdaTest();
        lamda.LamdaFunc(lamda.SayHellow);
        lamda.LamdaFunc(() => Console.WriteLine("Hello"));
        Console.WriteLine(lamda.lambdaExpression(5));
        Console.ReadLine();
    }
}

public class LamdaTest
{    
    public void SayHellow()
    {
        Console.WriteLine("Hello");
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
    /// <summary>
    /// Action 값을 반환하지않고 캡슐화를 하는것
    /// </summary>
    /// <param name="action"></param>
    public void LamdaFunc(Action action)
    {
        action();
    }
    public Func<int, int> lambdaExpression = (x) =>
    {
        // Perform some computation
        int result = x * 2;

        // You can also have additional logic here

        return result;
    };
}