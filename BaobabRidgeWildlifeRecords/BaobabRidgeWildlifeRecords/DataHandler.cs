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
        public int skipped {  get; private set; }
         
        public DataHandler()//Constructor to load from the file on creation;
        {
            Animals = new List<Animal>();
            skipped = 0;

            if (!File.Exists("animals.txt")) return;

            using (StreamReader reader = new StreamReader("animals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) //Skips if empty line
                    {
                        skipped++;
                        continue;
                    }

                    string[] temp = line.Split("|");
                    if (temp.Length < 5 ||
                        !int.TryParse(temp[3], out int age) ||
                        !int.TryParse(temp[4], out int score))   //Parses age and score. Skips if unable.
                    {
                        skipped++;
                        continue;
                    }

                    string status = temp.Length > 5 ? temp[5] : "In Treatment";
                    string housingUnit = temp.Length > 6 ? temp[6] : "Unassigned";

                    if (!Animal.TryCreate(temp[0], temp[1], temp[2], age, score, status, housingUnit, out Animal animal)) //Tries to create the object. Skips if it fails
                    {
                        skipped++;
                        continue;
                    }


                    Animals.Add(animal);
                }
            }
        }


        public void AddAnimal() //Adds animal to list
        {

        }

        public void RemoveAnimal(string animalID) //Removes animal from list
        {
            try
            {
                foreach (Animal animal in Animals)
                {
                    if (animal.animalID == animalID)
                    {
                        Animals.Remove(animal);
                        MessageBox.Show("Animal was successfully found and deleted");
                        return;
                    }
                }
                MessageBox.Show("Animal was not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occured: {ex.Message}");
            }
        }

        internal List<Animal> ViewAnimals() //Sends animal list to program for viewing
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
            using (FileStream stream = new FileStream("animals.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach(Animal animal in Animals)
                    {
                        writer.WriteLine($"{animal.animalID}|{animal.name}|{animal.species}|{animal.age}|{animal.recoveryScore}|{animal.status}|{animal.housingUnit}");
                    }
                }
            }
                
        }
    }
}
