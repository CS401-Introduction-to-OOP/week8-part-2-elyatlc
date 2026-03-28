namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen =  true;
        Console.WriteLine($"The file {Name} is opened.");
        
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"The file {Name} is closed.");
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"The file {Name} has been disposed.");
    }
}    

