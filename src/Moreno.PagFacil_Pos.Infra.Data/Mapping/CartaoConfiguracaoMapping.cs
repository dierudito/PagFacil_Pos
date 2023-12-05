using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moreno.PagFacil_Pos.Domain.Entities;

namespace Moreno.PagFacil_Pos.Infra.Data.Mapping;

public class CartaoConfiguracaoMapping : IEntityTypeConfiguration<CartaoConfiguracao>
{
    public void Configure(EntityTypeBuilder<CartaoConfiguracao> builder)
    {
        builder
            .ToTable("CartaoConfiguracoes")
            .HasKey(u => u.Id);

        builder.Property(c => c.LimiteLiberado).HasColumnType("numeric(14,2)").IsRequired();
        builder.Property(c => c.LimiteTotal).HasColumnType("numeric(14,2)").IsRequired();
        builder.Property(c => c.DiaFechamento).IsRequired();
        builder.Property(c => c.DiaVencimento).IsRequired();
        builder.HasOne(c => c.Cartao).WithMany().HasForeignKey(c => c.CartaoId);
    }
}