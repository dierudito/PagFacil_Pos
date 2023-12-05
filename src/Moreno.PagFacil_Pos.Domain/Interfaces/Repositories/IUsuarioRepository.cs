using Moreno.PagFacil_Pos.Domain.Entities;
using Moreno.PagFacil_Pos.Domain.Interfaces.Repositories.Base;

namespace Moreno.PagFacil_Pos.Domain.Interfaces.Repositories;

public interface IUsuarioRepository : IBaseReadRepository<Usuario>, IBaseWriteRepository<Usuario>
{
}
