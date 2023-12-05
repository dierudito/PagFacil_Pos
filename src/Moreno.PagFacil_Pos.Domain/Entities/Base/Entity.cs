namespace Moreno.PagFacil_Pos.Domain.Entities.Base;

public abstract class Entity
{
    public Guid Id { get; private set; }

    protected Entity()
    {
        Id = Guid.NewGuid();
    }

    public abstract bool EhValido();
}
