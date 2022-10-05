using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAndTestSite.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        public string CategoryName { get; set; }
    }
}
