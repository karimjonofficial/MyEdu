namespace MyEdu.Domain.Core.Entities;

public abstract class Entity(int id)
{
    public int GetId() => id;
}