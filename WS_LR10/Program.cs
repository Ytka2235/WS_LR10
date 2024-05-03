class EventClass
{
    public event Action<string> Event;

    public string Name { get; set; }

    public EventClass(string name)
    {
        Name = name;
    }

    public void RaiseEvent()
    {
        Event?.Invoke(Name);
    }
}

class HandlerClass
{
    public void HandleEvent(string name)
    {
        Console.WriteLine($"Event handled by {name}");
    }
}

class Program
{
    static void Main()
    {
        EventClass obj1 = new EventClass("Object 1");
        EventClass obj2 = new EventClass("Object 2");
        HandlerClass handler = new HandlerClass();

        obj1.Event += handler.HandleEvent;
        obj2.Event += handler.HandleEvent;

        obj1.RaiseEvent();
        obj2.RaiseEvent();
    }
}