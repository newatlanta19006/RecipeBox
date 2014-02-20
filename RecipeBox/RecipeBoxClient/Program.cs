using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeBox.Core;

namespace RecipeBoxClient
{
    static class Program
    {
        public static RecipeBox.Core.RecipeBox RecipeBox { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            RecipeBox = new RecipeBox.Core.RecipeBox();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RecipeBoxHome());
        }
    }
}
