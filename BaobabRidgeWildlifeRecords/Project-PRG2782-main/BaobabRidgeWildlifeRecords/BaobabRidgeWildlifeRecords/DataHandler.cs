using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabRidgeWildlifeRecords
{
    internal class DataHandler
    {

        private List<Animal> Animals {  get; set; }
         
        public DataHandler()//Constructor to load from the file on creation;
        {

        }


        public void AddAnimal() //Adds animal to list
        {

        }

        public void RemoveAnimal() //Removes animal from list
        {

        }

        public List<Animal> ViewAnimals() //Sends animal list to program for viewing
        {
            return Animals;
        }

        public void UpdateAnimal() //Changes an animal in list
        {

        }

        public void GenerateSummary() //Generates summary
        {

        }

        public void WriteToAnimalFile() //Writes list to file
        {

        }
    }
}
