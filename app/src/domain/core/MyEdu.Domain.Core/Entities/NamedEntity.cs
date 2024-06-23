namespace MyEdu.Domain.Core.Entities;

public abstract class NamedEntity(int id, string name, string imgeUrl, string description) : Entity(id);