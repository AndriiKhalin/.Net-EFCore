namespace LB_2.Models.Data;

public class VideoCard : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int SeriesName { get; set; }

    public string? Image { get; set; }


    public int VideoMemory { get; set; }

    public int ClockFrequency { get; set; }

    public float Price { get; set; }

    public List<ComponentComputer> ComponentComputers { get; set; } = new();
}