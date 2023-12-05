using Microsoft.EntityFrameworkCore;
using Moreno.PagFacil_Pos.Domain.Entities;
using Moreno.PagFacil_Pos.Infra.Data.Mapping;

namespace Moreno.PagFacil_Pos.Infra.Data.Context.Entity;

public class PagFacil_PosDbContext : DbContext
{
    public PagFacil_PosDbContext()
    {
        
    }

    public PagFacil_PosDbContext(DbContextOptions<PagFacil_PosDbContext> options) : base(options)
    {
        
    }

    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Cartao> Cartao { get; set; }
    public DbSet<CartaoConfiguracao> CartaoConfiguracao { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioMapping());
        modelBuilder.ApplyConfiguration(new CartaoMapping());
        modelBuilder.ApplyConfiguration(new CartaoConfiguracaoMapping());

        base.OnModelCreating(modelBuilder);
    }
}
