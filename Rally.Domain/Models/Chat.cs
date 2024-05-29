using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rally.Domain.Models;
	public class Chat
{
    public int Id { get; set; }
    public string Message { get; set; }
    public Member member { get; set; }
    public int MemberId { get; set; }
}
public class ChatConfiguration : IEntityTypeConfiguration<Chat>
{
    public void Configure(EntityTypeBuilder<Chat> builder)
    {
        builder.HasData(new List<Chat>()
        {
            new Chat()
            {
                Id = 1,
                Message = "Hej Hans, jeg har oprettet en fælles bane i Course 4",
                MemberId = 1
            },

            new Chat()
            {
                Id = 2,
                Message = "Hej Grethe, jeg har færdiggjort Course 3 og delt den. Jeg går i gang med Course 4 nu.",
                MemberId = 2
            }

        });
    }
}


