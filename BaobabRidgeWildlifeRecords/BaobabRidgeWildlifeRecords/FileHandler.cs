using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaobabRidgeWildlifeRecords
{
    internal class FileHandler
    {
        private readonly string animalsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");
        private readonly string summaryFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "summary.txt");


        // reads raw text lines from animals.txt
        public List<string> ReadAnimalLines()
        {
            List<string> lines = new List<string>();

            if (!File.Exists(animalsFilePath))
            {
                return lines;
            }

            try
            {
                using (StreamReader reader = new StreamReader(animalsFilePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from {animalsFilePath}: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lines;

        }

        //writes formatted summary report to summary.txt
        public void WriteSummaryFile(int total, string avgAge, string avgScore, Dictionary<string, int> statusCounts)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            try
            {
                using (StreamWriter writer = new StreamWriter(summaryFilePath, false, Encoding.UTF8))
                {
                    writer.WriteLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
                    writer.WriteLine("ANIMAL SUMMARY REPORT");
                    writer.WriteLine($"Generated: {timestamp}");
                    writer.WriteLine("Total animals:");
                    writer.WriteLine(total);
                    writer.WriteLine("Average age (years):");
                    writer.WriteLine(avgAge);
                    writer.WriteLine("Average recovery score:");
                    writer.WriteLine(avgScore);
                    writer.WriteLine("Animals per status:");
                    writer.WriteLine("Critical:");
                    writer.WriteLine(statusCounts["Critical"]);
                    writer.WriteLine("Serious:");
                    writer.WriteLine(statusCounts["Serious"]);
                    writer.WriteLine("Stable:");
                    writer.WriteLine(statusCounts["Stable"]);
                    writer.WriteLine("Recovering:");
                    writer.WriteLine(statusCounts["Recovering"]);
                    writer.WriteLine("Release-Ready:");
                    writer.WriteLine(statusCounts["Release-Ready"]);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Access denied when writing to {summaryFilePath}: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (IOException ex)
            {
                MessageBox.Show($"I/O error when writing to {summaryFilePath}: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while writing summary.txt:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}