using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAndTestSite.Models
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public List<OptionModel> Optionlar { get; set; }
        public string Option_1 { get; set; }

        public string Option_2 { get; set; }

        public string? Option_3 { get; set; }

        public string? Option_4 { get; set; }


        //public string? ChosenOption { get; set; }
        public string CorrectOption { get; set; }


        public int QuizModelId { get; set; }
        [ForeignKey("QuizModelId")]

        public virtual QuizModel QuizModel { get; set; }

    }
}
