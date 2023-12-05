using Moreno.PagFacil_Pos.Domain.Entities.Base;
using System.Linq.Expressions;

namespace Moreno.PagFacil_Pos.Domain.Interfaces.Services.Base;

public interface IServiceBase<TEntity>
    where TEntity : Entity, new()
{
    Task<TEntity> Adicionar(TEntity entidade);
    Task<TEntity> Atualizar(TEntity entidade);
    Task<TEntity> Atualizar(TEntity updated, int key);
    Task Deletar(long id);
    Task Deletar(TEntity entidade);
    Task DeletarRange(Expression<Func<TEntity, bool>> filtro = null);
}
