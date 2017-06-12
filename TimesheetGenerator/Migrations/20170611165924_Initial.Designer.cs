using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TimesheetGenerator.Models;

namespace TimesheetGenerator.Migrations
{
    [DbContext(typeof(TimesheetGeneratorContext))]
    [Migration("20170611165924_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimesheetGenerator.Models.Timesheet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CandidateName");

                    b.Property<string>("ClientName");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("JobTitle");

                    b.Property<int>("PlacementType");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.ToTable("Timesheet");
                });
        }
    }
}
