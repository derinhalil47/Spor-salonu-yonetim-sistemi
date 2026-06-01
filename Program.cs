using GymManagement.Data;

namespace GymManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseHelper.Initialize();

            Application.Run(new MainForm());
        }
    }
}