using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{


    public class Potions
    {
        bool type;
        int size;
        string name;
        int healing;
        int magic;
        int value;
        float buyPrice;
        float sellPrice;
        public Potions(bool t, int s, string n)
        {
            type = t;
            size = s;
            name = n;
        }
        public void check()
        {
            if (size == 1)
            {
                value = 10;
                name = "Small " + name;
                buyPrice = 100;
                sellPrice = 50;
            }
            else if (size == 2)
            {
                value = 25;
                buyPrice = 500;
                sellPrice = 250;
            }
            else if (size == 3)
            {
                value = 50;
                name = "Big " + name;
                buyPrice = 1000;
                sellPrice = 500;
            }
            else
            {
                value = 999;
                name = "Max " + name;
                buyPrice = 5000;
                sellPrice = 2500;
            }
            if (type)
            {
                healing = value;
                
            }
            else
            {
                magic = value;
                buyPrice *= 1.5f;
                sellPrice *= 1.5f;
            }
        }
        public void printInfo()
        {
            string stats = "Name: " + name + "\r\nAmount will heal: " + value + "\r\nSell Price: " + sellPrice + "mons";
            MessageBox.Show(stats, name + " stats");
        }
    }
    
    public class Sword
    {
        string name;
        int damage;
        bool twoHanded;
        bool equipped;
        bool broken;
        int durability;
        int maxDurability;
        int buyPrice;
        int sellPrice;
        public Sword(string n, int dam, bool t, int dur, int b, int s)
        {
            name = n;
            damage = dam;
            twoHanded = t;
            durability = dur;
            maxDurability = dur;
            broken = false;
        }
        
        public void check()
        {
            if(durability <= 0)
            {
                if (!broken)
                {
                    broken = true;
                    Brake();
                }
                else
                {
                    return;
                }
                
            }
        }
        public void Brake()
        {
            if (broken)
            {
                damage *= 1/2;
            }
            else
            {
                damage *= 2;
            }
        }
        public void hit()
        {
            Random ran = new Random();
            if(ran.Next(4) == 3)
            {
                durability--;
            }
            
        }
        public void repair()
        {
            durability = maxDurability;
            broken = false;
        }
        /*
        Copper
        Iron
        Not Gold... ok fine gold for the memes.
        Steel 
        */
    }
    /*
    class DamageStaffs
    {
    Wooden
    Fire Rod
    Ice Rod
    }
    class SummonStaves
    {
    Skull
    }
    class HealingStaves
    {
    Wooden
    }
    class Dagger
    {
    Copper
    }
    class Mace
    {
    Copper
    }
    class Bow
    {
    Wooden
    Gun
    {
    Pistol
    Shotgun
    Sniper
    Automatic Rifle
    }
    }
    
    

    */

    /*
    class KeyItems
    {
    Lamp
    }





    */

}
