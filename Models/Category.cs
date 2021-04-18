using System.ComponentModel.DataAnnotations;

namespace SimpleApi.Models
{

    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Esse campo deve conter entre 3 e 6 caracteres")]
        [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 6 caracteres")]
        public string Title { get; set; }
    }

}