using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizAndTestSite.Models;

namespace QuizAndTestSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<OptionModel> Options { get; set; }

        public DbSet<QuestionModel> Questions { get; set; }

        public DbSet<QuizModel> Quizes { get; set; }

        public DbSet<ResultModel> Results { get; set; }

        public DbSet<CategoryModel> Categories { get; set; }

        public DbSet<ChosenOptionsModel> ChosenOptions { get; set; }

        public DbSet<AspNetUserModel> AspNetUsers { get; set; }

    }
}