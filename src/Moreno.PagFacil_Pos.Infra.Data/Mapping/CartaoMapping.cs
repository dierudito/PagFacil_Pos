using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moreno.PagFacil_Pos.Domain.Entities;

namespace Moreno.PagFacil_Pos.Infra.Data.Mapping;

public class CartaoMapping : IEntityTypeConfiguration<Cartao>
{
    public void Configure(EntityTypeBuilder<Cartao> builder)
    {
        builder
            .ToTable("Cartoes")
            .HasKey(u => u.Id);

        builder
            .Property(u => u.Ativo)
            .IsRequired();

        builder.Property(u => u.DataCadastro).IsRequired();
        builder.Property(u => u.DataAlteracao).IsRequired();
        builder.Property(u => u.Excluido).IsRequired();
        builder.Property(c => c.Numero).HasColumnType("char(16)").IsRequired();
        builder.Property(c => c.AnoVencimento).IsRequired();
        builder.Property(c => c.MesVencimento).IsRequired();
        builder.Property(c => c.CodigoSeguranca).HasColumnType("char(3)").IsRequired();
        builder.Property(u => u.NomeProprietario).HasColumnType("varchar(100)").IsRequired();

        builder.HasOne(c => c.Usuario).WithMany().HasForeignKey(c => c.UsuarioId);
    }
}
