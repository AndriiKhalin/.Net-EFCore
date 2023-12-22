namespace LB_2.Models.Data;

public class Computer : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public float Price { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public string? Image { get; set; }

    public int? ComponentComputerId { get; set; }

    public ComponentComputer? ComponentComputer { get; set; }
}