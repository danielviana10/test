using Microsoft.EntityFrameworkCore;
using Mercadinho.Models;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace Mercadinho.DataBase
{
    // Classe para gerenciar as entidades

    public class MercadinhoContext : DbContext
    {
        public DbSet<Item> Itens { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        // Configuracao da FK
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Item)
                .WithMany()
                .HasForeignKey(p => p.FkItemId);

           
        }

        public MercadinhoContext(DbContextOptions op) : base(op)
        {
        }
    }
}
