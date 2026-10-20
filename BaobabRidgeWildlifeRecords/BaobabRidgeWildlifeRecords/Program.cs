namespace BaobabRidgeWildlifeRecords;

/// <summary>
/// Starts the Windows Forms application.
/// </summary>
internal static class Program
{
    /// <summary>
    /// Configures Windows Forms and opens the main form.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new grpAnimalRecords());
    }
}
