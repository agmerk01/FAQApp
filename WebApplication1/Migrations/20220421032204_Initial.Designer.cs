// <auto-generated />
using FAQApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAQApp.Migrations
{
    [DbContext(typeof(FAQContext))]
    [Migration("20220421032204_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAQApp.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Cateogries");

                    b.HasData(
                        new
                        {
                            CategoryID = "gen",
                            Name = "General"
                        },
                        new
                        {
                            CategoryID = "his",
                            Name = "History"
                        });
                });

            modelBuilder.Entity("FAQApp.Models.FAQ", b =>
                {
                    b.Property<int>("FAQID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FAQID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("TopicID");

                    b.ToTable("FAQs");

                    b.HasData(
                        new
                        {
                            FAQID = 1,
                            Answer = "sample",
                            CategoryID = "gen",
                            Question = "sample",
                            TopicID = "js"
                        },
                        new
                        {
                            FAQID = 2,
                            Answer = "sample",
                            CategoryID = "gen",
                            Question = "sample",
                            TopicID = "cpp"
                        },
                        new
                        {
                            FAQID = 3,
                            Answer = "sample",
                            CategoryID = "his",
                            Question = "sample",
                            TopicID = "cpp"
                        },
                        new
                        {
                            FAQID = 4,
                            Answer = "sample",
                            CategoryID = "his",
                            Question = "sample",
                            TopicID = "js"
                        });
                });

            modelBuilder.Entity("FAQApp.Models.Topic", b =>
                {
                    b.Property<string>("TopicID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicID");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicID = "js",
                            Name = "JavaScript"
                        },
                        new
                        {
                            TopicID = "cpp",
                            Name = "C++"
                        });
                });

            modelBuilder.Entity("FAQApp.Models.FAQ", b =>
                {
                    b.HasOne("FAQApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAQApp.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
