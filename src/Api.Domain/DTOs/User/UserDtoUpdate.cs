using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.User
{
    public class UserDtoUpdate
    {
        [Required(ErrorMessage = "ID é campo obrigatório.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é campo obrigatório.")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail é campo obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        [StringLength(100, ErrorMessage = "E-mail deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
