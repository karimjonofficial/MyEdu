using MyEdu.Domain.Core.DTOs;
using MyEdu.Domain.Core.Entities;

namespace MyEdu.Domain.Core.Interfaces;

public interface IEntity<out TEntity, TDto> 
    where TEntity: Entity
    where TDto : EntityDto
{
    TDto ToDto();
    static abstract TEntity FromDto(TDto dto);
}