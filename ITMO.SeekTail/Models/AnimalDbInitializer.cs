using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.SeekTail.Models
{
    public class AnimalDbInitializer : DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            context.Animals.Add(new Animal
            {
                Type = "кот"
            });
            context.Animals.Add(new Animal
            {
                Type = "собака"
            });
            context.Animals.Add(new Animal
            {
                Type = "хомяк"
            });
            context.Animals.Add(new Animal
            {
                Type = "птица"
            });
        }
    }
}