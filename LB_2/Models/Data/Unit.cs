namespace LB_2.Models.Data;

public class Unit : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string? FormFactorMotherBoard { get; set; }
    public string? Image { get; set; }
    public float Length { get; set; }

    public float Height { get; set; }

    public float Width { get; set; }
    public float Price { get; set; }
    public List<ComponentComputer> ComponentComputers { get; set; } = new();
}