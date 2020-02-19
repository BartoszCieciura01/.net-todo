using System;

namespace CieciuraB.Todo.Web.Persist.Domain
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item()
        {
            this.Id = Guid.NewGuid();
        }
    }
}