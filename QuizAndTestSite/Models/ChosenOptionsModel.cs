using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAndTestSite.Models
{
    public class ChosenOptionsModel
    {
        [Key]
        public int Id { get; set; }
        public string ChosenOption_1 { get; set; }

        public string ChosenOption_2 { get; set; }

        public string ChosenOption_3 { get; set; }

        public string ChosenOption_4 { get; set; }

        public string ChosenOption_5 { get; set; }

        public int QuizModelId { get; set; }
        [ForeignKey("QuizModelId")]

        public virtual QuizModel QuizModel { get; set; }
    }
}
