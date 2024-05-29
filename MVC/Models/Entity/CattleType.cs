using System.ComponentModel.DataAnnotations;

namespace MVC.Models.Entity
{
    public class CattleType
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Note { get; set; }

        public bool Is_active { get; set; } = true;
    }
}
