using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAndTestSite.Models
{
    public class OptionModel
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsCorrect { get; set; }


        public int QuestionModelId { get; set; }
        [ForeignKey("QuestionModelId")]

        public virtual QuestionModel QuestionModel { get; set; }
    }
}
