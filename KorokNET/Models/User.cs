using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KorokNET.Models;

public partial class User
{
    [Display(Name = "Идентификатор")]
    public int Id { get; set; }

    [Display(Name = "Имя")]
    public string Firstname { get; set; } = null!;

    [Display(Name = "Фамилия")]
    public string Lastname { get; set; } = null!;

    [Display(Name = "Отчество")]
    public string Secondname { get; set; } = null!;

    [Display(Name = "Логин")]
    public string Login { get; set; } = null!;

    [Display(Name = "Пароль")]
    public string Password { get; set; } = null!;

    [Display(Name = "Телефон")]
    public string Phone { get; set; } = null!;

    [Display(Name = "Почта")]
    public string Email { get; set; } = null!;

    [Display(Name = "Идентификатор роли")]
    public int RoleId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
}
