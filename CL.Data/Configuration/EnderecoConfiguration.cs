using CL.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CL.Data.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(x => x.Numero).IsRequired().HasMaxLength(64);

            builder.HasOne(x => x.Cliente)
                .WithOne(x => x.Endereco)
                .HasForeignKey<Endereco>(x => x.ClienteId);

            builder.HasKey(p => p.ClienteId);

            builder.ToTable("Tb_Enderecos");
        }
    }
}