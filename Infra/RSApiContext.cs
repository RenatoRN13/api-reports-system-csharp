using Microsoft.EntityFrameworkCore;
using ReportsSystemApi.Domain.Entities;

namespace ReportsSystemAPI.Infra {
    public class RSApiContext : DbContext{
        public RSApiContext(DbContextOptions<RSApiContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Vinculo> Vinculos { get; set; }
        public DbSet<AtividadeUsuario> AtividadeUsuarios { get; set; }
        public DbSet<UsuarioPerfil> UsuarioPerfis { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}