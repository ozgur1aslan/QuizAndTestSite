using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAndTestSite.Models
{


    public class ResultModel
    {
        [Key]
        public int Id { get; set; }
        public int CorrectAnswerCount { get; set; }

        public int Score { get; set; }
        public string AspNetUsersId { get; set; }
        [ForeignKey("AspNetUsersId")]
        public virtual AspNetUsers AspNetUsers { get; set; }
              
        public DateTime Date { get; set; }
        
        public int QuizModelId { get; set; }
        [ForeignKey("QuizModelId")]
        public virtual QuizModel QuizModel { get; set; }

    }

    public class AspNetUsers : IdentityUser
    {
        //public virtual ResultModel ResultModel { get; set; }
    }
}