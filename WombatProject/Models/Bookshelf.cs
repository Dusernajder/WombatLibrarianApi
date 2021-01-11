using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WombatLibrarianApi.Models
{
    [Keyless]
    public class Bookshelf
    {
        public int UserId { get; set; }
        public string BookId { get; set; }

        public User User { get; set; }
        public Book Book { get; set; }
    }
}
