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
    public partial class AddAnimalForm : Form
    {
        private readonly DataHandler data;
        public AddAnimalForm(DataHandler datahandler)
        {
            InitializeComponent();
            data = datahandler;

            numAge.Minimum = 0;
            numAge.Maximum = 100;
            numRecoveryScore.Minimum = 0;
            numRecoveryScore.Maximum = 100;

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string id = lblAnimalID.Text.Trim();
            string name = txtAnimalName.Text.Trim();
            string species = cmbSpecies.Text.Trim();
            int age = (int)numAge.Value;
            int score = (int)numRecoveryScore.Value;
           
            if (!Animal.TryCreate(id, name, species, age, score,
    out Animal animal))
            {
                MessageBox.Show("Invalid animal details.");
                return;
            }


            try
            {
                if (!data.AddAnimal(animal))
                {
                    MessageBox.Show("Animal ID already exists.");
                    return;
                }

                MessageBox.Show("Animal added successfully.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
