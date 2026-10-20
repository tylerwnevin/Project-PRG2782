using BaobabRidgeWildlifeRecords.BaobabRidgeWildlifeRecords;

namespace BaobabRidgeWildlifeRecords;

/// <summary>
/// The initial blank main form for the wildlife records application.
/// </summary>
public partial class grpAnimalRecords : Form
{
    /// <summary>
    /// Creates the main form.
    /// </summary>
    private DataHandler dataHandler;
    public grpAnimalRecords()
    {

        InitializeComponent();
        dataHandler = new DataHandler();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ConfigureDataGridView();
        RefreshAnimalGrid();
        InitializeSummaryUI();
    }

    //Configures DataGridView properties
    private void ConfigureDataGridView()
    {
        dgvAnimals.AutoGenerateColumns = false;
        dgvAnimals.ReadOnly = true;
        dgvAnimals.AllowUserToAddRows = false;
        dgvAnimals.AllowUserToDeleteRows = false;
        dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAnimals.MultiSelect = false;
        dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    //Loads Animals from DataHandler into the DataGridView
    public void RefreshAnimalGrid()
    {
        dgvAnimals.DataSource = null;
        dgvAnimals.DataSource = dataHandler.ViewAnimals();

        colAnimalID.DataPropertyName = "animalID"; // or "AnimalID" if capitalized in Animal.cs
        colName.DataPropertyName = "name";
        colSpecies.DataPropertyName = "species";
        colAge.DataPropertyName = "age";
        colRecoveryScore.DataPropertyName = "recoveryScore";
        colStatus.DataPropertyName = "status";
        colHousingUnit.DataPropertyName = "housingUnit";

        // Set the headers on the designer-defined columns.
        colAnimalID.HeaderText = "Animal ID";
        colName.HeaderText = "Name";
        colSpecies.HeaderText = "Species";
        colAge.HeaderText = "Age";
        colRecoveryScore.HeaderText = "Recovery Score";
        colStatus.HeaderText = "Status";
        colHousingUnit.HeaderText = "Housing Unit";

        //notify the user if lines were skipped during load
        if (dataHandler.skipped > 0)
        {
            MessageBox.Show($"{dataHandler.skipped} invalid records were skipped during load.");
        }
    }

    //summary UI Controls
    private GroupBox grpSummary;
    private Label lblTotalVal;
    private Label lblAvgAgeVal;
    private Label lblAvgScoreVal;
    private Label lblStatusCountsVal;

    // Creates and adds the summary groupbox to the form dynamically
    private void InitializeSummaryUI()
    {
        grpSummary = new GroupBox
        {
            Text = "Summary Report",
            Location = new System.Drawing.Point(20, 715),
            Size = new System.Drawing.Size(1583, 75),
            ForeColor = System.Drawing.Color.Black,
            BackColor = System.Drawing.Color.White
        };

        Label lblTotal = new Label { Text = "Total Animals:", Location = new System.Drawing.Point(15, 30), AutoSize = true, ForeColor = System.Drawing.Color.Black };
        lblTotalVal = new Label { Text = "-", Location = new System.Drawing.Point(115, 30), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold), ForeColor = System.Drawing.Color.DarkGreen };

        Label lblAvgAge = new Label { Text = "Avg Age:", Location = new System.Drawing.Point(180, 30), AutoSize = true, ForeColor = System.Drawing.Color.Black };
        lblAvgAgeVal = new Label { Text = "-", Location = new System.Drawing.Point(250, 30), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold), ForeColor = System.Drawing.Color.DarkGreen };

        Label lblAvgScore = new Label { Text = "Avg Score:", Location = new System.Drawing.Point(340, 30), AutoSize = true, ForeColor = System.Drawing.Color.Black };
        lblAvgScoreVal = new Label { Text = "-", Location = new System.Drawing.Point(420, 30), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold), ForeColor = System.Drawing.Color.DarkGreen };

        Label lblStatus = new Label { Text = "Counts per Status:", Location = new System.Drawing.Point(520, 30), AutoSize = true, ForeColor = System.Drawing.Color.Black };
        lblStatusCountsVal = new Label { Text = "Critical: 0 | Serious: 0 | Stable: 0 | Recovering: 0 | Release-Ready: 0", Location = new System.Drawing.Point(650, 30), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold), ForeColor = System.Drawing.Color.DarkBlue };

        grpSummary.Controls.Add(lblTotal);
        grpSummary.Controls.Add(lblTotalVal);
        grpSummary.Controls.Add(lblAvgAge);
        grpSummary.Controls.Add(lblAvgAgeVal);
        grpSummary.Controls.Add(lblAvgScore);
        grpSummary.Controls.Add(lblAvgScoreVal);
        grpSummary.Controls.Add(lblStatus);
        grpSummary.Controls.Add(lblStatusCountsVal);

        Controls.Add(grpSummary);
    }

    /// <summary>
    /// Initializes the blank form's basic properties.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitle = new Panel();
        label1 = new Label();
        label2 = new Label();
        grpAnimalDetails = new GroupBox();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        textAgeID = new TextBox();
        label7 = new Label();
        txtAgeID = new Label();
        txtRevoeryScoreID = new TextBox();
        txtSpeciesID = new TextBox();
        txtNameID = new TextBox();
        lblRecoveryScoreID = new Label();
        lblAgeID = new Label();
        lblNameID = new Label();
        lblSpeciesID = new Label();
        txtAnimalID = new TextBox();
        lblAnimalID = new Label();
        groupBox1 = new GroupBox();
        dgvAnimals = new DataGridView();
        colAnimalID = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colSpecies = new DataGridViewTextBoxColumn();
        colAge = new DataGridViewTextBoxColumn();
        colRecoveryScore = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        colHousingUnit = new DataGridViewTextBoxColumn();
        buttonGenerate = new Button();
        buttonDelete = new Button();
        lblTitle.SuspendLayout();
        grpAnimalDetails.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.BackColor = Color.DarkGreen;
        lblTitle.Controls.Add(label1);
        lblTitle.Controls.Add(label2);
        lblTitle.Location = new Point(20, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(1595, 90);
        lblTitle.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.DarkGreen;
        label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.ControlLightLight;
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(197, 37);
        label1.TabIndex = 1;
        label1.Text = "Baobab Ridge";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(12, 37);
        label2.Name = "label2";
        label2.Size = new Size(231, 17);
        label2.TabIndex = 0;
        label2.Text = "Wildlife Rehabilitation Records System";
        // 
        // grpAnimalDetails
        // 
        grpAnimalDetails.BackColor = SystemColors.ButtonHighlight;
        grpAnimalDetails.Controls.Add(button3);
        grpAnimalDetails.Controls.Add(button2);
        grpAnimalDetails.Controls.Add(button1);
        grpAnimalDetails.Controls.Add(textAgeID);
        grpAnimalDetails.Controls.Add(label7);
        grpAnimalDetails.Controls.Add(txtAgeID);
        grpAnimalDetails.Controls.Add(txtRevoeryScoreID);
        grpAnimalDetails.Controls.Add(txtSpeciesID);
        grpAnimalDetails.Controls.Add(txtNameID);
        grpAnimalDetails.Controls.Add(lblRecoveryScoreID);
        grpAnimalDetails.Controls.Add(lblAgeID);
        grpAnimalDetails.Controls.Add(lblNameID);
        grpAnimalDetails.Controls.Add(lblSpeciesID);
        grpAnimalDetails.Controls.Add(txtAnimalID);
        grpAnimalDetails.Controls.Add(lblAnimalID);
        grpAnimalDetails.ForeColor = SystemColors.InactiveCaptionText;
        grpAnimalDetails.Location = new Point(20, 119);
        grpAnimalDetails.Name = "grpAnimalDetails";
        grpAnimalDetails.Size = new Size(1595, 286);
        grpAnimalDetails.TabIndex = 1;
        grpAnimalDetails.TabStop = false;
        grpAnimalDetails.Text = "Animal Details";
        grpAnimalDetails.Enter += grpAnimalDetails_Enter;
        // 
        // button3
        // 
        button3.BackColor = Color.CadetBlue;
        button3.Location = new Point(458, 205);
        button3.Name = "button3";
        button3.Size = new Size(195, 35);
        button3.TabIndex = 14;
        button3.Text = "Clear";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.DeepSkyBlue;
        button2.Location = new Point(235, 205);
        button2.Name = "button2";
        button2.Size = new Size(195, 35);
        button2.TabIndex = 13;
        button2.Text = "Save Changes";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.SeaGreen;
        button1.ForeColor = Color.White;
        button1.Location = new Point(15, 205);
        button1.Name = "button1";
        button1.RightToLeft = RightToLeft.No;
        button1.Size = new Size(196, 35);
        button1.TabIndex = 12;
        button1.Text = "Add Animal";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // textAgeID
        // 
        textAgeID.Location = new Point(336, 106);
        textAgeID.Name = "textAgeID";
        textAgeID.Size = new Size(276, 25);
        textAgeID.TabIndex = 11;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(390, 81);
        label7.Name = "label7";
        label7.Size = new Size(0, 19);
        label7.TabIndex = 10;
        // 
        // txtAgeID
        // 
        txtAgeID.AutoSize = true;
        txtAgeID.Location = new Point(381, 89);
        txtAgeID.Name = "txtAgeID";
        txtAgeID.Size = new Size(0, 19);
        txtAgeID.TabIndex = 9;
        // 
        // txtRevoeryScoreID
        // 
        txtRevoeryScoreID.Location = new Point(16, 156);
        txtRevoeryScoreID.Name = "txtRevoeryScoreID";
        txtRevoeryScoreID.Size = new Size(276, 25);
        txtRevoeryScoreID.TabIndex = 8;
        // 
        // txtSpeciesID
        // 
        txtSpeciesID.Location = new Point(15, 106);
        txtSpeciesID.Name = "txtSpeciesID";
        txtSpeciesID.Size = new Size(277, 25);
        txtSpeciesID.TabIndex = 7;
        // 
        // txtNameID
        // 
        txtNameID.Location = new Point(336, 53);
        txtNameID.Name = "txtNameID";
        txtNameID.Size = new Size(276, 25);
        txtNameID.TabIndex = 6;
        txtNameID.TextChanged += textBox1_TextChanged;
        // 
        // lblRecoveryScoreID
        // 
        lblRecoveryScoreID.AutoSize = true;
        lblRecoveryScoreID.ForeColor = Color.Black;
        lblRecoveryScoreID.Location = new Point(15, 134);
        lblRecoveryScoreID.Name = "lblRecoveryScoreID";
        lblRecoveryScoreID.Size = new Size(101, 19);
        lblRecoveryScoreID.TabIndex = 5;
        lblRecoveryScoreID.Text = "Recovery Score";
        lblRecoveryScoreID.Click += label6_Click;
        // 
        // lblAgeID
        // 
        lblAgeID.AutoSize = true;
        lblAgeID.ForeColor = Color.Black;
        lblAgeID.Location = new Point(336, 86);
        lblAgeID.Name = "lblAgeID";
        lblAgeID.Size = new Size(77, 19);
        lblAgeID.TabIndex = 4;
        lblAgeID.Text = "Age (years)";
        // 
        // lblNameID
        // 
        lblNameID.AutoSize = true;
        lblNameID.ForeColor = Color.Black;
        lblNameID.Location = new Point(336, 31);
        lblNameID.Name = "lblNameID";
        lblNameID.Size = new Size(45, 19);
        lblNameID.TabIndex = 3;
        lblNameID.Text = "Name";
        lblNameID.Click += label4_Click_1;
        // 
        // lblSpeciesID
        // 
        lblSpeciesID.AutoSize = true;
        lblSpeciesID.ForeColor = Color.Black;
        lblSpeciesID.Location = new Point(15, 84);
        lblSpeciesID.Name = "lblSpeciesID";
        lblSpeciesID.Size = new Size(53, 19);
        lblSpeciesID.TabIndex = 2;
        lblSpeciesID.Text = "Species";
        // 
        // txtAnimalID
        // 
        txtAnimalID.Location = new Point(15, 53);
        txtAnimalID.Name = "txtAnimalID";
        txtAnimalID.Size = new Size(277, 25);
        txtAnimalID.TabIndex = 1;
        txtAnimalID.TextChanged += txtAnimalID_TextChanged;
        // 
        // lblAnimalID
        // 
        lblAnimalID.AutoSize = true;
        lblAnimalID.BackColor = Color.Transparent;
        lblAnimalID.ForeColor = SystemColors.ControlText;
        lblAnimalID.Location = new Point(15, 31);
        lblAnimalID.Name = "lblAnimalID";
        lblAnimalID.Size = new Size(69, 19);
        lblAnimalID.TabIndex = 0;
        lblAnimalID.Text = "Animal ID";
        lblAnimalID.Click += label3_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dgvAnimals);
        groupBox1.Controls.Add(buttonGenerate);
        groupBox1.Controls.Add(buttonDelete);
        groupBox1.Location = new Point(20, 431);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1583, 278);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Animal Records";
        // 
        // dgvAnimals
        // 
        dgvAnimals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvAnimals.BackgroundColor = SystemColors.ControlLightLight;
        dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAnimals.Columns.AddRange(new DataGridViewColumn[] { colAnimalID, colName, colSpecies, colAge, colRecoveryScore, colStatus, colHousingUnit });
        dgvAnimals.EnableHeadersVisualStyles = false;
        dgvAnimals.GridColor = SystemColors.WindowText;
        dgvAnimals.Location = new Point(33, 43);
        dgvAnimals.Name = "dgvAnimals";
        dgvAnimals.RowHeadersVisible = false;
        dgvAnimals.RowHeadersWidth = 82;
        dgvAnimals.Size = new Size(1487, 175);
        dgvAnimals.TabIndex = 6;
        dgvAnimals.CellContentClick += dataGridView1_CellContentClick;
        // 
        // colAnimalID
        // 
        colAnimalID.DataPropertyName = "animalID";
        colAnimalID.HeaderText = "Animal ID";
        colAnimalID.MinimumWidth = 10;
        colAnimalID.Name = "colAnimalID";
        colAnimalID.ReadOnly = true;
        // 
        // colName
        // 
        colName.DataPropertyName = "name";
        colName.HeaderText = "Name";
        colName.MinimumWidth = 10;
        colName.Name = "colName";
        colName.ReadOnly = true;
        // 
        // colSpecies
        // 
        colSpecies.DataPropertyName = "species";
        colSpecies.HeaderText = "Species";
        colSpecies.MinimumWidth = 10;
        colSpecies.Name = "colSpecies";
        colSpecies.ReadOnly = true;
        // 
        // colAge
        // 
        colAge.DataPropertyName = "age";
        colAge.HeaderText = "Age";
        colAge.MinimumWidth = 10;
        colAge.Name = "colAge";
        colAge.ReadOnly = true;
        // 
        // colRecoveryScore
        // 
        colRecoveryScore.DataPropertyName = "recoveryScore";
        colRecoveryScore.HeaderText = "Recovery Score";
        colRecoveryScore.MinimumWidth = 10;
        colRecoveryScore.Name = "colRecoveryScore";
        colRecoveryScore.ReadOnly = true;
        // 
        // colStatus
        // 
        colStatus.DataPropertyName = "status";
        colStatus.HeaderText = "Status";
        colStatus.MinimumWidth = 10;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        // 
        // colHousingUnit
        // 
        colHousingUnit.DataPropertyName = "housingUnit";
        colHousingUnit.HeaderText = "Housing Unit";
        colHousingUnit.MinimumWidth = 10;
        colHousingUnit.Name = "colHousingUnit";
        colHousingUnit.ReadOnly = true;
        // 
        // buttonGenerate
        // 
        buttonGenerate.BackColor = Color.DarkMagenta;
        buttonGenerate.Location = new Point(219, 236);
        buttonGenerate.Name = "buttonGenerate";
        buttonGenerate.Size = new Size(171, 30);
        buttonGenerate.TabIndex = 5;
        buttonGenerate.Text = "Generate Summary";
        buttonGenerate.UseVisualStyleBackColor = false;
        buttonGenerate.Click += buttonGenerate_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = SystemColors.ControlDarkDark;
        buttonDelete.Location = new Point(33, 236);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(171, 29);
        buttonDelete.TabIndex = 4;
        buttonDelete.Text = "Delete Selected";
        buttonDelete.UseVisualStyleBackColor = false;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // grpAnimalRecords
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        BackColor = SystemColors.ButtonHighlight;
        ClientSize = new Size(1651, 806);
        Controls.Add(groupBox1);
        Controls.Add(grpAnimalDetails);
        Controls.Add(lblTitle);
        Font = new Font("Segoe UI", 10F);
        ForeColor = SystemColors.ControlLightLight;
        Location = new Point(20, 105);
        Name = "grpAnimalRecords";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Baobab Ridge Wildlife Rehabilitation Records System";
        Load += Form1_Load;
        lblTitle.ResumeLayout(false);
        lblTitle.PerformLayout();
        grpAnimalDetails.ResumeLayout(false);
        grpAnimalDetails.PerformLayout();
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
        ResumeLayout(false);
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void grpAnimalDetails_Enter(object sender, EventArgs e)
    {

    }

    private void label4_Click_1(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void txtAnimalID_TextChanged(object sender, EventArgs e)
    {

    }

    private Panel lblTitle;
    private Label label2;
    private Label label1;
    private GroupBox grpAnimalDetails;
    private Label lblAnimalID;
    private Label lblAgeID;
    private Label lblNameID;
    private Label lblSpeciesID;
    private TextBox txtAnimalID;
    private Label lblRecoveryScoreID;
    private TextBox txtRevoeryScoreID;
    private TextBox txtSpeciesID;
    private Label txtAgeID;
    private TextBox textAgeID;
    private Label label7;
    private Button button3;
    private Button button2;
    private Button button1;
    private GroupBox groupBox1;
    private Button buttonGenerate;
    private Button buttonDelete;
    private DataGridView dgvAnimals;
    private DataGridViewTextBoxColumn colAnimalID;
    private DataGridViewTextBoxColumn colName;
    private DataGridViewTextBoxColumn colSpecies;
    private DataGridViewTextBoxColumn colAge;
    private DataGridViewTextBoxColumn colRecoveryScore;
    private DataGridViewTextBoxColumn colStatus;
    private DataGridViewTextBoxColumn colHousingUnit;
    private TextBox txtNameID;

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            Animal animal = new Animal();
            if (Animal.TryCreate(txtAnimalID.Text, txtNameID.Text, txtSpeciesID.Text, int.Parse(txtAgeID.Text), int.Parse(txtRevoeryScoreID.Text), out animal))
            {
                DataHandler handler = new DataHandler();
                handler.AddAnimal(animal);
                dgvAnimals.DataSource = handler.ViewAnimals();
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        txtAgeID.Text = string.Empty;
        txtAnimalID.Text = string.Empty;
        txtNameID.Text = string.Empty;
        txtRevoeryScoreID.Text = string.Empty;
        txtSpeciesID.Text = string.Empty;
    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Search_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == 0)
        {
            DataGridViewRow row = dgvAnimals.Rows[e.RowIndex];

            txtAnimalID.Text = row.Cells[0].Value.ToString();
            txtNameID.Text = row.Cells[1].Value.ToString();
            txtSpeciesID.Text = row.Cells[2].Value.ToString();
            txtAgeID.Text=row.Cells[3].Value.ToString();
            txtRevoeryScoreID.Text = row.Cells[4].Value.ToString();
        }
    }

    private void buttonGenerate_Click(object sender, EventArgs e)
    {
        try
        {
            var summary = dataHandler.GenerateSummary();

            // Update display labels on the form
            lblTotalVal.Text = summary.total.ToString();
            lblAvgAgeVal.Text = summary.avgAge;
            lblAvgScoreVal.Text = summary.avgScore;

            var c = summary.statusCounts;
            lblStatusCountsVal.Text = $"Critical: {c["Critical"]} | Serious: {c["Serious"]} | Stable: {c["Stable"]} | Recovering: {c["Recovering"]} | Release-Ready: {c["Release-Ready"]}";

            MessageBox.Show("Summary report generated and saved to summary.txt successfully!",
                            "Summary Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        try
        {
            Animal animal = new Animal();
            if (Animal.TryCreate(txtAnimalID.Text, txtNameID.Text, txtSpeciesID.Text, int.Parse(txtAgeID.Text), int.Parse(txtRevoeryScoreID.Text), out animal))
            {
                DataHandler handler = new DataHandler();
                handler.RemoveAnimal(animal.AnimalID);
                dgvAnimals.DataSource = handler.ViewAnimals();
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            Animal animal = new Animal();
            if (Animal.TryCreate(txtAnimalID.Text, txtNameID.Text, txtSpeciesID.Text, int.Parse(txtAgeID.Text), int.Parse(txtRevoeryScoreID.Text), out animal))
            {
                DataHandler handler = new DataHandler();
                handler.UpdateAnimal(animal.AnimalID,animal.Name,animal.Species,animal.Age,animal.RecoveryScore);
                dgvAnimals.DataSource = handler.ViewAnimals();
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
