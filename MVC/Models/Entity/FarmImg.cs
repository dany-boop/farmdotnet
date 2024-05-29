using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models.Entity
{
    public class FarmImg
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid Farm_Id { get; set; }
        [ForeignKey("Farm_Id")]

        public Farm Farm { get; set; }

        public Guid Category_Id { get; set; }
        [ForeignKey ("Category_Id")]

        public FarmExpenseCategory Category { get; set; }

        public DateTime Date { get; set; }  

        public int Total { get; set; }

        public string Img1 { get; set; }
        public string Img2 { get; set;}
        public string Img3 { get; set;} 

        public string Description { get; set; }

    }
}
