using Moreno.PagFacil_Pos.Domain.Entities;
using Moreno.PagFacil_Pos.UnityTests.Shared.Builders.Base;

namespace Moreno.PagFacil_Pos.UnityTests.Shared.Builders;

public class CartaoBuilder : BuilderEntityBase<Cartao, CartaoBuilder>
{    
    public string Numero { get; private set; }
    public short MesVencimento { get; private set; }
    public short AnoVencimento { get; private set; }
    public string CodigoSeguranca { get; private set; }
    public string NomeProprietario { get; private set; }
    public Usuario Usuario { get; private set; }
    public DateTime DataCadastro { get; private set; }
    public DateTime DataAlteracao { get; private set; }
    public bool Ativo { get; private set; }
    public bool Excluido { get; private set; }

    public CartaoBuilder()
    {
        ComNumero (_faker.Finance.CreditCardNumber());
        ComMesVencimento (_faker.Random.Short(1, 12));
        ComAnoVencimento(_faker.Random.Short(DateTime.Now.ToYearLastTwoDigit(), DateTime.Now.AddYears(50).ToYearLastTwoDigit()));
        ComCodigoSeguranca (_faker.Finance.CreditCardCvv());
        ComNomeProprietario (_faker.Person.FullName);
        ComUsuarioId (UsuarioBuilder.Novo().Build());
        ComAtivo (true);
        ComExcluido (false);
    }

    public CartaoBuilder ComNumero (string numero)
    {
        Numero = numero;
        return this;
    }
    public CartaoBuilder ComMesVencimento (short mesVencimento)
    {
        MesVencimento = mesVencimento;
        return this;
    }
    public CartaoBuilder ComAnoVencimento (short anoVencimento)
    {
        AnoVencimento = anoVencimento;
        return this;
    }
    public CartaoBuilder ComCodigoSeguranca (string codigoSeguranca)
    {
        CodigoSeguranca = codigoSeguranca;
        return this;
    }
    public CartaoBuilder ComNomeProprietario (string nomeProprietario)
    {
        NomeProprietario = nomeProprietario;
        return this;
    }
    public CartaoBuilder ComUsuarioId (Usuario usuario)
    {
        Usuario = usuario;
        return this;
    }
    public CartaoBuilder ComDataCadastro (DateTime dataCadastro)
    {
        DataCadastro = dataCadastro;
        return this;
    }
    public CartaoBuilder ComDataAlteracao (DateTime dataAlteracao)
    {
        DataAlteracao = dataAlteracao;
        return this;
    }
    public CartaoBuilder ComAtivo (bool ativo)
    {
        Ativo = ativo;
        return this;
    }
    public CartaoBuilder ComExcluido (bool excluido)
    {
        Excluido = excluido;
        return this;
    }

    public override Cartao Build()
    {
        var cartao = new Cartao(
        Numero,
        MesVencimento,
        AnoVencimento,
        CodigoSeguranca,
        NomeProprietario);

        if (!Ativo) cartao.DefinirComoInativo();
        if (Excluido) cartao.DefinirComoExcluido();
        cartao.DefinirUsuario(Usuario);

        return cartao;
    }
}