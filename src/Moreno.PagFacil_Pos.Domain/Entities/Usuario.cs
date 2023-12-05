using Moreno.PagFacil_Pos.Domain.Entities.Base;

namespace Moreno.PagFacil_Pos.Domain.Entities;

public class Usuario : Entity
{
    public string Login { get; private set; }
    public string Senha { get; private set; }
    public DateTime DataCadastro { get; private set; }
    public DateTime DataAlteracao { get; private set; }
    public bool Ativo { get; private set; }
    public bool Excluido { get; private set; }

    public Usuario()
    {
        
    }

    public Usuario(string login, string senha)
    {
        Login = login;
        Senha = senha;
        DataCadastro = DateTime.Now;
        DataAlteracao = DateTime.Now;
        Ativo = true;
        Excluido = false;
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

    public bool VerificarSenha(string senha) => Senha.Equals(senha);

    public override bool EhValido()
    {
        return true;
    }
}
