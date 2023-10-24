using BlogNoticias.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoticiasApi.Models;

namespace NoticiasApi.Data;

public class NoticiaContext : IdentityDbContext<Editor>
{
    public NoticiaContext(DbContextOptions<NoticiaContext> opts) : base(opts)
    {

    }

    public DbSet<Noticia> Noticias { get; set; }
    public DbSet<Editor> Editors { get; set; }
}
