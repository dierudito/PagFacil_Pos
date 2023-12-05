using Moreno.PagFacil_Pos.Domain.Entities.Base;

namespace Moreno.PagFacil_Pos.Domain.Entities;

public class CartaoConfiguracao : Entity
{
    public short DiaVencimento { get; private set; }
    public short DiaFechamento { get; private set; }
    public decimal LimiteTotal { get; private set; }
    public decimal? LimiteLiberado { get; private set; }
    public Guid CartaoId { get; private set; }
    public CartaoConfiguracao()
    {
        
    }
    public CartaoConfiguracao(short diaVencimento, short diaFechamento, decimal limiteTotal, Cartao cartao)
    {
        DiaVencimento = diaVencimento;
        DiaFechamento = diaFechamento;
        LimiteTotal = limiteTotal;
        DefinirLimiteLiberado(limiteTotal);
        CartaoId = cartao.Id;
    }

    public void DefinirLimiteLiberado(decimal? limiteLiberado)
    {
        if (limiteLiberado < LimiteTotal) LimiteLiberado = limiteLiberado;
        else LimiteLiberado = LimiteTotal;
    }

    public DateTime ObterFechamentoAtual()
    {
        var dataAtual = DateTime.Now;
        var fechamentoAtual = new DateTime(dataAtual.Year, dataAtual.Month, DiaFechamento);

        return fechamentoAtual;
    }

    public DateTime ObterVencimentoAtual()
    {
        var dataAtual = DateTime.Now;
        var vencimentoAtual = new DateTime(dataAtual.Year, dataAtual.Month, DiaVencimento);

        var fechamentoAtual = ObterFechamentoAtual();

        if (vencimentoAtual < fechamentoAtual) vencimentoAtual = vencimentoAtual.AddMonths(1);

        return vencimentoAtual;
    }

    public Cartao Cartao { get; set; }
    public override bool EhValido()
    {
        return true;
    }
}