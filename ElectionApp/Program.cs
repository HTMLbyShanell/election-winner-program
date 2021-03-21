using System;

namespace ElectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Info i = new Info();
            ElectionUI ui = new ElectionUI();

            i.DisplayInfo("MidTerm Election Program");
            ui.MainMethod();
        }
    }
}
