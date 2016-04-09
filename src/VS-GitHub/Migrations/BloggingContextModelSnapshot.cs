using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using VS_GitHub.Models;

namespace VSGitHub.Migrations
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VS_GitHub.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("BlogId");
                });

            modelBuilder.Entity("VS_GitHub.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("PostId");
                });

            modelBuilder.Entity("VS_GitHub.Models.Post", b =>
                {
                    b.HasOne("VS_GitHub.Models.Blog")
                        .WithMany()
                        .HasForeignKey("BlogId");
                });
        }
    }
}
