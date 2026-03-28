namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen =  true;
        Console.WriteLine($"The network {Name} is opened.");
        
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"The network {Name} is closed.");
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"The network {Name} has been disposed.");
    }
}    

