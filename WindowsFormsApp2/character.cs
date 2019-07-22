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
        public character(int h, int m, string c, string n)
        {
            HP = h;
            MP = m;
            Class = c;
            Name = n;
            MaxMP = m;
            MaxHP = h;
            Exp = 0;
            Mons = 0;
        }
        public string printInfo()
        {
            string stats = "";
            stats += "Name: " + Name + "\r\nClass: " + Class + "\r\nHealth: " + HP + "/" + MaxHP + "\r\nMagic Points: " + MP + "/" + MaxMP + "\r\nTotal Exp: " + Exp + "\r\nMons: " + Mons;
        
            return stats;
        }
    }
}
