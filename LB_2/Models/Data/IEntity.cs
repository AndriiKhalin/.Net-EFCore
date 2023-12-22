namespace LB_2.Models.Data;

public interface IEntity
{
    int Id { get; set; }

    string Name { get; set; }

    float Price { get; set; }
}