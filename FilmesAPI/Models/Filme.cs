using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]

    public int Id { get; set; }

    [Required(ErrorMessage ="O título do filme é obrigatório")]
    [StringLength(100, ErrorMessage ="O título do filme não pode conter mais de 100 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage ="O gênero do filme não pode conter mais de 50 caracteres")]
    public string Genero { get; set; }

    public string Diretor { get; set; }

    [Required]
    [Range(70, 300, ErrorMessage ="A duração do filme deve ter de 70 a 300 minutos")]
    public int Duracao { get; set; }
    
}
