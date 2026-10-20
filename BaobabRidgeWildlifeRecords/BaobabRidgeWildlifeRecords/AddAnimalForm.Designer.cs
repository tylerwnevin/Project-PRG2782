namespace BaobabRidgeWildlifeRecords
{
    partial class AddAnimalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAnimalName = new Label();
            lblAnimalID = new Label();
            txtAnimalName = new TextBox();
            txtAnimalID = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCancel = new Button();
            btnSaveAnimal = new Button();
            numAge = new NumericUpDown();
            numRecoveryScore = new NumericUpDown();
            txtSpecies = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).BeginInit();
            SuspendLayout();
            // 
            // lblAnimalName
            // 
            lblAnimalName.AutoSize = true;
            lblAnimalName.Location = new Point(129, 121);
            lblAnimalName.Name = "lblAnimalName";
            lblAnimalName.Size = new Size(100, 20);
            lblAnimalName.TabIndex = 3;
            lblAnimalName.Text = "Animal Name";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(129, 59);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(71, 20);
            lblAnimalID.TabIndex = 4;
            lblAnimalID.Text = "AnimalID";
            lblAnimalID.Click += lblAnimalID_Click;
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new Point(129, 144);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.Size = new Size(441, 27);
            txtAnimalName.TabIndex = 6;
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(129, 82);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(441, 27);
            txtAnimalID.TabIndex = 7;
            txtAnimalID.TextChanged += textBox3_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 375);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(441, 27);
            textBox5.TabIndex = 9;
            textBox5.Text = "Automatically calculated";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 243);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 14;
            label3.Text = "Age";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 296);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 15;
            label4.Text = "Recovery score";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 352);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 16;
            label5.Text = "Housing unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 190);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 17;
            label6.Text = "Species";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(513, 422);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveAnimal
            // 
            btnSaveAnimal.Location = new Point(631, 422);
            btnSaveAnimal.Name = "btnSaveAnimal";
            btnSaveAnimal.Size = new Size(157, 29);
            btnSaveAnimal.TabIndex = 19;
            btnSaveAnimal.Text = "Save animal";
            btnSaveAnimal.UseVisualStyleBackColor = true;
            btnSaveAnimal.Click += button2_Click;
            // 
            // numAge
            // 
            numAge.Location = new Point(129, 266);
            numAge.Name = "numAge";
            numAge.Size = new Size(150, 27);
            numAge.TabIndex = 20;
            // 
            // numRecoveryScore
            // 
            numRecoveryScore.Location = new Point(129, 319);
            numRecoveryScore.Name = "numRecoveryScore";
            numRecoveryScore.Size = new Size(150, 27);
            numRecoveryScore.TabIndex = 21;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(129, 213);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(125, 27);
            txtSpecies.TabIndex = 22;
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSpecies);
            Controls.Add(numRecoveryScore);
            Controls.Add(numAge);
            Controls.Add(btnSaveAnimal);
            Controls.Add(btnCancel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(txtAnimalID);
            Controls.Add(txtAnimalName);
            Controls.Add(lblAnimalID);
            Controls.Add(lblAnimalName);
            Name = "AddAnimalForm";
            Text = "AddAnimalForm";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAnimalName;
        private Label lblAnimalID;
        private TextBox txtAnimalName;
        private TextBox txtAnimalID;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCancel;
        private Button btnSaveAnimal;
        private NumericUpDown numAge;
        private NumericUpDown numRecoveryScore;
        private TextBox txtSpecies;
    }
}