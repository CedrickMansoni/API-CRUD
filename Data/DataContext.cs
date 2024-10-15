using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data;

public class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseNpgsql("Host = localhost; Port = 5432; User Id = cedrickmansoni; Database = crud; Password = delldb");
    }

    public DbSet<UsuarioModel> TabelaUsuario {get; set;}
}