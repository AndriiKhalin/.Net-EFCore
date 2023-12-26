namespace LB_2.Models.Data;
public class Processor : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string? ProcessorManufacturer { get; set; }
    public string? ProcessorSeries { get; set; }
    public int ProcessorGeneration { get; set; }
    public string? ProcessorModel { get; set; }

    public string? SocketType { get; set; }

    public int NumCores { get; set; }

    public int NumThreads { get; set; }
    public int ClockFrequency { get; set; }
    public string? Image { get; set; }
    public float Price { get; set; }
    public List<ComponentComputer> ComponentComputers { get; set; } = new();
}