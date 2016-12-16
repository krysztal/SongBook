using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using espiewnik.Entities;

namespace espiewnik.Migrations
{
    [DbContext(typeof(SpiewnikContext))]
    [Migration("20161216000532_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("espiewnik.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("PerentId");

                    b.HasKey("Id");

                    b.HasIndex("PerentId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("espiewnik.Entities.CategorySong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("SongId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SongId");

                    b.ToTable("CategorySong");
                });

            modelBuilder.Entity("espiewnik.Entities.Composer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("ShortSurname")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Composer");
                });

            modelBuilder.Entity("espiewnik.Entities.Elaboration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Language")
                        .HasMaxLength(20);

                    b.Property<int>("SongId");

                    b.Property<string>("Text");

                    b.Property<string>("Year")
                        .HasMaxLength(4);

                    b.HasKey("Id");

                    b.HasIndex("SongId");

                    b.ToTable("Elaboration");
                });

            modelBuilder.Entity("espiewnik.Entities.ElaborationComposer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComposerId");

                    b.Property<int>("ElaborationId");

                    b.HasKey("Id");

                    b.HasIndex("ComposerId");

                    b.HasIndex("ElaborationId");

                    b.ToTable("ElaborationComposer");
                });

            modelBuilder.Entity("espiewnik.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElaborationId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int?>("ScopeId");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("ElaborationId");

                    b.HasIndex("ScopeId");

                    b.HasIndex("TypeId");

                    b.ToTable("File");
                });

            modelBuilder.Entity("espiewnik.Entities.FileType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("FileType");
                });

            modelBuilder.Entity("espiewnik.Entities.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Instrument");
                });

            modelBuilder.Entity("espiewnik.Entities.Scope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElaborationId");

                    b.Property<int?>("InstrumentId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int?>("VoiceId");

                    b.HasKey("Id");

                    b.HasIndex("InstrumentId");

                    b.HasIndex("VoiceId");

                    b.ToTable("Scope");
                });

            modelBuilder.Entity("espiewnik.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("espiewnik.Entities.Voice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Voice");
                });

            modelBuilder.Entity("espiewnik.Entities.Category", b =>
                {
                    b.HasOne("espiewnik.Entities.Category", "Parent")
                        .WithMany("SubCategories")
                        .HasForeignKey("PerentId");
                });

            modelBuilder.Entity("espiewnik.Entities.CategorySong", b =>
                {
                    b.HasOne("espiewnik.Entities.Category", "Category")
                        .WithMany("CategorySongs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("espiewnik.Entities.Song", "Song")
                        .WithMany("CategoriesSong")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("espiewnik.Entities.Elaboration", b =>
                {
                    b.HasOne("espiewnik.Entities.Song")
                        .WithMany("Elaborations")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("espiewnik.Entities.ElaborationComposer", b =>
                {
                    b.HasOne("espiewnik.Entities.Composer", "Composer")
                        .WithMany("ElaborationsComposer")
                        .HasForeignKey("ComposerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("espiewnik.Entities.Elaboration", "Elaboration")
                        .WithMany()
                        .HasForeignKey("ElaborationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("espiewnik.Entities.File", b =>
                {
                    b.HasOne("espiewnik.Entities.Elaboration", "Elaboration")
                        .WithMany()
                        .HasForeignKey("ElaborationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("espiewnik.Entities.Scope", "Scope")
                        .WithMany("Files")
                        .HasForeignKey("ScopeId");

                    b.HasOne("espiewnik.Entities.FileType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("espiewnik.Entities.Scope", b =>
                {
                    b.HasOne("espiewnik.Entities.Instrument", "Instriment")
                        .WithMany("Scops")
                        .HasForeignKey("InstrumentId");

                    b.HasOne("espiewnik.Entities.Elaboration", "Elaboration")
                        .WithMany()
                        .HasForeignKey("VoiceId");

                    b.HasOne("espiewnik.Entities.Voice", "Voice")
                        .WithMany("Scops")
                        .HasForeignKey("VoiceId");
                });
        }
    }
}
