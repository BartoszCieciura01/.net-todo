using System;
using System.ComponentModel.DataAnnotations;

namespace CieciuraB.Todo.Web.Persist.Domain
{
    public class Item
    {
        public Guid Id { get; set; }

        [Display(Name = "Kod")] public string Kod { get; set; }

        [Display(Name = "Komunikat")] [DataType(DataType.MultilineText)] public string Komunikat { get; set; }
        [Display(Name = "Przyczyna")] [DataType(DataType.MultilineText)] public string Przyczyna { get; set; }
        [Display(Name = "Rozwiazanie")] [DataType(DataType.MultilineText)] public string Rozwiazanie { get; set; }
        [Display(Name = "Uwaga")] [DataType(DataType.MultilineText)] public string Uwaga { get; set; }
        
    }
}