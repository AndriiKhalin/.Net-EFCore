namespace LB_2.Models.Data;

public class ComponentComputer : IEntity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ProcessorId { get; set; }

    public Processor? Processor { get; set; }

    public int? VideoCardId { get; set; }

    public VideoCard? VideoCard { get; set; }

    public int? HardDriveId { get; set; }

    public HardDrive? HardDrive { get; set; }

    public int? RamId { get; set; }

    public Ram? Ram { get; set; }

    public int? MotherBoardId { get; set; }

    public MotherBoard? MotherBoard { get; set; }

    public int? UnitId { get; set; }

    public Unit? Unit { get; set; }

    public List<Computer> Computers { get; set; } = new();
    public float Price { get; set; }
}