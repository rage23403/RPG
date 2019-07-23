using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class character
    {
        
        public string Name { get; set; }
        public string Class { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int MaxHP { get; set; }
        public int MaxMP { get; set; }
        public int Mons { get; set; }
        public int Exp { get; set; }
        public int Damage { get; set; }
        public int SpecialLight { get; set; }
        public int SpecialDark { get; set; }
        public int Defense { get; set; }
        public bool TutorialComplete { get; set; }
        public character(int h, int m, string c, string n, int w, int dar, int dmg)
        {
            HP = h;
            MP = m;
            Class = c;
            Name = n;
            MaxMP = m;
            MaxHP = h;
            Exp = 0;
            Mons = 0;
            SpecialLight = w;
            SpecialDark = dar;
            Damage = dmg;
            TutorialComplete = false;
        }
        public string printInfo()
        {
            string stats = "";
            stats += "Name: " + Name + "\r\nClass: " + Class + "\r\nHealth: " + HP + "/" + MaxHP + "\r\nMagic Points: " + MP + "/" + MaxMP + "\r\nTotal Exp: " + Exp + "\r\nMons: " + Mons;
            stats += "\r\nDamage: " + Damage + "\r\nLight Power: " + SpecialLight + "\r\nDark Power: " + SpecialDark;
            return stats;
        }

        public void necroFight()
        {

        }

        public void Backpack()
        {
            string [] packItems = new string[30];
        }
        public void equipment()
        {
            if (Class == "Warrior")
            {
                //Sword weapon = new Sword();
            }
            else if (Class == "Mage" || Class == "Necromancer" || Class == "Healer")
            {
                //Staff staff = new Staff();
            }
            else if (Class == "Rogue")
            {
                //Dagger dagger = new Dagger();
            }
            else if(Class == "Ranger")
            {
                //Bow bow = new Bow();
            }
        }
    }
}
