namespace  Week8;
class Program
{
    public static void Main()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 3;
        p2.Y = 4;
        Console.WriteLine($"p1: {p1.X}, {p1.Y}");
        Console.WriteLine($"p2: {p2.X}, {p2.Y}");
        //Результати різні бо point в нас struct відповідно зберігається в стек і копіюється тільки значення
        //Тому зміна данних p2 не вплинула на p1 -- вони займають різні комрки памʼяті
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;
        r2.X = 3;
        r2.Y = 4;
        Console.WriteLine($"r1: {r1.X}, {r1.Y}");
        Console.WriteLine($"r2: {r2.X}, {r2.Y}");
        // Тут значення змінилися, бо pointref це object і зберігається в heap
        // Відповідно копіюється посилання на комірку памʼяті, тож при зміні в r2 змінюється і r1
        BoxingTester.Test();
    }
    
}