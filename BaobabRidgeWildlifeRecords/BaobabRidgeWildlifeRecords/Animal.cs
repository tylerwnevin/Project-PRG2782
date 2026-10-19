using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabRidgeWildlifeRecords
{
    internal class Animal
    {

        public string AnimalID { get; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; private set; }
        public string HousingUnit { get; private set; }

        public Animal(string animalID, string name, string species, int age, int recoveryscore)
        {
            AnimalID = animalID;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryscore;
            Recalculate();
        }

        public void Recalculate()
        {
            if (RecoveryScore > 0 && RecoveryScore < 20)
            {
                Status = "Critical";
                HousingUnit = "Intensive Care Unit";
            }
            else if (RecoveryScore > 19 &&  RecoveryScore < 40)
            {
                Status = "Serious";
                HousingUnit = "High-Dependency Ward";
            }
            else if (RecoveryScore > 39 && RecoveryScore < 60)
            {
                Status = "Stable";
                HousingUnit = "Recovery Ward";
            }
            else if (RecoveryScore > 59 && RecoveryScore < 80)
            {
                Status = "Recovering";
                HousingUnit = "Outdoor Enclosure";
            }
            else
            {
                Status = "Release-Ready";
                HousingUnit = "Pre-Release Camp";
            }
            
        }
    }
}
