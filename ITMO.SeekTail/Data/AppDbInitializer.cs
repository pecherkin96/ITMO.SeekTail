using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ITMO.SeekTail.Models;

namespace ITMO.SeekTail.Data
{
    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Locations.AddRange(new List<Location>()
            {
                new Location()
                {
                    LocationId = 1,
                    City = "Санкт-Петербург",
                    Street = "Гаражный проспект",
                    House = 4,
                },
                new Location()
                {
                    LocationId = 2,
                    City = "Санкт-Петербург",
                },
            });
            context.SaveChanges();
            context.PetColors.AddRange(new List<PetColor>()
            {
                new PetColor()
                {
                    Id = 1,
                    Color = "чёрный"
                },
                new PetColor()
                {
                    Id = 2,
                    Color = "белый"
                },
                new PetColor()
                { 
                    Id = 3,
                    Color = "серый"
                },
                new PetColor()
                {
                    Id = 4,
                    Color = "красный"
                },
                new PetColor()
                {
                    Id = 5,
                    Color = "пятнистый"
                },
                new PetColor()
                {
                    Id = 6,
                    Color = "полосатый"
                },
                new PetColor()
                {
                    Id = 7,
                    Color = "оранжевыйй"
                },
            });
            context.SaveChanges();
            context.Shelters.AddRange(new List<Shelter>()
            {
                new Shelter()
                {
                    ShelterId = 1,
                    Name = "Новый дом",
                    Image = "https://sun9-6.userapi.com/impf/c851536/v851536417/3bc/s8GfA3-QZ98.jpg?size=1250x928&quality=96&sign=17b6ae5b6f134e1b157e197671511f1a&type=album",
                    LocationId = 1,
                    Phone = 78126605177
                },
                new Shelter()
                {
                    ShelterId = 2,
                    Name = "Полянка",
                    Image = "https://sun9-21.userapi.com/impg/9dajiW35plYHKcwpge_caeX4UZXMvp2Gm5cHpg/ZnGhquj31s8.jpg?size=709x709&quality=95&sign=a8edaec6e77dae4263453aae14bfda39&type=album",
                    LocationId = 2,
                    Phone = 78126426412
                },
            });
            context.SaveChanges();
            context.PetStatuses.AddRange(new List<PetStatus>()
            {
                new PetStatus()
                {
                    PetStatusId = 1,
                    Name = "Пропал"
                },
                new PetStatus()
                {
                    PetStatusId = 2,
                    Name = "Найден"
                },
            });
            context.SaveChanges();
            context.Animals.AddRange(new List<Animal>()
            {
                new Animal()
                {
                    AnimalId = 1,
                    Type = "кот"
                },
                new Animal()
                {
                    AnimalId = 2,
                    Type = "собака"
                },
                new Animal()
                {
                    AnimalId = 3,
                    Type = "хомяк"
                },
                new Animal()
                {
                    AnimalId = 4,
                    Type = "птица"
                },
            });
            context.SaveChanges();
            context.Pets.AddRange(new List<Pet>()
            {
                new Pet()
                {
                    PetId = 1, 
                    Name = "Чарли",
                    PetStatusId = 1,
                    ShelterId = 1,
                    PetColorId = 7,
                    LinkImage = "https://sun9-47.userapi.com/impg/BD37OstrARHJvpSFhBEBbsYxQnxmpTCN99902w/Qwhvx8_bejM.jpg?size=1280x853&quality=95&sign=c72f203fd7c4d4014c8e94b7702f242d&type=album",
                    NoticeDate = DateTime.Now,
                    AnimalId = 1,
                },
                new Pet()
                {
                    PetId = 2,
                    Name = "Гроссен",
                    PetStatusId = 2,
                    ShelterId = 1,
                    PetColorId = 7,
                    LinkImage = "https://sun9-15.userapi.com/impg/COFh6Czy6hadpLkb3yAgjvP216EWn_UFHxIcIw/gcjqDgZg1Zo.jpg?size=1280x853&quality=95&sign=f6f2804c0ec0510cf4dfb03af1dca96f&type=album",
                    NoticeDate = DateTime.Now,
                    AnimalId = 1,
                },
            });
            context.SaveChanges();
        }
    }
}