using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rally.Domain.Models;
public class Element
{
    public int Id { get; set; }
    public string Type { get; set; }
    public int Position { get; set; }
    public int Row { get; set; }
    public int Column { get; set; }
}
public class ElementConfiguration : IEntityTypeConfiguration<Element>
{
    public void Configure(EntityTypeBuilder<Element> builder)
    {
        builder.HasData(new List<Element>()
        {
            new Element()
            {
                Id = 1,
                Type = "Start"
            },

            new Element()
            {
                Id = 2,
                Type = "Kegler"
            },

            new Element()
            {
                Id = 3,
                Type = "fristelser"
             },

            new Element()
            {
                Id = 4,
                Type = "Spring"
            },

            new Element()
            {
                Id = 5,
                Type = "Feltet"
            },

            new Element()
            {
                Id = 6,
                Type = "Spanden"
            },

            new Element()
            {
                Id = 7,
                Type = "kurven"
            },

            new Element()
            {
                Id = 8,
                Type = "Slut"
            }
        });
    }
}

