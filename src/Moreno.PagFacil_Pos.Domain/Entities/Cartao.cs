using Moreno.PagFacil_Pos.Domain.Entities.Base;

namespace Moreno.PagFacil_Pos.Domain.Entities;

public class Cartao : Entity
{
    public string Numero { get; private set; }
    public short MesVencimento { get; private set; }
    public short AnoVencimento { get; private set; }
    public string CodigoSeguranca { get; private set; }
    public string NomeProprietario { get; private set; }
    public Guid? UsuarioId { get; private set; }
    public DateTime DataCadastro { get; private set; }
    public DateTime DataAlteracao { get; private set; }
    public bool Ativo { get; private set; }
    public bool Excluido { get; private set; }

    public Cartao()
    {
        
    }

    public Cartao(string numero, short mesVencimento, short anoVencimento, string codigoSeguranca, string nomeProprietario)
    {
        Numero = numero;
        MesVencimento = mesVencimento;
        AnoVencimento = anoVencimento;
        CodigoSeguranca = codigoSeguranca;
        NomeProprietario = nomeProprietario;
        Ativo = true;
        Excluido = false;
        DataCadastro = DateTime.Now;
        DataAlteracao = DateTime.Now;
    }

    public void DefinirComoAtivo()
    {
        Ativo = true;
    }

    public void DefinirComoInativo()
    {
        Ativo = false;
    }

    public void DefinirComoExcluido()
    {
        Excluido = true;
    }

    public void DefinirUsuario(Usuario usuario) => UsuarioId = usuario.Id;

    public Usuario Usuario { get; set; }

    public override bool EhValido()
    {
        return true;
    }
}