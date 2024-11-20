using System.ComponentModel.DataAnnotations;

namespace agence_de_voyage.Models
{
    public class voyage
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string ImageUrl { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Prix { get; set; }
    }
}
