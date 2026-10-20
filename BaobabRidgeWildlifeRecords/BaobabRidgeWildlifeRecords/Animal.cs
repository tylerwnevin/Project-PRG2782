using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabRidgeWildlifeRecords
{
    public class Animal
    {
        public string animalID { get; set; }
        public string name { get; set; }
        public string species { get; set; }
        public int age { get; set; }
        public int recoveryScore { get; set; }
        public string status { get; set; }
        public string housingUnit { get; set; }

        public Animal(string animalID, string name, string species, int age, int recoveryScore, string status = "In Treatment", string housingUnit = "Unassigned")
        {
            this.animalID = animalID;
            this.name = name;
            this.species = species;
            this.age = age;
            this.recoveryScore = recoveryScore;
            this.status = status;
            this.housingUnit = housingUnit;
        }

        public static bool TryCreate(string animalID, string name, string species, int age, int recoveryScore, string status, string housingUnit, out Animal animal)
        {
            if ((animalID.Length != 6) || (name.Length > 30) || (name.Length < 1) || (species.Length > 30)
                || (species.Length < 1) || (age > 100) || (age < 0)
                || (recoveryScore > 100) || (recoveryScore < 0))
            {
                animal = null;
                return false;
            }

            animal = new Animal(animalID, name, species, age, recoveryScore, status, housingUnit);
            return true;
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
