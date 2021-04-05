using Curso.Api.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.Api.Infra.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TBL_USUARIO");
            builder.HasKey(u => u.Codigo);
            builder.Property(u => u.Codigo).ValueGeneratedOnAdd();
            builder.Property(u => u.Login);
            builder.Property(u => u.Email);
            builder.Property(u => u.Senha);
        }
    }
}
