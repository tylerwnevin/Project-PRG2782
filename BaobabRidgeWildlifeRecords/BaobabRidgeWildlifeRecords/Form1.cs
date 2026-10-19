namespace BaobabRidgeWildlifeRecords;

/// <summary>
/// The initial blank main form for the wildlife records application.
/// </summary>
public partial class Form1 : Form
{
    /// <summary>
    /// Creates the main form.
    /// </summary>
    public Form1()
    {
        InitializeComponent();
        dataHandler = new DataHandler();

        this.Load += Form1_Load;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ConfigureDataGridView();
        RefreshAnimalGrid();
    }

    //Configures DataGridView properties
    private void ConfigureDataGridView()
    {
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

        // set the exact column order and headers
        if (dgvAnimals.Columns.Count > 0)
        {
            dgvAnimals.Columns["AnimalID"].HeaderText = "Animal ID";
            dgvAnimals.Columns["Name"].HeaderText = "Name";
            dgvAnimals.Columns["Species"].HeaderText = "Species";
            dgvAnimals.Columns["Age"].HeaderText = "Age";
            dgvAnimals.Columns["RecoveryScore"].HeaderText = "Recovery Score";
            dgvAnimals.Columns["Status"].HeaderText = "Status";
            dgvAnimals.Columns["HousingUnit"].HeaderText = "Housing Unit";
        }

        //notify the user if lines were skipped during load
        if (dataHandler.skipped > 0)
        {
            MessageBox.Show($"{dataHandler.skipped} invalid records were skipped during load.");
        }
    }

    /// <summary>
    /// Initializes the blank form's basic properties.
    /// </summary>
    private void InitializeComponent()
    {
        dgvAnimals = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
        SuspendLayout();
        // 
        // dgvAnimals
        // 
        dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAnimals.Location = new Point(67, 80);
        dgvAnimals.Name = "dgvAnimals";
        dgvAnimals.RowHeadersWidth = 82;
        dgvAnimals.Size = new Size(480, 300);
        dgvAnimals.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1857, 1280);
        Controls.Add(dgvAnimals);
        Margin = new Padding(6, 6, 6, 6);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Baobab Ridge Wildlife Rehabilitation Records System";
        ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
        ResumeLayout(false);
    }

    private DataGridView dgvAnimals;
    private DataHandler dataHandler;
}
