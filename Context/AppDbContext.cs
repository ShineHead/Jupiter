using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jupiter.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jupiter.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Title> Titles {get; set;}

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems {get; set;}



        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData
                (
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Horror"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Platformer"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Racing"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "RPG"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Strategy"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Survival"
                }
                );


            modelBuilder.Entity<Title>().HasData
            (
            new Title
            {
                Id = 1,
                Name = "TitanFall 2",
                Description = "Titanfall 2 is a first-person shooter video game, developed by Respawn Entertainment and published by Electronic Arts. A sequel to 2014's Titanfall, the game was released worldwide on October 28, 2016 for Windows, PlayStation 4, and Xbox One.",
                ImageUrl = "/images/titanfall2.jpg",
                ImageThumbnailUrl = "/images/titanfall2.jpg",
                UserRating = "5/5",
                Price = 25,
                GameCategory = Enums.EGameCategory.Action,
                Publisher = "Electronic Arts",
                ReleaseDate = "2016",


                videosource = "https://www.youtube.com/embed/VqeMjHmL9eg",
                Carousel1 = "/images/carousel/c_titanfall2/titanfall2_02.jpg", 
                Carousel2 = "/images/carousel/c_titanfall2/titanfall2_01.jpg",
                Carousel3 = "/images/carousel/c_titanfall2/titanfall2_03.jpg"

            },
            new Title
            {
                Id = 2,
                Name = "Mass Effect 2",
                Description = "Mass Effect 2 is an action role-playing video game developed by BioWare and published by Electronic Arts. It was released for Microsoft Windows and Xbox 360 in 2010, and PlayStation 3 in 2011. Mass Effect 2 is the second installment of the Mass Effect series and a sequel to the original Mass Effect. ",
                ImageUrl = "/images/masseffect2.jpg",
                ImageThumbnailUrl = "/images/masseffect2.jpg",
                UserRating = "5/5",
                Price = 10,
                GameCategory = Enums.EGameCategory.Action,
                Publisher = "Electronic Arts",
                ReleaseDate = "2010",


                videosource = "https://www.youtube.com/embed/PHCA8tK117c",
                Carousel1 = "/images/carousel/c_masseffect2/masseffect2_01.jpg",
                Carousel2 = "/images/carousel/c_masseffect2/masseffect2_02.jpg",
                Carousel3 = "/images/carousel/c_masseffect2/masseffect2_03.jpg"


            },
            new Title
            {
                Id = 3,
                Name = "Alien Isolation",
                Description = "Alien: Isolation is a 2014 survival horror video game developed by Creative Assembly and published by Sega originally for Microsoft Windows, PlayStation 3, PlayStation 4, Xbox 360 and Xbox One.",
                ImageUrl = "/images/alienisolation.jpg",
                ImageThumbnailUrl = "/images/alienisolation.jpg",
                UserRating = "4/5",
                Price = 30,
                GameCategory = Enums.EGameCategory.Horror,
                Publisher = "Sega",
                ReleaseDate = "2014",


                videosource = "https://www.youtube.com/embed/7h0cgmvIrZw",
                Carousel1 = "/images/carousel/c_alienisolation/alienisolation_01.jpg",
                Carousel2 = "/images/carousel/c_alienisolation/alienisolation_02.jpg",
                Carousel3 = "/images/carousel/c_alienisolation/alienisolation_03.jpg"
            },
            new Title
            {
                Id = 4,
                Name = "Dirt 3",
                Description = "Dirt 3 is a racing video game developed and published by Codemasters for Microsoft Windows, PlayStation 3 and Xbox 360. It is the eighth game in the Colin McRae Rally series.",
                ImageUrl = "/images/dirt3.jpg",
                ImageThumbnailUrl = "/images/dirt3.jpg",
                UserRating = "3.5/5",
                Price = 20,
                GameCategory = Enums.EGameCategory.Racing,
                Publisher = "Codemasters",
                ReleaseDate = "2010",


                videosource = "https://www.youtube.com/embed/_MgSPOgcUyQ",
                Carousel1 = "/images/carousel/c_dirt3/dirt3_01.jpg",
                Carousel2 = "/images/carousel/c_dirt3/dirt3_02.jpg",
                Carousel3 = "/images/carousel/c_dirt3/dirt3_03.jpg"
            },
            new Title
            {
                Id = 5,
                Name = "Ori And The Blind Forest",
                Description = "Ori And The Blind Forest",
                ImageUrl = "/images/ori.jpg",
                ImageThumbnailUrl = "/images/ori.jpg",
                UserRating = "4/5",
                Price = 25,
                GameCategory = Enums.EGameCategory.Platformer,
                Publisher = "Microsoft Studios",
                ReleaseDate = "2015",

                videosource = "https://www.youtube.com/embed/cklw-Yu3moE",
                Carousel1 = "/images/carousel/c_ori/ori_01.jpg",
                Carousel2 = "/images/carousel/c_ori/ori_02.jpg",
                Carousel3 = "/images/carousel/c_ori/ori_03.jpg"
            },
            new Title
            {
                Id = 6,
                Name = "Skyrim",
                Description = "Ori and the Blind Forest is a platform-adventure Metroidvania video game developed by Moon Studios and published by Microsoft Studios. The game was released for Xbox One and Microsoft Windows on March 11, 2015 and for Nintendo Switch on September 27, 2019.",
                ImageUrl = "/images/skyrim.jpg",
                ImageThumbnailUrl = "/images/skyrim.jpg",
                UserRating = "5/5",
                Price = 15,
                GameCategory = Enums.EGameCategory.RPG,
                Publisher = "Bethesda",
                ReleaseDate = "2011",

                videosource = "https://www.youtube.com/embed/JSRtYpNRoN0",
                Carousel1 = "/images/carousel/c_skyrim/skyrim_01.jpg",
                Carousel2 = "/images/carousel/c_skyrim/skyrim_02.jpg",
                Carousel3 = "/images/carousel/c_skyrim/skyrim_03.jpg"
            },
            new Title
            {
                Id = 7,
                Name = "The Forest",
                Description = "The Forest is a survival video game developed and published by Endnight Games. The game takes place on a remote, heavily forested peninsula where the player character Eric Leblanc and his son Timmy are survivors of a plane crash.",
                ImageUrl = "/images/theforest.jpg",
                ImageThumbnailUrl = "/images/theforest.jpg",
                UserRating = "4/5",
                Price = 15,
                GameCategory = Enums.EGameCategory.Survival,
                Publisher = "Endnight Games",
                ReleaseDate = "2017",

                videosource = "https://www.youtube.com/embed/7mwn5U2PNvk",
                Carousel1 = "/images/carousel/c_theforest/theforest_01.jpg",
                Carousel2 = "/images/carousel/c_theforest/theforest_02.jpg",
                Carousel3 = "/images/carousel/c_theforest/theforest_03.jpg"
            },
            new Title
            {
                Id = 8,
                Name = "XCOM: Enemy Unknown",
                Description = "XCOM: Enemy Unknown is a 2012 turn-based tactical video game developed by Firaxis Games and published by 2K Games. The game is a reimagined remake of the 1994 cult classic strategy game UFO: Enemy Unknown and a reboot of MicroProse's 1990s X-COM series.",
                ImageUrl = "/images/xcom.jpg",
                ImageThumbnailUrl = "/images/xcom.jpg",
                UserRating = "5/5",
                Price = 25,
                GameCategory = Enums.EGameCategory.Strategy,
                Publisher = "2K Games",
                ReleaseDate = "2014",

                videosource = "https://www.youtube.com/embed/L2o2iW4mPR8",
                Carousel1 = "/images/carousel/c_xcom/xcom_01.jpg",
                Carousel2 = "/images/carousel/c_xcom/xcom_02.jpg",
                Carousel3 = "/images/carousel/c_xcom/xcom_03.jpg"
            },
            new Title
            {
                Id = 9,
                Name = "Doom Eternal",
                Description = "Doom Eternal is a first-person shooter video game developed by id Software and published by Bethesda Softworks. The sequel to Doom, and the fifth main game in the Doom series, it was released on March 20, 2020, for Windows, PlayStation 4, Stadia and Xbox One, with a Nintendo Switch version planned.",
                ImageUrl = "/images/doometernal.jpg",
                ImageThumbnailUrl = "/images/doometernal.jpg",
                UserRating = "5/5",
                Price = 40,
                GameCategory = Enums.EGameCategory.Action,
                Publisher = "ID Software",
                ReleaseDate = "2019",
                
                videosource = "https://www.youtube.com/embed/_oVwrpfo_QA",
                Carousel1 = "/images/carousel/c_doometernal/doometernal_01.jpg",
                Carousel2 = "/images/carousel/c_doometernal/doometernal_02.jpg",
                Carousel3 = "/images/carousel/c_doometernal/doometernal_03.jpg"
            },
            new Title
            {
                Id = 10,
                Name = "Stellaris",
                Description = "Stellaris is a 4X grand strategy video game developed and published by Paradox Interactive. Stellaris's gameplay revolves around space exploration, managing an empire, diplomacy, and space warfare with other spacefaring civilizations.",
                ImageUrl = "/images/stellaris.jpg",
                ImageThumbnailUrl = "/images/stellaris.jpg",
                UserRating = "5/5",
                Price = 30,
                GameCategory = Enums.EGameCategory.Action,
                Publisher = "Paradox Interactive",
                ReleaseDate = "2016",

                videosource = "https://www.youtube.com/embed/Zh9yZNrb62U",
                Carousel1 = "/images/carousel/c_stellaris/stellaris_01.jpg",
                Carousel2 = "/images/carousel/c_stellaris/stellaris_02.jpg",
                Carousel3 = "/images/carousel/c_stellaris/stellaris_03.jpg"
            }

            );


        }






    }
}
