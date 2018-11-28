using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Models.AuthorizationOfModels
{
    public class Login
    {
        [Required(ErrorMessage = "Поле Email обязательно для заполнения")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email адрес указан не правильно")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Полу пароль обезательно для заполнения")]
        [StringLength(20,MinimumLength =5,ErrorMessage = "Следует указать пароль от 5 до 20 символов")]
        [DataType(DataType.Password)]
        [Display(Name ="Пароль")]
        public string Password { get; set; }
    }
}