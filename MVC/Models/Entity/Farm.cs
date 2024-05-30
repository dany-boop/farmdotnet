using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models.Entity
{
    public class Farm
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Code { get; set; } 

        public string Type_Id { get; set; }
        [ForeignKey("Id")]
        public CattleType Type { get; set; }

        public Guid Investor_Id { get; set; }
        [ForeignKey ("Investor_Id")]
        public User Investor { get; set; }
        public int Buy_Price { get; set; }

        public int Sell_Price { get; set; }

        public int Treament_Price { get; set;}

        public int status { get; set; }

        public Guid Male_Breeder { get; set; }

        public Guid Male_Id { get;}

        public Guid Female_Breeder { get; set; }

        public Guid Female_Id { get; }
    }
}
