using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using System.Drawing;

namespace TrynsDAY
{
    class Program
    {
        private static Spell Q, W, E, R;
        public static MyOrbwalker.Orbwalker orbwalker;
        public static Menu DaysMenu;

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }
        private static void Game_OnGameLoad(EventArgs args)
        {
            if (ObjectManager.Player.ChampionName != "Tryndamere")
                return;

            Q = new Spell(SpellSlot.Q);
            W = new Spell(SpellSlot.W, 880f);
            E = new Spell(SpellSlot.E, 660f);
            R = new Spell(SpellSlot.R);


            E.SetSkillshot(0.25f, 225f, 700f, false, SkillshotType.SkillshotLine);
            Game.PrintChat("<font color ='#ea812e'>Hey it's DayBreak</font> <font color='#b756c5'>, have fun using TrynsDay</font>");

            DaysMenus.DaysMenu();



        }


    }
}
