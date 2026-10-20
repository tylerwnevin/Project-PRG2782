using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace BaobabRidgeWildlifeRecords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    namespace BaobabRidgeWildlifeRecords
    {
        class DataHandler
        {

            private List<Animal> Animals { get; set; }
            public int skipped { get; private set; }

            public DataHandler()//Constructor to load from the file on creation;
            {
                try
                {
                    Animals = new List<Animal>();
                    skipped = 0;

                    if (!File.Exists("animals.txt"))
                    {
                        File.Create("animals.txt").Close(); //Creates the file if it doesn't exist. Close() releases the handle so it can be read below.
                        MessageBox.Show("File not found. A new empty animals.txt has been created.");
                        return;
                    }

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

                            if (!Animal.TryCreate(temp[0], temp[1], temp[2], age, score, out Animal animal)) //Tries to create the object. Skips if it fails
                            {
                                skipped++;
                                continue;
                            }
                            Animals.Add(animal);
                        }
                        MessageBox.Show($"{skipped} invalid records were skipped");
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message );
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
                        if (animal.AnimalID == animalID)
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
                try
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
                catch
                {
                    return false;
                }
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
                    double avgAge = Animals.Average(a => a.Age);
                    double avgScore = Animals.Average(a => a.RecoveryScore);

                    avgAgeStr = avgAge.ToString("F2", CultureInfo.InvariantCulture);
                    avgScoreStr = avgScore.ToString("F2", CultureInfo.InvariantCulture);

                    foreach (var animal in Animals)
                    {
                        string trimmedStatus = animal.Status?.Trim();
                        if (!string.IsNullOrEmpty(trimmedStatus) && statusCounts.ContainsKey(trimmedStatus))
                        {
                            statusCounts[trimmedStatus]++;
                        }
                    }
                }

                // Delegate writing to FileHandler
                FileHandler handler = new FileHandler();
                handler.WriteSummaryFile(totalAnimals, avgAgeStr, avgScoreStr, statusCounts);

                return (totalAnimals, avgAgeStr, avgScoreStr, statusCounts);
            }


            public void WriteToAnimalFile() //Writes list to file
            {
                using (FileStream stream = new FileStream("animals.txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        foreach (Animal animal in Animals)
                        {
                            writer.WriteLine($"{animal.AnimalID}|{animal.Name}|{animal.Species}|{animal.Age}|{animal.RecoveryScore}|{animal.Status}|{animal.HousingUnit}");
                        }
                    }
                }

            }
        }
    }
}