using System;
using System.Collections.Generic;

#nullable disable

namespace WombatLibrarianApi.Entities
{
    public partial class BookAuthorJunction
    {
        public int? AuthorId { get; set; }
        public string BookId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
