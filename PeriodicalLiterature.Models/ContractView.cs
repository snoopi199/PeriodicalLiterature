using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Models
{
    public class ContractView
    {
        //[Required (ErrorMessage = "The id of contract is not exist!")]
        //public Guid Id { get; set; }

        //[Required(ErrorMessage = "The id of user is  not exist")]
        //public Guid PublisherId { get; set; }
        //public Publisher Publisher { get; set; }

        [Required(ErrorMessage = "Поле Название издания обязательно для заполнения")]
        [Display(Name = "Название издания")]
        [StringLength (200,MinimumLength =5, ErrorMessage = "Название издания должно содержать более 5 и мение 200 символов")]
        public string TitleEdition { get; set; }



        [Required(ErrorMessage = "Категория должна быть выбрана")]
        [Display(Name = "Категория")]
        public string Category { get; set; }
        //magazine
        //newspaper

        [Required(ErrorMessage = "Язык должн быть выбрана")]
        [Display(Name = "Язык")]
        public string Language { get; set; }
        //Русский
        //Английский


        [Required(ErrorMessage = "Выберите один или несколько жанров")]
        [Display(Name = "Жанр")]
        public ICollection<string> Genre { get; set; }


        [Required(ErrorMessage = "Переодичность издания должно быть выбрано")]
        [Display(Name = "Переодичность")]
        public string Periodical { get; set; }
        //Daily
        //Weekly
        //Monthly
        //Quarterly
        //Semiannually
        //Yearly

        [Required(ErrorMessage = "Цена должна быть указана. Если издание бесплатно поставте: '0'")]
        [Display(Name = "Цена за новый выпуск")]
        [DataType(DataType.Currency)]
        public decimal PriceForNewRelease { get; set; }

        [UIHint("MultilineText")]
        [Required(ErrorMessage = "Поле Описание издания обязательно для заполнения")]
        [Display(Name = "Описанмие издания")]
        [StringLength(1000, MinimumLength = 200, ErrorMessage = "Описание издания должно содержать более 200 и мение 1000 символов")]
        public string DescriptionEdition { get; set; }

        //public Guid PictureId { get; set; }

        [Required(ErrorMessage = "Обложка должна присутствовать")]
        [Display(Name = "Загрузить обложку")]
        public HttpPostedFileBase Cover { get; set; }
        //public Guid CoverId { get; set; }

        [Required(ErrorMessage = "Издание должно присутствовать")]
        [Display(Name = "Прикрепить издание")]
        public HttpPostedFileBase File { get; set; }
        //public Guid FileId { get; set; }

        //public Guid FileId { get; set; }

        public ContractView()
        {   
            Genre = new List<string>();          
        }

    }
}