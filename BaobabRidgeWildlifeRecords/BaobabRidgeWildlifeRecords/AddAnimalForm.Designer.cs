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
            label1 = new Label();
            txtAnimalID = new Label();
            txtAnimalName = new TextBox();
            TextanimalID = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            cmbSpecies = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 121);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Animal Name";
            // 
            // txtAnimalID
            // 
            txtAnimalID.AutoSize = true;
            txtAnimalID.Location = new Point(129, 59);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(75, 20);
            txtAnimalID.TabIndex = 4;
            txtAnimalID.Text = "Animal ID";
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new Point(129, 144);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.Size = new Size(441, 27);
            txtAnimalName.TabIndex = 6;
            txtAnimalName.Text = "Enter animal name";
            // 
            // TextanimalID
            // 
            TextanimalID.Location = new Point(129, 82);
            TextanimalID.Name = "TextanimalID";
            TextanimalID.Size = new Size(441, 27);
            TextanimalID.TabIndex = 7;
            TextanimalID.Text = "Enter ID";
            TextanimalID.TextChanged += textBox3_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 375);
            textBox5.Name = "textBox5";
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
            // button1
            // 
            button1.Location = new Point(513, 422);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(631, 422);
            button2.Name = "button2";
            button2.Size = new Size(157, 29);
            button2.TabIndex = 19;
            button2.Text = "Save animal";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(129, 266);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(129, 319);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 21;
            // 
            // cmbSpecies
            // 
            cmbSpecies.FormattingEnabled = true;
            cmbSpecies.Location = new Point(129, 212);
            cmbSpecies.Name = "cmbSpecies";
            cmbSpecies.Size = new Size(151, 28);
            cmbSpecies.TabIndex = 23;
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSpecies);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(TextanimalID);
            Controls.Add(txtAnimalName);
            Controls.Add(txtAnimalID);
            Controls.Add(label1);
            Name = "AddAnimalForm";
            Text = "AddAnimalForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label txtAnimalID;
        private TextBox txtAnimalName;
        private TextBox TextanimalID;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox cmbSpecies;
    }
}