using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KorokNET.Models;

public partial class Review
{
    public int Id { get; set; }
    [Display(Name = "Текст")]
    public string Text { get; set; } = null!;
    [Display(Name = "Оценка")]
    public int Rate { get; set; }

    public int UserId { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
