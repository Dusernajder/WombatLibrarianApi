using System.ComponentModel.DataAnnotations;

namespace WombatLibrarianApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string BookId { get; set; }

        public Book Book { get; set; }
    }
}