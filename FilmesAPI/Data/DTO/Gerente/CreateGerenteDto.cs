using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO.Gerente
{
    public class CreateGerenteDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
