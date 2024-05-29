using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rally.Domain.Models;
public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Theme { get; set; }
    public Level level { get; set; }
    public double CourseSize { get; set; }
    public string Tag { get; set; }
    public Visiability visiability { get; set; }

}
public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasData(new List<Course>()
        {
            new Course()
            {
                Id = 1,
                Name = "Course 1",
                Theme = "Theme 1",
                level = Level.Beginner,
                CourseSize = 1,
                Tag = "Tag1",
                visiability = Visiability.Hidden
            },

            new Course()
            {
                Id = 2,
                Name = "Course 2",
                Theme = "Theme 2",
                level = Level.Trained,
                CourseSize = 2.0,
                Tag = "Tag2",
                visiability = Visiability.Shown
            },

            new Course()
            {
                Id = 3,
                Name = "Course 3",
                Theme = "Theme 3",
                level = Level.Expert,
                CourseSize = 3.0,
                Tag = "Tag3",
                visiability = Visiability.Shown
            },

            new Course()
            {
                Id = 4,
                Name = "Course 4",
                Theme = "Theme 4",
                level = Level.Champion,
                CourseSize = 4.0,
                Tag = "Tag4",
                visiability = Visiability.Shown
            },

            new Course()
            {
                Id = 5,
                Name = "Course 5",
                Theme = "Theme 5",
                level = Level.Open,
                CourseSize = 5.0,
                Tag = "Tag5",
                visiability = Visiability.Hidden
            }
        });
    }
}
