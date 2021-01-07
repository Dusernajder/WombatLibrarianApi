using System;
using System.Collections.Generic;

#nullable disable

namespace WombatLibrarianApi.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HashedPass { get; set; }
    }
}
