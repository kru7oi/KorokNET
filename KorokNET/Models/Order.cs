using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KorokNET.Models;

public partial class Order
{
    [Display(Name = "Идентификатор")]
    public int Id { get; set; }
    [Display(Name = "Идентификатор курса")]
    public int CourseId { get; set; }
    [Display(Name = "Дата начала обучения")]
    public DateTime DateOfStudy { get; set; }
    [Display(Name = "Идентификатор способа оплаты")]
    public int PaymentMethodId { get; set; }
    [Display(Name = "Идентификатор статуса заявки")]
    public int OrderStatusId { get; set; }
    [Display(Name = "Идентификатор пользователя")]
    public int UserId { get; set; }
    [Display(Name = "Курс")]
    public virtual Course Course { get; set; } = null!;
    [Display(Name = "Статус заявки")]
    public virtual OrderStatus OrderStatus { get; set; } = null!;
    [Display(Name = "Способ оплаты")]
    public virtual PaymentMethod PaymentMethod { get; set; } = null!;
    [Display(Name = "Пользователь")]
    public virtual User User { get; set; } = null!;
}
