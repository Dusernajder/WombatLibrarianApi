using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WombatLibrarianApi.Models
{
    [Keyless]
    public class Wishlist
    {
        public int UserId { get; set; }
        public string BookId { get; set; }

        public User User { get; set; }
        public Book Book { get; set; }
    }
}
