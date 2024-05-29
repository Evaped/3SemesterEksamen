using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rally.Domain.Models;
public class Member
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool Admin { get; set; }
}

public class MemberConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.HasData(new List<Member>()
        {
            new Member()
            {
                Id = 1,
                FirstName = "Grethe",
                LastName = "Hansen",
                Email = "grethehansen8 7@mail.com",
                UserName = "Grethe87",
                Password = "StrongPassword87",
                Admin = true
            },
            new Member()
            {
                Id = 2,
                FirstName = "Hans",
                LastName = "Hansen",
                Email = "HansenAuto@mail.com",
                UserName = "Hans Hansen",
                Password = "MarriedToGrethe87",
                Admin = false
            }
        });
    }

}
