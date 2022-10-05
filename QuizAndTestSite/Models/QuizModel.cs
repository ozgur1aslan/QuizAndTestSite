using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAndTestSite.Models
{
    public class QuizModel
    {
        [Key]
        public int Id { get; set; }

        public string QuizName { get; set; }

        public string Category { get; set; }


        //public int CategoryModelId { get; set; }
        //[ForeignKey("CategoryModelId")]

        //public virtual CategoryModel CategoryModel { get; set; }

    }
}
