using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rally.Domain.Models;

public class Arrow
{
    public int Id { get; set; }
    public int Position { get; set; }
    public Direction Direction { get; set; }
    public int Length { get; set; }
}
public class ArrowConfiguration : IEntityTypeConfiguration<Arrow>
{
    public void Configure(EntityTypeBuilder<Arrow> builder)
    {
        builder.HasData(new List<Arrow>()
        {
            new Arrow()
            {
                Id = 1,
                Position = 1,
                Direction = Direction.Right,
                Length = 1
            },

            new Arrow()
            {
                Id = 2,
                Position = 2,
                Direction = Direction.Left,
                Length = 2
            },

            new Arrow()
            {
                Id = 3,
                Position = 3,
                Direction = Direction.Straight,
                Length = 3
            },

            new Arrow()
            {
                Id = 4,
                Position = 4,
                Direction = Direction.Back,
                Length = 4
            },

            new Arrow()
            {
                Id = 5,
                Position = 5,
                Direction = Direction.BreakUp,
                Length = 5
            },

            new Arrow()
            {
                Id = 6,
                Position = 6,
                Direction = Direction.BreakDown,
                Length = 6
            },

            new Arrow()
            {
                Id = 7,
                Position = 7,
                Direction = Direction.BreakLeft,
                Length = 7
            },

            new Arrow()
            {
                Id = 8,
                Position = 8,
                Direction = Direction.BreakRight,
                Length = 8
            }
        });
    }
}