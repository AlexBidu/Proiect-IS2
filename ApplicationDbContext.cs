using Microsoft.EntityFrameworkCore;
using TicketSystem.Models;

namespace TicketSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Tickete { get; set; }
        public DbSet<Utilizator> Utilizatori { get; set; }
        public DbSet<Categorie> Categorii { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurarea relațiilor (Fluent API)
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Creator)
                .WithMany()
                .HasForeignKey(t => t.CreatorId)
                .OnDelete(DeleteBehavior.Restrict); // Restricționează ștergerea creatorului dacă are tickete

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Asignat)
                .WithMany()
                .HasForeignKey(t => t.AsignatId)
                .OnDelete(DeleteBehavior.SetNull); // Permite ca asignatul să fie null (un ticket poate să nu fie asignat)

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Categorie)
                .WithMany()
                .HasForeignKey(t => t.CategorieId)
                .OnDelete(DeleteBehavior.SetNull); // Stergerea categoriei nu sterge si ticketele, ci pune CategorieId pe null

            base.OnModelCreating(modelBuilder);
        }
    }
}