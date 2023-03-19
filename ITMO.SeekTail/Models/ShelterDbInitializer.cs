using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.SeekTail.Models
{
    public class ShelterDbInitializer : DropCreateDatabaseIfModelChanges<ShelterContext>
    {
        protected override void Seed(ShelterContext context)
        {
            context.Shelters.Add(new Shelter
            {
                Name = "Новый дом",
                Image = "http://newdomcat.ru/wp-content/uploads/2021/05/xcropped-kjuj.png.pagespeed.ic.hyQm3X8uOw.webp",
                //LocationId = 1,
                ShelterId = 1,
                phone = 78126605177
            });
            base.Seed(context);
            context.Shelters.Add(new Shelter
            {
                Name = "Полянка",
                Image = "https://sun9-21.userapi.com/impg/9dajiW35plYHKcwpge_caeX4UZXMvp2Gm5cHpg/ZnGhquj31s8.jpg?size=709x709&quality=95&sign=a8edaec6e77dae4263453aae14bfda39&type=album",
                //LocationId = 2,
                ShelterId = 2,
                phone = 78126426412
            });
        }
    }
}