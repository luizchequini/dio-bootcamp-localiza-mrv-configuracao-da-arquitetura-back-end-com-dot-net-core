using Curso.Api.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Curso.Api.Configurations
{
    public class DbFactoryDbCOntext : IDesignTimeDbContextFactory<CursoDbContext>
    {
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-CV9KCCO0\\SQLEXPRESS;Database=DioMrvLocalizaCursoApiSwagger;Trusted_Connection=True;MultipleActiveResultSets=true");
            CursoDbContext cursoDbContext = new CursoDbContext(optionsBuilder.Options);

            return cursoDbContext;
        }
    }
}
