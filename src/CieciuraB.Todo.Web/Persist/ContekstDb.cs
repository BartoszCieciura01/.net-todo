using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CieciuraB.Todo.Web.Persist.Domain;

namespace CieciuraB.Todo.Web.Persist
{
    public static class ContekstDb
    {
        public static List<Item> Items { get; set; }

        public static void Init()
        {
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            Items=new List<Item>();
            
            var item = new Item();
            item.Name = "Zad 1";
            item.Description = "Opis zadania 1";
            
            Items.Add(item: item);

            
            var item2 = new Item();
            item2.Name = "Zad 2";
            item2.Description = "Opis zadania numer 2";
            
            Items.Add(item: item2);
            
            var item3 = new Item();
            item3.Name = "Zadanie 3";
            item3.Description = "Opis zadania 3";
            
            Items.Add(item: item3);
            
        }
    }
}