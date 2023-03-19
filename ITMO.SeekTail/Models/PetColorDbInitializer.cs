using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.SeekTail.Models
{
    public class PetColorDbInitializer : DropCreateDatabaseIfModelChanges<PetColorContext>
    {
        protected override void Seed(PetColorContext context)
        {
            context.PetColors.Add(new PetColor
            {
                Color = "чёрный"
            });

            context.PetColors.Add(new PetColor
            {
                Color = "белый"
            });

            context.PetColors.Add(new PetColor
            {
                Color = "серый"
            });

            context.PetColors.Add(new PetColor
            {
                Color = "крвсный"
            });
            context.PetColors.Add(new PetColor
            {
                Color = "пятнистый"
            });
            context.PetColors.Add(new PetColor
            {
                Color = "полосатый"
            });
            context.PetColors.Add(new PetColor
            {
                Color = "оранжевый"
            });
        }
    }
}