using System;
using System.Collections.Generic;

namespace KorokNET.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
}
