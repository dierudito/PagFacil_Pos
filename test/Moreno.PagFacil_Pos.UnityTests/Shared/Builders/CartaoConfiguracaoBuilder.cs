using Moreno.PagFacil_Pos.Domain.Entities;
using Moreno.PagFacil_Pos.UnityTests.Shared.Builders.Base;

namespace Moreno.PagFacil_Pos.UnityTests.Shared.Builders;

public class CartaoConfiguracaoBuilder : BuilderEntityBase<CartaoConfiguracao, CartaoConfiguracaoBuilder>
{    
    public short DiaVencimento { get; private set; }
    public short DiaFechamento { get; private set; }
    public decimal LimiteTotal { get; private set; }
    public decimal? LimiteLiberado { get; private set; }
    public Cartao Cartao { get; private set; }

    public CartaoConfiguracaoBuilder()
    {
        ComDiaVencimento (_faker.Random.Short(1, 28));
        ComDiaFechamento (_faker.Random.Short(1, 28));
        ComLimiteTotal (_faker.Finance.Amount());
        ComCartao (CartaoBuilder.Novo().Build());
    }

    public CartaoConfiguracaoBuilder ComDiaVencimento (short diaVencimento)
    {
        DiaVencimento = diaVencimento;
        return this;
    }
    public CartaoConfiguracaoBuilder ComDiaFechamento (short diaFechamento)
    {
        DiaFechamento = diaFechamento;
        return this;
    }
    public CartaoConfiguracaoBuilder ComLimiteTotal (decimal limiteTotal)
    {
        LimiteTotal = limiteTotal;
        return this;
    }
    public CartaoConfiguracaoBuilder ComLimiteLiberado (decimal? limiteLiberado)
    {
        LimiteLiberado = limiteLiberado;
        return this;
    }
    public CartaoConfiguracaoBuilder ComCartao (Cartao cartao)
    {
        Cartao = cartao;
        return this;
    }

    public override CartaoConfiguracao Build()
    {
        var cartaoConfiguracao = new CartaoConfiguracao(
            DiaVencimento,
            DiaFechamento,
            LimiteTotal,
            Cartao);

        if (LimiteLiberado is not null) cartaoConfiguracao.DefinirLimiteLiberado(LimiteLiberado);
        return cartaoConfiguracao;
    }
}