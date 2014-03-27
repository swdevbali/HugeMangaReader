using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HugeMangaReader
{
    static class Program
    {
        public static int vol;
        public static string url;
        public static string savepath;
        public static int ipage;
        public static bool isTwoDigit;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
