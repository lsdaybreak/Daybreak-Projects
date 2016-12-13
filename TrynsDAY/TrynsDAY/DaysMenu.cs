using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using System.Drawing;
using SharpDX;

namespace TrynsDAY
{

    class DaysMenus
    {
        public static void DaysMenu()
        {
            Program.DaysMenu = new Menu("TrynsDay", "TrynsDay", true).SetFontStyle(FontStyle.Bold, SharpDX.Color.DarkOrange);
            Program.DaysMenu.AddToMainMenu();

            Menu DaysOrbwalker = new Menu("Orbwalker", "Orbwalker");
            Program.orbwalker = new MyOrbwalker.Orbwalker(DaysOrbwalker);
            Program.DaysMenu.AddSubMenu(DaysOrbwalker);
            

        }
        

    }
}
