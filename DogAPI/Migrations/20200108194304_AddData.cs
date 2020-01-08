using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DogAPI.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "BestSkill", "Name", "Race" },
                values: new object[,]
                {
                    { new Guid("b403ba35-fd18-4516-ae30-c8b1a648c20a"), "Policing", "Lasse", "German Sheperd" },
                    { new Guid("3df54d3b-7b9f-4396-8628-fcb71d982058"), "Allways ready to eat the food you dont want", "Ronny", "Golden Retriever" },
                    { new Guid("1117c3e0-94cc-47dd-abb9-361e4421aa15"), "Highly developed hunting instincts", "Pelle", "Weimaraner" },
                    { new Guid("4063728d-40a9-4ee3-a5bb-e6455f128578"), "Very loud", "Kalle", "Papillon" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("1117c3e0-94cc-47dd-abb9-361e4421aa15"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("3df54d3b-7b9f-4396-8628-fcb71d982058"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("4063728d-40a9-4ee3-a5bb-e6455f128578"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b403ba35-fd18-4516-ae30-c8b1a648c20a"));
        }
    }
}
