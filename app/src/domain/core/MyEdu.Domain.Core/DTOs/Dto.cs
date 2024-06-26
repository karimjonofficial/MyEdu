namespace MyEdu.Domain.Core.DTOs;

public abstract record Dto<TEntity>(int Id)
{
    public abstract TEntity ToEntity();
}