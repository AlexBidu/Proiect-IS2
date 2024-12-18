using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Models
{
    public class Utilizator
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu.")]
        public string Nume { get; set; }

        [Required(ErrorMessage = "Emailul este obligatoriu.")]
        [EmailAddress(ErrorMessage = "Format email invalid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Rolul este obligatoriu.")]
        public string Rol { get; set; } // Ex: "Client", "Agent", "Admin"
    }
}