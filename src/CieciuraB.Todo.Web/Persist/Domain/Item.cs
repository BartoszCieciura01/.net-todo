using System;
using System.ComponentModel.DataAnnotations;
using CieciuraB.Todo.Web.Persist.Domain;
using Microsoft.AspNetCore.Components.Forms;

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
        public PriorityDictionary Priorytet { get; set; }

        public Item()
        {
            this.Id = Guid.NewGuid();
            this.Priorytet = PriorityDictionary.Brak;
        }
    }

    
    
}