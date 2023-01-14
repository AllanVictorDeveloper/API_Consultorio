using CL.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CL.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Documento).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(12);
            builder.Property(x => x.Sexo).IsRequired();
            builder.Property(x => x.Criacao).ValueGeneratedOnAdd();
            builder.Property(x => x.UltimaAtualizacao).ValueGeneratedOnAdd();

            builder.ToTable("Tb_Clientes");
        }
    }
}