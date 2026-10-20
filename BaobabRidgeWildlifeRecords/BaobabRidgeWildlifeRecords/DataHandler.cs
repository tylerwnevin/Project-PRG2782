using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace BaobabRidgeWildlifeRecords
{
    public class DataHandler
    {
        private FileHandler fileHandler;
        private List<Animal> Animals {  get; set; }
        public int skipped {  get; private set; }
         
        public DataHandler()//Constructor to load from the file on creation;
        {
            Animals = new List<Animal>();
            skipped = 0;
            fileHandler = new FileHandler(); // Instantiate FileHandler

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

public bool AddAnimal(Animal animal)
        {
            if (Animals.Any(a => a.AnimalID == animal.AnimalID))
                return false;

            Animals.Add(animal);

            try
            {
                WriteToAnimalFile();
                return true;
            }
            catch
            {
                Animals.Remove(animal);
                throw;
            }
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

        public bool UpdateAnimal(string id, string name,
    string species, int age, int score)
        {
            Animal existing = Animals.Find(a => a.AnimalID == id);

            if (existing == null)
                return false;

            if (!Animal.TryCreate(id, name, species, age,
                score, out Animal updated))
                return false;

            int index = Animals.IndexOf(existing);
            Animals[index] = updated;

            WriteToAnimalFile();
            return true;
        }

        public (int total, string avgAge, string avgScore, Dictionary<string, int> statusCounts) GenerateSummary() //Generates summary
        {
            var statusCounts = new Dictionary<string, int>
            {
                { "Critical", 0 },
                { "Serious", 0 },
                { "Stable", 0 },
                { "Recovering", 0 },
                { "Release-Ready", 0 }
            };

            int totalAnimals = Animals.Count;
            string avgAgeStr = "N/A";
            string avgScoreStr = "N/A";

            if (totalAnimals > 0)
            {
                double avgAge = Animals.Average(a => a.age);
                double avgScore = Animals.Average(a => a.recoveryScore);

                avgAgeStr = avgAge.ToString("F2", CultureInfo.InvariantCulture);
                avgScoreStr = avgScore.ToString("F2", CultureInfo.InvariantCulture);

                foreach (var animal in Animals)
                {
                    string trimmedStatus = animal.status?.Trim();
                    if (!string.IsNullOrEmpty(trimmedStatus) && statusCounts.ContainsKey(trimmedStatus))
                    {
                        statusCounts[trimmedStatus]++;
                    }
                }
            }

            // Delegate writing to FileHandler
            fileHandler.WriteSummaryFile(totalAnimals, avgAgeStr, avgScoreStr, statusCounts);

            return (totalAnimals, avgAgeStr, avgScoreStr, statusCounts);
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
