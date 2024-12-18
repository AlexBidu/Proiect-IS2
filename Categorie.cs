using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Numele categoriei este obligatoriu.")]
        public string Nume { get; set; }
    }
}