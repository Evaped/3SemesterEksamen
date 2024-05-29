using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Rally.Domain.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Rally.Server.Data
{
    public class SqlDbContext : IdentityDbContext
    {
        public DbSet<Arrow> Arrows { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Sign> Signs { get; set; }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ArrowConfiguration());
            builder.ApplyConfiguration(new ChatConfiguration());
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new ElementConfiguration());
            builder.ApplyConfiguration(new MemberConfiguration());
            builder.ApplyConfiguration(new SignConfiguration());
        }
    }
}
