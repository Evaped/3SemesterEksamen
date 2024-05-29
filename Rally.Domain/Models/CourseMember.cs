using Rally.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rally.Domain.Models;
public class CourseMember
{
    public int CourseId { get; set; }
    public Course course { get; set; }

    public int MemberId { get; set; }
    public Member member { get; set; }
}
