using Moreno.PagFacil_Pos.Domain.Entities.Base;
using Moreno.PagFacil_Pos.Domain.Interfaces.Repositories.Base;
using Moreno.PagFacil_Pos.Domain.Interfaces.Services.Base;
using System.Linq.Expressions;

namespace Moreno.PagFacil_Pos.Domain.Services.Base;

public abstract class ServiceBase<TEntity>(IBaseWriteRepository<TEntity> _baseWriteRepository) : IServiceBase<TEntity>
    where TEntity : Entity, new()
{
    public async Task<TEntity> Adicionar(TEntity entidade) =>
        await _baseWriteRepository.Adicionar(entidade);

    public async Task<TEntity> Atualizar(TEntity entidade) =>
        await _baseWriteRepository.Atualizar(entidade);

    public async Task<TEntity> Atualizar(TEntity updated, int key) =>
        await _baseWriteRepository.Atualizar(updated, key);

    public async Task Deletar(long id) => await _baseWriteRepository.Deletar(id);

    public async Task Deletar(TEntity entidade) => await _baseWriteRepository.Deletar(entidade);

    public async Task DeletarRange(Expression<Func<TEntity, bool>> filtro = null) => 
        await _baseWriteRepository.DeletarRange(filtro);
}
