using Moreno.PagFacil_Pos.Domain.Entities;
using Moreno.PagFacil_Pos.Domain.Interfaces.Repositories;
using Moreno.PagFacil_Pos.Domain.Interfaces.Services;
using Moreno.PagFacil_Pos.Domain.Services.Base;

namespace Moreno.PagFacil_Pos.Domain.Services;

public class UsuarioService(IUsuarioRepository usuarioRepository) :
    ServiceBase<Usuario>(usuarioRepository), IUsuarioService
{
}