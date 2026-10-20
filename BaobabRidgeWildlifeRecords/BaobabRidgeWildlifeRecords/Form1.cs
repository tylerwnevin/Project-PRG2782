using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaobabRidgeWildlifeRecords;

/// <summary>
/// The initial blank main form for the wildlife records application
/// </summary>


public partial class Form1 : Form
{
    /// <summary>
    /// Creates the main form
    //summary
    private readonly DataHandler data = new DataHandler();
    public Form1()
    {
        InitializeComponent();
    }

    


    /// <summary>
    /// Initializes the blank form's basic properties
    /// </summary>
    private void InitializeComponent()
    {
        SuspendLayout();
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1143, 800);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Baobab Ridge Wildlife Rehabilitation Records System";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

        using (var form = new AddAnimalForm(data))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Refreshes the main form's animal list here
            }
        }

    }
}
