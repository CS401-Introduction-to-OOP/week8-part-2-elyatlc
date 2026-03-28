namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;
        Console.WriteLine($"The original value is: {a}");
        Console.WriteLine($"The boxed value is: {b}");
        Console.WriteLine($"The unboxed value is: {c}");
    }
}