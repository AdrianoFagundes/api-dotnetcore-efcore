using System.ComponentModel.DataAnnotations;

namespace SimpleApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(20)]
        [MinLength(6)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(20)]
        [MinLength(6)]
        public string Password { get; set; }

        [MaxLength(50)]
        public string Role { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
    }
}