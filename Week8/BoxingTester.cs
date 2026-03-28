namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10; // значення зберігається в стек
        object b = a; // створюється посилання на значення в купу
        int c = (int)b; // система переходить по посиланню з купи, копіює значення та додає в стек для змінної 'с'
        Console.WriteLine($"The original value is: {a}");
        Console.WriteLine($"The boxed value is: {b}");
        Console.WriteLine($"The unboxed value is: {c}");
        
    }
}