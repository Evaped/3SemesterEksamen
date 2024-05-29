using Rally.Domain.Models;
using System.Reflection.Emit;

namespace Rally.Models;
public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Theme { get; set; }
    public Level Level { get; set; }
    public double CourseSize { get; set; }
    public string Tag { get; set; }
    public Visibility visibility { get; set; }
}
