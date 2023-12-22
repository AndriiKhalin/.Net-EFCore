namespace LB_2.Models.Data;

public class Ram : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string? Image { get; set; }

    public int Size { get; set; }

    public string TypeMemory { get; set; }
    public int OperatingFrequency { get; set; }

    public float Price { get; set; }
    public List<ComponentComputer> ComponentComputers { get; set; } = new();
}