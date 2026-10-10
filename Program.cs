namespace Edoria_Raine_LabStream;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmLab1());
    }
}
