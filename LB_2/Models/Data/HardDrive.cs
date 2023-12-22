
namespace LB_2.Models.Data;
public class HardDrive : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string? Image { get; set; }

    public string? HardDriveType { get; set; }
    public int StorageSize { get; set; }

    public int ReadWriteSpeed { get; set; }

    public float Price { get; set; }
    public List<ComponentComputer> ComponentComputers { get; set; } = new();
}