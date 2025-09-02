using Microsoft.EntityFrameworkCore;
using MVC.Movies.KamilKolanowski.Models;

namespace MVC.Movies.KamilKolanowski.Data;

public class MvcMovieContext : DbContext
{
    public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options) { }

    public DbSet<Movie> Movies { get; set; } = default!;
}
