using Curso.Api.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Curso.Api.Infra.Data.Mappings
{
    public class CursoMapping : IEntityTypeConfiguration<Cursos>
    {
        public void Configure(EntityTypeBuilder<Cursos> builder)
        {
            builder.ToTable("TBL_CURSO");
            builder.HasKey(c => c.Codigo);
            builder.Property(c => c.Codigo).ValueGeneratedOnAdd();
            builder.Property(c => c.Nome);
            builder.Property(c => c.Descricao);
            builder.HasOne(c => c.Usuario)
                .WithMany().HasForeignKey(fk => fk.CodigoUsuario);
        }
    }
}
