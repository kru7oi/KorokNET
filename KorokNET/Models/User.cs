using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KorokNET.Models;

public partial class User
{
    [Display(Name = "Идентификатор")]
    public int Id { get; set; }

    [Display(Name = "Имя")]
    [RegularExpression(@"^[А-Яа-яЁё]+$", ErrorMessage = "Допустимы только буквы кириллицы.")]
    public string Firstname { get; set; } = null!;

    [Display(Name = "Фамилия")]
    [RegularExpression(@"^[А-Яа-яЁё]+$", ErrorMessage = "Допустимы только буквы кириллицы.")]
    public string Lastname { get; set; } = null!;

    [Display(Name = "Отчество")]
    [RegularExpression(@"^[А-Яа-яЁё]+$", ErrorMessage = "Допустимы только буквы кириллицы.")]
    public string Secondname { get; set; } = null!;

    [Display(Name = "Логин")]
    [MinLength(6, ErrorMessage = "Логин должен быть более шести символов.")]
    [RegularExpression(@"^[a-zA-Z0]*$", ErrorMessage = "Используйте только латинские символы.")]
    public string Login { get; set; } = null!;

    [Display(Name = "Пароль")]
    [MinLength(8, ErrorMessage = "Пароль должен быть более шести символов.")]
    public string Password { get; set; } = null!;

    [Display(Name = "Телефон")]
    [RegularExpression(@"^8\(\d{3}\)\d{3}-\d{2}-\d{2}$", ErrorMessage = "Некорректный формат номера телефона")]
    public string Phone { get; set; } = null!;

    [Display(Name = "Почта")]
    [EmailAddress(ErrorMessage = "Некорректный формат электронной почты.")]
    public string Email { get; set; } = null!;

    [Display(Name = "Идентификатор роли")]
    public int RoleId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
}
