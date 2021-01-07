using System;
using System.Collections.Generic;

#nullable disable

namespace WombatLibrarianApi.Entities
{
    public partial class Bookshelf
    {
        public int? UserId { get; set; }
        public string BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
