using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class CheckEvent
    {
        public static void LoadTutorial()
        {

            while (!MainMenu.start.aPress && !MainMenu.start.bPress)
            {
                if (MainMenu.start.aPress)
                {
                    MainMenu.start.yes();
                }
                else if (MainMenu.start.bPress)
                {
                    MainMenu.start.no();
                }
            }

        }
    }
}
