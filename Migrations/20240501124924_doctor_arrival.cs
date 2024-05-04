using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class doctor_arrival : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "arrive_time",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "leave_time",
                table: "doctor");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "arrive_time",
                table: "doctor_clinic_work",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "leave_time",
                table: "doctor_clinic_work",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "arrive_time",
                table: "doctor_clinic_work");

            migrationBuilder.DropColumn(
                name: "leave_time",
                table: "doctor_clinic_work");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "arrive_time",
                table: "doctor",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "leave_time",
                table: "doctor",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }
    }
}
