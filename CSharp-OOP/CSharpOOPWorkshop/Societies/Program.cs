using SocietiesCore.Contracts;
using SocietiesCore.Infrastructure.Enumerations.Human;
using SocietiesCore.Infrastructure.Utilities;
using SocietiesCore.Models.Humans;
using System;

namespace Societies
{
    class Program
    {
        static void Main()
        {
            var human = new Waiter(
                DataGenerator.GenerateMaleName(),
                DataGenerator.GenerateAge(),
                HairType.Black,
                EyesColorType.Brown,
                FaceType.Heart,
                RaceType.African,
                GenderType.Male,
                ReligionType.Agnosticism
                );

            Console.WriteLine(human);
        }
    }
}
