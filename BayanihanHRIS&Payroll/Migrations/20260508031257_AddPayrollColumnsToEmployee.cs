using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BayanihanHRIS_Payroll.Migrations
{
    /// <inheritdoc />
    public partial class AddPayrollColumnsToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HolidayPay",
                table: "Payslips");

            migrationBuilder.RenameColumn(
                name: "NightDiffPay",
                table: "Payslips",
                newName: "GrossPay");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankAccountName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankAccountNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankBranch",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateHired",
                table: "Employees",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyRate",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PagIbigNumber",
                table: "Employees",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhilHealthNumber",
                table: "Employees",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SSSNumber",
                table: "Employees",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TINNumber",
                table: "Employees",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BankAccountName", "BankAccountNumber", "BankBranch", "BirthDate", "DateHired", "DepartmentId", "EmployeeNumber", "FirstName", "LastName", "MiddleName", "MonthlyRate", "PagIbigNumber", "PhilHealthNumber", "SSSNumber", "Status", "TINNumber" },
                values: new object[] { 1, null, null, null, new DateOnly(1, 1, 1), new DateOnly(2024, 1, 1), null, 1001, "Juan", "Dela Cruz", null, 25000.00m, null, null, null, 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_Payslips_PayrollRunId",
                table: "Payslips",
                column: "PayrollRunId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payslips_PayrollRuns_PayrollRunId",
                table: "Payslips",
                column: "PayrollRunId",
                principalTable: "PayrollRuns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payslips_PayrollRuns_PayrollRunId",
                table: "Payslips");

            migrationBuilder.DropIndex(
                name: "IX_Payslips_PayrollRunId",
                table: "Payslips");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "BankAccountName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BankAccountNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BankBranch",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateHired",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MonthlyRate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PagIbigNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhilHealthNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SSSNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TINNumber",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "GrossPay",
                table: "Payslips",
                newName: "NightDiffPay");

            migrationBuilder.AddColumn<decimal>(
                name: "HolidayPay",
                table: "Payslips",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
