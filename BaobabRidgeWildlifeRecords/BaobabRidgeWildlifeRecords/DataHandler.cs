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
            Animals = new List<Animal>();

            if (!File.Exists("animals.txt")) return;

            using (StreamReader reader = new StreamReader("animals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] temp = line.Split("|");
                    if (temp.Length < 5) continue;

                    Animal animal = new Animal(
                        temp[0], temp[1], temp[2],
                        int.Parse(temp[3].Trim()),
                        int.Parse(temp[4].Trim()));
                    Animals.Add(animal);
                }
            }
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
