using BlazorProducts.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BlazorProducts.Api.Data.EntityConfigurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
			builder.HasData
			(
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				}, 
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				}, 
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Fortnite - The Last Laugh Bundle",
					Description = @"Genius comes in many forms - whether you're dangerously funny, creating havoc with wild plants, or flooding the island with your best intentions; it often comes along with a companion: madness. Includes:",
					Supplier = "‪Epic Games Inc.‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.19885.14562853408080210.9df454fb-cd8a-4578-8b7c-71ceeede0d82.31554d73-4891-42e0-bc00-3d38999fe6f5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Xbox Game Studios",
					Description = @"Gears 5 is completely refreshed. Get the celebrated campaign, recharged multiplayer and Hivebusters campaign expansion as part of the Game of the Year Edition.",
					Supplier = "Code Maze",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.27223.14591801423393397.b86e1d42-e161-4ada-971f-c3354763da8a.918305fb-c146-4d2e-895a-b40f8fd23ab1?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 35
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Mortal Kombat 11 Ultimate + Injustice 2 Leg.Edition Bundle",
					Description = @"The Ultimate Fighter Bundle delivers the ultimate 1-2 punch, combining both of NetherRealm Studios' blockbuster fighting franchises in one knockout package. Includes Mortal Kombat 11 Ultimate and Injustice™ 2 - Legendary Edition.",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.60833.13792213938743512.bd91b2c1-db40-4d72-8440-88232c27c7cc.d18d1d59-711c-445d-ad84-8cee0d346d2c?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Thanks A Million Johnny Cage",
					Description = @"Play as Thanks A Million Johnny Cage, a thank you from Johnny Cage to his millions of fans!",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.64948.13866527031028707.c50ab550-0e1e-45dc-bbc3-0df22c0a9826.daa71816-6d49-4684-a45f-8690f6ef9878?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Shao Kahn",
					Description = @"Emperor of Outworld. For millennia, Shao Kahn dominated the realms, rapidly expanding his Empire by conquest. But when he set out to claim",
					Supplier = "Warner Bros. Interactive Entertainment",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.8648.69729254396770513.18e780c7-4c96-46dc-b15b-2fada18780b0.19973a6f-4cce-4451-b377-b8028976cb46?mode=scale&q=90&h=300&w=200&format=jpg",
					Price = 25
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "The Sims™ 4",
					Description = @"Unleash your imagination and create a unique world of Sims that’s an expression of you! Explore and customize every detail from Sims to homes, and much more. Choose how Sims look, act, and dress, then build and design their incredible homes.",
					Supplier = "Electronic Arts‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.53697.64737940845214615.82a9a5cd-32c5-4fb1-a951-2a7b976ad460.f0e0779f-450f-421f-b0c6-7b04bf25fa60?mode=scale&q=90&h=300&w=200",
					Price = 50
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Gang Beasts",
					Description = @"Gang Beasts is a silly multiplayer party game with surly gelatinous characters, brutal slapstick fight sequences, and absurd hazardous environments, set in the mean streets of Beef City.",
					Supplier = "Boneloaf‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.35593.68150164172276526.ddc374d7-ef5e-43b9-940a-bbc04440bb33.e0c05607-881c-449f-826b-fec43403598c?mode=scale&q=90&h=300&w=200",
					Price = 15
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Borderlands Legendary Collection",
					Description = @"Get 3 times the mayhem, 3 times the loot, and 3 times the action with the Borderlands Legendary Collection!",
					Supplier = "2K",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.29359.13544035497810545.ca0e1ab6-caad-4791-8f56-a4ce8896d945.cd29937c-6c31-4e67-960a-b68319c258a5?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 56
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Brothers: a Tale of Two Sons",
					Description = @"The critically acclaimed and award winning masterpiece arrives with Bonus Content including Director’s Walkthrough commentary, Art and Sound Gallery. Guide two brothers at the same time in co-op play in single player, on an unforgettable journey from visionary Swedish film director Josef Fares",
					Supplier = "505 Games‬",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.54833.67312949670211111.e02ca682-7627-49bb-a230-6f831f2e93d2.ba364000-a28e-4117-b936-c0d1b77af8a5?mode=scale&q=90&h=300&w=200",
					Price = 29
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "DOOM + Wolfenstein II Bundle",
					Description = @"Enjoy two amazingly fun and critically acclaimed first person shooters with the DOOM and Wolfenstein II bundle!",
					Supplier = "Bethesda Softworks",
					ImageUrl = "https://store-images.s-microsoft.com/image/apps.38228.67745962660347843.de2eb3d7-c916-4aba-a659-00fc668328b3.c1fd0971-803b-48c2-9acb-18df5c9ed7bc?mode=scale&q=90&h=300&w=200&background=%23FFFFFF",
					Price = 45
				}
			);
		}
    }
}
