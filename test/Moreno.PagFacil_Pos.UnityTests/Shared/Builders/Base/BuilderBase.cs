using Bogus;
using Moreno.PagFacil_Pos.Domain.Entities.Base;

namespace Moreno.PagFacil_Pos.UnityTests.Shared.Builders.Base;

public abstract class BuilderEntityBase<TEntity, TBuilder>
    where TEntity : Entity
    where TBuilder : BuilderEntityBase<TEntity, TBuilder>, new()
{
    protected Faker _faker;

    public BuilderEntityBase()
    {
        _faker = new();
    }

    public static TBuilder Novo() => new();

    public abstract TEntity Build();
}
