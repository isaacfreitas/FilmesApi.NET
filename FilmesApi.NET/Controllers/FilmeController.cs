using FilmesApi.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);

        }

        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes()
        {
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme RecuperaFilmePorId(int id)
        {
            return filmes.FirstOrDefault(filme => filme.Id == id);
        }
    }
}