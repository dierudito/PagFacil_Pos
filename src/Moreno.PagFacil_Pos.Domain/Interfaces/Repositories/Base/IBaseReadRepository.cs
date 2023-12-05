using Moreno.PagFacil_Pos.Domain.Dtos;
using Moreno.PagFacil_Pos.Domain.Entities.Base;
using System.Linq.Expressions;

namespace Moreno.PagFacil_Pos.Domain.Interfaces.Repositories.Base;

public interface IBaseReadRepository<TEntity> where TEntity : Entity
{
    Task<IEnumerable<TEntity>> ObterTodosAsync();
    Task<TEntity> ObterPorId(object id);
    Task<(IEnumerable<TEntity> items, int qtd)> Obter(Expression<Func<TEntity, bool>> filtro = null,
        PaginacaoEntradaDto paginacao = null,
        params Expression<Func<TEntity, object>>[] includes);

    Task<TEntity> ObterUnico(Expression<Func<TEntity, bool>> expression);

    Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> predicate);

    Task<IEnumerable<TEntity>> ObterParaEscrita(Expression<Func<TEntity, bool>> predicate);
}