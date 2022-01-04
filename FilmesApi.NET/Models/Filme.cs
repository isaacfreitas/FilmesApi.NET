using System.ComponentModel.DataAnnotations;

namespace FilmesApi.NET.Models
{
    public class Filme
    {   
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo Título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        [StringLength(30,ErrorMessage ="O genero não pode passar de 30 caracteres")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1,600,ErrorMessage ="A duração deve estar entre 1 e 600 minutos")]
        public string Duracao { get; set; } 
    }   
}
