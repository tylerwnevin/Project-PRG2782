using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabRidgeWildlifeRecords
{
    internal class Animal
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

        public static bool TryCreate(string animalID, string name, string species, int age, int recoveryScore, out Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animalID) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(species))
            {
                animal = null;
                return false;
            }

            animal = new Animal(animalID, name, species, age, recoveryScore);
            return true;
        }
    }
}

