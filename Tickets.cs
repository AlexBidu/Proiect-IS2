using System;
using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Models
{
    public class Ticket
    {
        [Key] // Cheie primară
        public int Id { get; set; }

        [Required(ErrorMessage = "Titlul este obligatoriu.")] // Validare: câmp obligatoriu
        public string Titlu { get; set; }

        public string Descriere { get; set; }

        [Required(ErrorMessage = "Prioritatea este obligatorie.")]
        public string Prioritate { get; set; }

        [Required(ErrorMessage = "Statusul este obligatoriu.")]
        public string Status { get; set; }

        public DateTime DataCreare { get; set; }
        public DateTime? DataRezolvare { get; set; }

        public int? CategorieId { get; set; }
        public Categorie Categorie { get; set; }
    }
}