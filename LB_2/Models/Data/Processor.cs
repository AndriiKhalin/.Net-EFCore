namespace LB_2.Models.Data;
public class Processor : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string? Image { get; set; }
    public string? SocketType { get; set; }
    public string? ProcessorFamily { get; set; }

    public string? ProcessorGeneration { get; set; }
    public int NumCores { get; set; }

    public int NumThreads { get; set; }
    public int ClockFrequency { get; set; }

    public float Price { get; set; }
    public List<ComponentComputer> ComponentComputers { get; set; } = new();
}