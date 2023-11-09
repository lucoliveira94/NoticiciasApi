using BlogNoticias.Models;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoticiasApi.Models;
using System.Data.Entity.Infrastructure;

namespace NoticiasApi.Data;

public class NoticiaContext : IdentityDbContext<Editor>
{
    private readonly IDbConnectionFactory _connectionFactory;
    public NoticiaContext()
    { }

    public NoticiaContext(DbContextOptions<NoticiaContext> options, IDbConnectionFactory connectionFactory) : base(options)
    {
        _connectionFactory = connectionFactory;
    }

    public NoticiaContext(DbContextOptions<NoticiaContext> opts) : base(opts)
    {

    }

    public DbSet<Noticia> Noticias { get; set; }
    public DbSet<Editor> Editors { get; set; }
}
