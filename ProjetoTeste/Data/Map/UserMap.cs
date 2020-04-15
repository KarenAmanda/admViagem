using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoTeste.Models;

namespace ProjetoTeste.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasColumnName("Nome");
            builder.Property(c => c.Birthday).IsRequired().HasColumnName("DataNascimento");
            builder.Property(c => c.Email).IsRequired().HasColumnName("Email");
            builder.Property(c => c.Telephone).IsRequired().HasColumnName("Telefone");
        }
    }
}
