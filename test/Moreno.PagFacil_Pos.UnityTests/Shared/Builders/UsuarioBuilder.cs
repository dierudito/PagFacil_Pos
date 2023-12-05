using Moreno.PagFacil_Pos.Domain.Entities;
using Moreno.PagFacil_Pos.UnityTests.Shared.Builders.Base;

namespace Moreno.PagFacil_Pos.UnityTests.Shared.Builders;

public class UsuarioBuilder : BuilderEntityBase<Usuario, UsuarioBuilder>
{
    public string Login { get; private set; }
    public string Senha { get; private set; }

    public UsuarioBuilder()
    {
        ComLogin(_faker.Internet.UserName());
        ComSenha(_faker.Internet.Password());
    }

    public UsuarioBuilder ComLogin(string login)
    {
        Login = login;
        return this;
    }

    public UsuarioBuilder ComSenha(string senha)
    {
        Senha = senha;
        return this;
    }

    public override Usuario Build() => new(Login, Senha);
}
