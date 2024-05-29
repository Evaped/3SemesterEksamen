using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rally.Domain.Models;

public class Sign
{
    public int Id { get; set; }
    public int Position { get; set; }
    public string Description { get; set; }
}
public class SignConfiguration : IEntityTypeConfiguration<Sign>
{
    public void Configure(EntityTypeBuilder<Sign> builder)
    {
        builder.HasData(new List<Sign>()
        {
            new Sign()
            {
                Id = 1,
                Position = 1,
                Description = "Højre øverst på banen"
            },

            new Sign()
            {
                Id = 2,
                Position = 2,
                Description = "Højre midt på banen"
            },

            new Sign()
            {
                Id = 3,
                Position = 3,
                Description = "Højre nederst på banen"
            },

            new Sign()
            {
                Id = 4,                    
                Position = 4,
                Description = "Venstre øverst på banen"
            },

            new Sign()
            {
                Id = 5,
                Position = 5,
                Description = "Venstre midt på banen"
            },

            new Sign()
            {
                Id = 6,
                Position = 6,
                Description = "Venstre nederst på banen"
            }

        });
    }
}

