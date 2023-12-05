using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moreno.PagFacil_Pos.Domain.Entities;

namespace Moreno.PagFacil_Pos.Infra.Data.Mapping;

public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder
            .ToTable("Usuarios")
            .HasKey(u => u.Id);

        builder
            .Property(u => u.Ativo)
            .IsRequired();

        builder.Property(u => u.DataCadastro) .IsRequired();
        builder.Property(u => u.DataAlteracao) .IsRequired();
        builder.Property(u => u.Excluido) .IsRequired();
        builder.Property(u => u.Login).HasColumnType("varchar(50)").IsRequired();
        builder.Property(u => u.Senha).HasColumnType("varchar(100)").IsRequired();
    }
}
