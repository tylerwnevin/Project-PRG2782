namespace BaobabRidgeWildlifeRecords
{
    partial class UpdateAnimalForm
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
            txtAnimalID = new TextBox();
            txtAnimalName = new TextBox();
            cmbSpecies = new ComboBox();
            numAge = new NumericUpDown();
            numRecoveryScore = new NumericUpDown();
            btnCancel = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).BeginInit();
            SuspendLayout();
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(169, 65);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(125, 27);
            txtAnimalID.TabIndex = 0;
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new Point(169, 118);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.Size = new Size(125, 27);
            txtAnimalName.TabIndex = 1;
            // 
            // cmbSpecies
            // 
            cmbSpecies.FormattingEnabled = true;
            cmbSpecies.Location = new Point(168, 184);
            cmbSpecies.Name = "cmbSpecies";
            cmbSpecies.Size = new Size(151, 28);
            cmbSpecies.TabIndex = 2;
            // 
            // numAge
            // 
            numAge.Location = new Point(169, 255);
            numAge.Name = "numAge";
            numAge.Size = new Size(150, 27);
            numAge.TabIndex = 3;
            // 
            // numRecoveryScore
            // 
            numRecoveryScore.Location = new Point(169, 324);
            numRecoveryScore.Name = "numRecoveryScore";
            numRecoveryScore.Size = new Size(150, 27);
            numRecoveryScore.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(460, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(612, 383);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 42);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 7;
            label1.Text = "AnimalID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 95);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 8;
            label2.Text = "AnimalName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 150);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 9;
            label3.Text = "Species";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 232);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 10;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 301);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 11;
            label5.Text = "RecoveryScore";
            label5.Click += label5_Click;
            // 
            // UpdateAnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(numRecoveryScore);
            Controls.Add(numAge);
            Controls.Add(cmbSpecies);
            Controls.Add(txtAnimalName);
            Controls.Add(txtAnimalID);
            Name = "UpdateAnimalForm";
            Text = "UpdateAnimalForm";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnimalID;
        private TextBox txtAnimalName;
        private ComboBox cmbSpecies;
        private NumericUpDown numAge;
        private NumericUpDown numRecoveryScore;
        private Button btnCancel;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}