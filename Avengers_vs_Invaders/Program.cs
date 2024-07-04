using Avengers_vs_Invaders.Helper;
using Microsoft.VisualBasic.FileIO;

namespace Avengers_vs_Invaders
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            FetchData.Initial();
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}