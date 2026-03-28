using System.Resources;

namespace Week8;

class Program
{
    public static void Main()
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();
        manager.Add(file);
        manager.Add(network);
        manager.OpenAll();
        using (var disFile = new FileResource("disposable.report.txt"))
        {
            disFile.Open();
        } 
        manager.CloseAll();
        Console.WriteLine("Done");
    }
    
}