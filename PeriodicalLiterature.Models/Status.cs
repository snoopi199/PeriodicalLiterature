using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Models
{
    public class Status
    {
        public static string FirstStageVerification { get => "Проверка первого этапа"; }
        public static string SecondStageVerification { get => "Проверка второго этапа"; }
        public static string Canceled { get => "Отменен"; }
        public static string Confirmed { get => "Подтвержденный"; }
    }
}