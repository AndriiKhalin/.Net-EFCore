namespace LB_2.Models.Data;

public class MotherBoard : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string? Image { get; set; }

    public string? Socket { get; set; }

    public string? Chipset { get; set; }
    public string FormFactor { get; set; }
    public float Price { get; set; }
    public List<ComponentComputer> ComponentComputers { get; set; } = new();
}