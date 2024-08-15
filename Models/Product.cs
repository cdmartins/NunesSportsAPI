namespace NunesSportsAPI.Models
{
using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Codigo { get; set; }

        public string Descricao { get; set; }

        [Required]
        public decimal Preco { get; set; }

    }
}
