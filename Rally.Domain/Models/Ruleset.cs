using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rally.Domain.Models;
public class Ruleset
{
    public string Class { get; set; }
    public Level level { get; set; }
}
public class RulesetConfiguration : IEntityTypeConfiguration<Ruleset>
{
    public void Configure(EntityTypeBuilder<Ruleset> builder)
    {
        builder.HasData(new List<Ruleset>()
        {
            new Ruleset()
            {
                Class = "Klasse 1",
                level = Level.Beginner
            },

            new Ruleset()
            {
                Class = "Klasse 2",
                level = Level.Trained
            },

            new Ruleset()
            {
                Class = "Klasse 3",
                level = Level.Expert
            },

            new Ruleset()
            {
                Class = "Klasse 4",
                level = Level.Champion
            },

            new Ruleset()
            {
                Class = "Klasse 5",
                level = Level.Open
            }
        });
    }
}

