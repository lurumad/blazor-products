using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorProducts.Api.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Supplier" },
                values: new object[,]
                {
                    { new Guid("488aaa0e-aa7e-4820-b4e9-5715f0e5186e"), "Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:", "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF", "Fortnite - The Last Laugh Bundle", 25.0, "‪Epic Games Inc.‬" },
                    { new Guid("4e693871-788d-4db4-89e5-dd7678db975e"), "Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.", "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF", "Xbox Game Studios", 35.0, "Code Maze" },
                    { new Guid("2d3c2abe-85ec-4d1e-9fef-9b4bfea5f459"), "The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.", "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF", "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle", 45.0, "Warner Bros. Interactive Entertainment" },
                    { new Guid("d1f22836-6342-480a-be2f-035eeb010fd0"), "Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!", "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg", "Thanks A Million Johnny Cage", 25.0, "Warner Bros. Interactive Entertainment" },
                    { new Guid("afa40031-c5ff-41ec-acbd-e22d1acebc85"), "Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim", "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg", "Shao Kahn", 25.0, "Warner Bros. Interactive Entertainment" },
                    { new Guid("80e33b75-5192-4c57-8553-c3f6c79a29c6"), "Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.", "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200", "The Sims™ 4", 50.0, "Electronic Arts‬" },
                    { new Guid("95ad2ba0-4864-4d47-be4d-22f41324ce07"), "Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.", "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200", "Gang Beasts", 15.0, "Boneloaf‬" },
                    { new Guid("aeb48c8e-a426-4e9c-81f3-a35206a66d49"), "Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!", "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF", "Borderlands Legendary Collection", 56.0, "2K" },
                    { new Guid("4bbb7906-ad1b-4e79-abfb-2fda7828568e"), "The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares", "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200", "Brothers: a Tale of Two Sons", 29.0, "505 Games‬" },
                    { new Guid("c7d56007-0bf8-4fcf-bf05-34d704e284ed"), "Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!", "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF", "DOOM + Wolfenstein II Bundle", 45.0, "Bethesda Softworks" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
