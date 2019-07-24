using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class ItemPrefabs
    {
        public static Potions sPot;
        public static Potions Pot;
        public static Potions bPot;
        public static Potions mPot;
        public static Potions sMagPot;
        public static Potions MagPot;
        public static Potions bMagPot;
        public static Potions mMagPot;
        public static Sword cSword;
        public static Sword gSword;
        public static Sword iSword;
        public static Sword sSword;
        public static void makeItems()
        {
            sPot = new Potions(true, 1, "Potion");
            sPot.check();
            Pot = new Potions(true, 2, "Potion");
            Pot.check();
            bPot = new Potions(true, 3, "Potion");
            bPot.check();
            mPot = new Potions(true, 4, "Potion");
            mPot.check();
            sMagPot = new Potions(false, 1, "Magic potion");
            sMagPot.check();
            MagPot = new Potions(false, 2, "Magic potion");
            MagPot.check();
            bMagPot = new Potions(false, 3, "Magic potion");
            bMagPot.check();
            mMagPot = new Potions(false, 4, "Magic potion");
            mMagPot.check();
            cSword = new Sword("Copper sword", 5, false, 24, 0,0);
            iSword = new Sword("Iron sword", 10, false, 50, 500, 250);
            gSword = new Sword("Gold sword", 1, false, 1, 1000000, 1);
            sSword = new Sword("Steel sword", 25, false, 100, 2000, 1000);

        }
    }
}
