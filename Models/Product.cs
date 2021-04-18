using System.ComponentModel.DataAnnotations;

namespace SimpleApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "O campo deve ter entre 3 e 6 caracteres")]
        [MinLength(3, ErrorMessage = "O campo deve ter entre 3 e 6 caracteres")]
        public string Title { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Range(0.01, 999999, ErrorMessage = "Informe um valor entre 0,1 e 999.999,00")]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }

}