using Microsoft.EntityFrameworkCore;

namespace FAQApp.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options)
        : base(options)
        { }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Cateogries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "gen", Name = "General" },
                new Category { CategoryID="his",Name="History"}
                );
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicID = "js", Name = "JavaScript" },
                new Topic { TopicID = "cpp", Name = "C++" }
                );
            modelBuilder.Entity<FAQ>().HasData(
                new FAQ 
                {
                    FAQID=1,
                    Question="sample",
                    Answer="sample",
                    CategoryID="gen",
                    TopicID="js"
                },
                new FAQ
                {
                    FAQID = 2,
                    Question = "sample",
                    Answer = "sample",
                    CategoryID = "gen",
                    TopicID = "cpp"
                },
                new FAQ
                {
                    FAQID = 3,
                    Question = "sample",
                    Answer = "sample",
                    CategoryID = "his",
                    TopicID = "cpp"
                },
                new FAQ
                {
                    FAQID = 4,
                    Question = "sample",
                    Answer = "sample",
                    CategoryID = "his",
                    TopicID = "js"
                }
                );
        }
    }
}