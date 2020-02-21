using System;
using System.ComponentModel.DataAnnotations;
namespace CieciuraB.Todo.Web.Persist.Domain
{
    public class Item
    {
        public Guid Id { get; set; }
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Display(Name = "Opis")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [Display(Name = "Priorytet")]
        public PriorityDictionary? Priorytet { get; set; }

        public Item()
        {
            this.Id = Guid.NewGuid();
            this.Priorytet = null;
        }
    }

    
    
}