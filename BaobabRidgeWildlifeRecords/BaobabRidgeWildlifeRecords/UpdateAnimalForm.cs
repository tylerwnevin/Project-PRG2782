using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaobabRidgeWildlifeRecords
{
    public partial class UpdateAnimalForm : Form
    {
        private readonly DataHandler data;
        public UpdateAnimalForm(DataHandler handler)
        {
            InitializeComponent();
            data = handler;

            cmbSpecies.Items.AddRange(new object[]
            {
        "Lion", "Elephant", "Rhino",
        "Leopard", "Cheetah", "Zebra"
            });

            btnUpdate.Click += btnUpdate_Click;
            btnCancel.Click += (s, e) => Close();
        }
        public void LoadAnimal(Animal animal)
        {
            txtAnimalID.Text = animal.AnimalID;
            txtAnimalID.ReadOnly = true;

            txtAnimalName.Text = animal.Name;
            cmbSpecies.Text = animal.Species;
            numAge.Value = animal.Age;
            numRecoveryScore.Value = animal.RecoveryScore;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool success = data.UpdateAnimal(
                txtAnimalID.Text.Trim(),
                txtAnimalName.Text.Trim(),
                cmbSpecies.Text.Trim(),
                (int)numAge.Value,
                (int)numRecoveryScore.Value);

            if (success)
            {
                MessageBox.Show("Animal updated successfully.");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Animal not found or invalid details.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
