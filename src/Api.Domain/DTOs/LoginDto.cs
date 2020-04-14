using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "E-mail é um campo obrigatório para Login")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [StringLength(100, ErrorMessage = "E-mail deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
