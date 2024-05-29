using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models.Entity
{
    public class FarmExpense
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Farm_Id { get; set; }
        [ForeignKey("Farm_Id")]

        public Farm Farm { get; set; }

        public DateTime Date { get; set; }

        public string Total { get; set; }

        public string Img1 { get; set; }

        public string Img2 { get; set;}

        public string Img3 { get; set;}

        public string Img4 { get; set;}

        public string Img5 { get; set;}

    }
}
