using System;
using FilmesApi.NET.Models;
using Microsoft.EntityFrameworkCore;


namespace FilmesApi.NET.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }
        public DbSet<Filme> Filmes { get; set; }
    }
}
