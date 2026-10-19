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
    }

    /// <summary>
    /// Initializes the blank form's basic properties.
    /// </summary>
    private void InitializeComponent()
    {
        SuspendLayout();
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 600);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Baobab Ridge Wildlife Rehabilitation Records System";
        ResumeLayout(false);
    }
}
