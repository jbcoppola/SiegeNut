namespace SiegeNut.Migrations
{
    using Microsoft.AspNet.Identity;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SiegeNut.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SiegeNut.Models.ApplicationDbContext";
        }

        protected override void Seed(SiegeNut.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("Password@123");
            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "king henry",
                    PasswordHash = password
                },
                new ApplicationUser
                {
                    UserName = "MilitiaManXX",
                    PasswordHash = password
                },
                new ApplicationUser
                {
                    UserName = "LootnPlunder",
                    PasswordHash = password
                },
                new ApplicationUser
                {
                    UserName = "happysburg",
                    PasswordHash = password
                },
                new ApplicationUser
                {
                    UserName = "TowerSitter",
                    PasswordHash = password
                },
                new ApplicationUser
                {
                    UserName = "cold_steel_hot_oil",
                    PasswordHash = password
                },
                new ApplicationUser
                {
                    UserName = "potshot",
                    PasswordHash = password
                },
                new ApplicationUser
                {
                    UserName = "goldcrown50",
                    PasswordHash = password
                });

            int trebuchet = 1;
            int batteringram = 2;
            int portcullis = 3;
            context.Reviews.AddOrUpdate(
                x => x.ID,
                new Review()
                {
                    ID = 1,
                    ProductID = trebuchet,
                    Title = "Destroyed my lying wife's bedchambers from 300 yards",
                    Rating = 10,
                    AuthorID = "159f7b28-b388-48f2-b0d7-5bd97c85ed03",
                    MainText = "Duis nec tortor arcu. Praesent eu arcu felis. Donec non lectus aliquam, venenatis augue vel, mollis ante. Integer id lorem vel est rhoncus mattis. Maecenas dapibus mauris ac est pretium mattis. Vivamus eros turpis, pulvinar et dolor non, imperdiet lacinia arcu. Proin tempus nisl et egestas mollis. Sed suscipit, velit vitae aliquam imperdiet, nibh tellus gravida est, vitae congue libero libero sed lectus. Quisque pellentesque leo felis, sed lacinia nibh tincidunt quis. Vestibulum tempor felis eget orci sodales, fringilla vehicula leo consequat.",
                    DateWritten = new DateTime(1511, 5, 2)
                },
                new Review()
                {
                    ID = 2,
                    ProductID = batteringram,
                    Title = "Broke against the first heavy door we came across",
                    Rating = 1,
                    AuthorID = "1e0edd05-7583-4267-8021-375f58c3a893",
                    MainText = "Nullam feugiat gravida eros, quis pretium tortor dapibus at. Ut et consectetur orci. Etiam consequat est nec risus lobortis venenatis. Nunc at tellus ac turpis tempor euismod. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris pellentesque nibh id ante auctor, sed efficitur massa tincidunt. Mauris in dictum mauris. Nam eget leo quam. Phasellus finibus efficitur libero eget finibus. Donec fermentum sapien est, in tempor est consectetur sit amet. Sed condimentum maximus ex eget rhoncus. Nam volutpat interdum massa congue luctus. Pellentesque lectus erat, blandit quis sapien nec, tempus tempus nunc. Curabitur posuere magna urna, nec porttitor metus gravida sit amet. Pellentesque molestie commodo nulla vel convallis. Mauris varius vitae dui ut dapibus. ",
                    DateWritten = new DateTime(1317, 8, 14)
                },
                new Review()
                {
                    ID = 3,
                    ProductID = trebuchet,
                    Title = "City walls never stood a chance",
                    Rating = 9,
                    AuthorID = "2a9d1842-f511-4037-9c52-ef2a4f5d96bf",
                    MainText = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer accumsan nisl ac libero pulvinar, nec malesuada diam molestie. Ut mattis, tellus quis finibus luctus, libero arcu rhoncus ex, eget pulvinar turpis erat quis tellus. Duis luctus laoreet finibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vestibulum malesuada est, id efficitur diam feugiat ut. Mauris eget rhoncus mi. Phasellus id nibh ut sem malesuada gravida. Ut varius lorem sed nulla iaculis, quis eleifend neque condimentum. Quisque sed dui eget justo mattis rutrum quis ac lectus.",
                    DateWritten = new DateTime(1452, 3, 11)
                },
                new Review()
                {
                    ID = 4,
                    ProductID = batteringram,
                    Title = "Too heavy for stairwork",
                    Rating = 6,
                    AuthorID = "32f5cfd5-8d9d-4b93-b5f3-9b8b0558ab97",
                    MainText = "Duis turpis mi, feugiat et tempus a, scelerisque ut nibh. Morbi dapibus efficitur tincidunt. Mauris at aliquet velit. Maecenas placerat, massa rutrum rutrum auctor, felis ante facilisis sapien, et pellentesque purus elit eget odio. Sed pretium sagittis erat, et laoreet arcu aliquet a. ",
                    DateWritten = new DateTime(1475, 6, 5)
                },
                new Review()
                {
                    ID = 5,
                    ProductID = portcullis,
                    Title = "Overly brittle for the size",
                    Rating = 5,
                    AuthorID = "556e72c4-66c8-4ec7-b00c-be06332797dd",
                    MainText = "Praesent ac euismod elit, euismod malesuada enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nunc non orci quis libero fringilla pulvinar. Fusce tempor ipsum lorem, eget pellentesque mauris placerat aliquet. Aliquam erat volutpat. Nam ac fermentum massa. Fusce vulputate libero ligula, id interdum risus congue eu. Proin sed nisi ligula. In hac habitasse platea dictumst. ",
                    DateWritten = new DateTime(1502, 1, 28)
                },
                new Review()
                {
                    ID = 6,
                    ProductID = trebuchet,
                    Title = "MISSING 8 PEGS FROM PREPACKAGED KIT. WANT FULL REFUND",
                    Rating = 1,
                    AuthorID = "56679e99-d5cd-4423-9e5b-a446a1f2b888",
                    MainText = "Nunc aliquet nunc et mi posuere venenatis. Aliquam lobortis finibus rhoncus. Curabitur lobortis turpis nisi, quis tristique tellus pretium in. Nam eu tincidunt odio, sed sollicitudin metus. Ut augue nibh, tempus nec mauris ut, vestibulum hendrerit lacus. Curabitur ante neque, lacinia ac enim at, viverra ultricies nisi. Quisque dapibus eget nibh vel tempus. Fusce vehicula leo vitae vulputate facilisis. Duis eu commodo enim. ",
                    DateWritten = new DateTime(1345, 11, 6)
                },
                new Review()
                {
                    ID = 7,
                    ProductID = trebuchet,
                    Title = "throws well but needs wheels, lacks portability",
                    Rating = 7,
                    AuthorID = "5f6808e1-f6e9-4b0d-a0f3-46e64f82bf4b",
                    MainText = "Interdum et malesuada fames ac ante ipsum primis in faucibus. Donec condimentum ipsum a nibh porta lacinia. Aliquam sem risus, tempus sit amet elementum quis, posuere ac felis. Suspendisse elementum nunc eu laoreet maximus. Fusce turpis velit, laoreet sit amet dictum id, euismod in mauris. Etiam tincidunt, magna vel blandit dapibus, felis odio tempus lectus, ut consequat lacus justo vel justo. Aenean ex nunc, elementum at sodales non, tincidunt in tortor. ",
                    DateWritten = new DateTime(1432, 2, 23)
                },
                new Review()
                {
                    ID = 8,
                    ProductID = portcullis,
                    Title = "trapped some men-at-arms very nicely",
                    Rating = 10,
                    AuthorID = "6d23fe06-2c7a-4052-9355-e8d192f57ca1",
                    MainText = "Donec sem tellus, facilisis sed imperdiet sit amet, ultrices nec massa. Sed ac augue elementum, rutrum est at, facilisis felis. Phasellus nec lobortis lectus. Nunc porta nunc odio, id posuere ex ornare in. Donec consequat, magna eu tempus dignissim, nulla purus tempor risus, id dignissim diam tellus ac lorem. Donec malesuada, orci quis ullamcorper tincidunt, nibh erat elementum purus, non dictum dolor arcu non felis. ",
                    DateWritten = new DateTime(1489, 7, 19)
                }
                );
        }
    }
}
