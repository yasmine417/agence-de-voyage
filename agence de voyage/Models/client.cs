using System.ComponentModel.DataAnnotations;

namespace agence_de_voyage.Models
{
    public class client
    {
        [Key]
        public int IdClient { get; set; }
        [Required]
        [StringLength(100)]
        public string Nom{ get; set; }
        [Required]
        [StringLength(100)]
        public string Prenom { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Les mots de passe ne correspondent pas.")]

        public string ConfirmPassword { get; set; }

    }
}
