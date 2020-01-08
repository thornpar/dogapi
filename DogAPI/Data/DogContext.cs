using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DogAPI.Data
{
    public class DogContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; } 
        // ReSharper disable once SuggestBaseTypeForParameter
        public DogContext(DbContextOptions<DogContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>().HasKey(e => e.Id);
            modelBuilder.Entity<Dog>().HasData(new List<Dog>
            {
                new Dog{Id = Guid.Parse("B403BA35-FD18-4516-AE30-C8B1A648C20A"), Name = "Lasse", Race = "German Sheperd", BestSkill = "Policing"},
                new Dog{Id = Guid.Parse("3DF54D3B-7B9F-4396-8628-FCB71D982058"),Name = "Ronny", Race = "Golden Retriever", BestSkill = "Allways ready to eat the food you dont want"},
                new Dog{Id = Guid.Parse("1117C3E0-94CC-47DD-ABB9-361E4421AA15"),Name = "Pelle", Race = "Weimaraner", BestSkill = "Highly developed hunting instincts"},
                new Dog{Id = Guid.Parse("4063728D-40A9-4EE3-A5BB-E6455F128578"),Name = "Kalle", Race = "Papillon", BestSkill = "Very loud"}
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}