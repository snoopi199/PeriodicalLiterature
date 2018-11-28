using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Models.AuthorizationOfModels
{
    public class AdminRegister
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Поле Имя обязательно для заполнения")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Следует указать Имя от 3 до 10 символов")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле Фамилия обязательно для заполнения")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Следует фамилия Имя от 3 до 15 символов")]
        [Display(Name = "Фамилия")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Поле Email обязательно для заполнения")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Пароль должен выводиться в формате Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле пароль обязательно для заполнения")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Следует указать пароль от 5 до 20 символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}