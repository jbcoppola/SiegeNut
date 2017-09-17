namespace SiegeNut.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SiegeNut.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SiegeNut.Models.SiegeNutContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SiegeNut.Models.SiegeNutContext context)
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
            context.Reviews.AddOrUpdate(
                x => x.ID,
                new Review()
                {
                    ID = 1,
                    Product = "Trebuchet",
                    Title = "Destroyed my lying wife's bedchambers from 300 yards",
                    Rating = 10,
                    Author = "King Henry",
                    MainText = "Duis nec tortor arcu. Praesent eu arcu felis. Donec non lectus aliquam, venenatis augue vel, mollis ante. Integer id lorem vel est rhoncus mattis. Maecenas dapibus mauris ac est pretium mattis. Vivamus eros turpis, pulvinar et dolor non, imperdiet lacinia arcu. Proin tempus nisl et egestas mollis. Sed suscipit, velit vitae aliquam imperdiet, nibh tellus gravida est, vitae congue libero libero sed lectus. Quisque pellentesque leo felis, sed lacinia nibh tincidunt quis. Vestibulum tempor felis eget orci sodales, fringilla vehicula leo consequat.",
                    DateWritten = new DateTime(1511, 5, 2)
                },
                new Review()
                {
                    ID = 2,
                    Product = "Battering Ram",
                    Title = "Broke against the first heavy door we came across",
                    Rating = 1,
                    Author = "MilitiaManXX",
                    MainText = "Nullam feugiat gravida eros, quis pretium tortor dapibus at. Ut et consectetur orci. Etiam consequat est nec risus lobortis venenatis. Nunc at tellus ac turpis tempor euismod. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris pellentesque nibh id ante auctor, sed efficitur massa tincidunt. Mauris in dictum mauris. Nam eget leo quam. Phasellus finibus efficitur libero eget finibus. Donec fermentum sapien est, in tempor est consectetur sit amet. Sed condimentum maximus ex eget rhoncus. Nam volutpat interdum massa congue luctus. Pellentesque lectus erat, blandit quis sapien nec, tempus tempus nunc. Curabitur posuere magna urna, nec porttitor metus gravida sit amet. Pellentesque molestie commodo nulla vel convallis. Mauris varius vitae dui ut dapibus. ",
                    DateWritten = new DateTime(1317, 8, 14)
                },
                new Review()
                {
                    ID = 3,
                    Product = "Trebuchet",
                    Title = "City walls never stood a chance",
                    Rating = 9,
                    Author = "LootnPlunder",
                    MainText = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer accumsan nisl ac libero pulvinar, nec malesuada diam molestie. Ut mattis, tellus quis finibus luctus, libero arcu rhoncus ex, eget pulvinar turpis erat quis tellus. Duis luctus laoreet finibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vestibulum malesuada est, id efficitur diam feugiat ut. Mauris eget rhoncus mi. Phasellus id nibh ut sem malesuada gravida. Ut varius lorem sed nulla iaculis, quis eleifend neque condimentum. Quisque sed dui eget justo mattis rutrum quis ac lectus.",
                    DateWritten = new DateTime(1452, 3, 11)
                },
                new Review()
                {
                    ID = 4,
                    Product = "Battering Ram",
                    Title = "Too heavy for stairwork",
                    Rating = 6,
                    Author = "happysburg",
                    MainText = "Duis turpis mi, feugiat et tempus a, scelerisque ut nibh. Morbi dapibus efficitur tincidunt. Mauris at aliquet velit. Maecenas placerat, massa rutrum rutrum auctor, felis ante facilisis sapien, et pellentesque purus elit eget odio. Sed pretium sagittis erat, et laoreet arcu aliquet a. ",
                    DateWritten = new DateTime(1475, 6, 5)
                },
                new Review()
                {
                    ID = 5,
                    Product = "Portcullis",
                    Title = "Overly brittle for the size",
                    Rating = 5,
                    Author = "TowerSitter",
                    MainText = "Praesent ac euismod elit, euismod malesuada enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nunc non orci quis libero fringilla pulvinar. Fusce tempor ipsum lorem, eget pellentesque mauris placerat aliquet. Aliquam erat volutpat. Nam ac fermentum massa. Fusce vulputate libero ligula, id interdum risus congue eu. Proin sed nisi ligula. In hac habitasse platea dictumst. ",
                    DateWritten = new DateTime(1502, 1, 28)
                },
                new Review()
                {
                    ID = 6,
                    Product = "Trebuchet",
                    Title = "MISSING 8 PEGS FROM PREPACKAGED KIT. WANT FULL REFUND",
                    Rating = 1,
                    Author = "cold_steel_hot_oil",
                    MainText = "Nunc aliquet nunc et mi posuere venenatis. Aliquam lobortis finibus rhoncus. Curabitur lobortis turpis nisi, quis tristique tellus pretium in. Nam eu tincidunt odio, sed sollicitudin metus. Ut augue nibh, tempus nec mauris ut, vestibulum hendrerit lacus. Curabitur ante neque, lacinia ac enim at, viverra ultricies nisi. Quisque dapibus eget nibh vel tempus. Fusce vehicula leo vitae vulputate facilisis. Duis eu commodo enim. ",
                    DateWritten = new DateTime(1345, 11, 6)
                },
                new Review()
                {
                    ID = 7,
                    Product = "Trebuchet",
                    Title = "throws well but needs wheels, lacks portability",
                    Rating = 7,
                    Author = "potshot",
                    MainText = "Interdum et malesuada fames ac ante ipsum primis in faucibus. Donec condimentum ipsum a nibh porta lacinia. Aliquam sem risus, tempus sit amet elementum quis, posuere ac felis. Suspendisse elementum nunc eu laoreet maximus. Fusce turpis velit, laoreet sit amet dictum id, euismod in mauris. Etiam tincidunt, magna vel blandit dapibus, felis odio tempus lectus, ut consequat lacus justo vel justo. Aenean ex nunc, elementum at sodales non, tincidunt in tortor. ",
                    DateWritten = new DateTime(1432, 2, 23)
                },
                new Review()
                {
                    ID = 8,
                    Product = "Portcullis",
                    Title = "trapped some men-at-arms very nicely",
                    Rating = 10,
                    Author = "goldcrown50",
                    MainText = "Donec sem tellus, facilisis sed imperdiet sit amet, ultrices nec massa. Sed ac augue elementum, rutrum est at, facilisis felis. Phasellus nec lobortis lectus. Nunc porta nunc odio, id posuere ex ornare in. Donec consequat, magna eu tempus dignissim, nulla purus tempor risus, id dignissim diam tellus ac lorem. Donec malesuada, orci quis ullamcorper tincidunt, nibh erat elementum purus, non dictum dolor arcu non felis. ",
                    DateWritten = new DateTime(1489, 7, 19)
                }
                );
        }
    }
}
