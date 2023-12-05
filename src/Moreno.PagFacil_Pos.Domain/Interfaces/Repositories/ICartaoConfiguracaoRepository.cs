using Moreno.PagFacil_Pos.Domain.Entities;
using Moreno.PagFacil_Pos.Domain.Interfaces.Repositories.Base;

namespace Moreno.PagFacil_Pos.Domain.Interfaces.Repositories;

public interface ICartaoConfiguracaoRepository : IBaseReadRepository<CartaoConfiguracao>, IBaseWriteRepository<CartaoConfiguracao>
{
}