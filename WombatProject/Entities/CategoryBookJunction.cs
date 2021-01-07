using System;
using System.Collections.Generic;

#nullable disable

namespace WombatLibrarianApi.Entities
{
    public partial class CategoryBookJunction
    {
        public string BookId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Category Category { get; set; }
    }
}
