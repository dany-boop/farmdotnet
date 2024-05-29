using System.ComponentModel.DataAnnotations;

namespace MVC.Models.Entity
{
    public class FarmExpenseCategory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public bool Is_active { get; set; } = true;
    }
}
