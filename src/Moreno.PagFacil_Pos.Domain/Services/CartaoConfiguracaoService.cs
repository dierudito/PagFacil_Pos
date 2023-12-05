using Moreno.PagFacil_Pos.Domain.Entities;
using Moreno.PagFacil_Pos.Domain.Interfaces.Repositories;
using Moreno.PagFacil_Pos.Domain.Interfaces.Services;
using Moreno.PagFacil_Pos.Domain.Services.Base;

namespace Moreno.PagFacil_Pos.Domain.Services;

public class CartaoConfiguracaoService(ICartaoConfiguracaoRepository cartaoConfiguracaoRepository) :
    ServiceBase<CartaoConfiguracao>(cartaoConfiguracaoRepository), ICartaoConfiguracaoService
{
}
