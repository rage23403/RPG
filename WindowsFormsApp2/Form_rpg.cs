using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form_rpg : Form
    {
        Random ran = new Random();
        public Form_rpg()
        {
            InitializeComponent();
        }

        private void Form_rpg_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void charClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void charCreate_Click(object sender, EventArgs e)
        {
            string charClass = "";
            if (charClasses.SelectedIndex == 0)
            {
                charClass = "Warrior";
            }
            else if(charClasses.SelectedIndex == 1)
            {
                charClass = "Mage";
            }
            else if (charClasses.SelectedIndex == 2)
            {
                charClass = "Ranger";
            }
            else if (charClasses.SelectedIndex == 3)
            {
                charClass = "Necromancer";
            }
            else if (charClasses.SelectedIndex == 4)
            {
                charClass = "Rogue";
            }
            else if (charClasses.SelectedIndex == 5)
            {
                charClass = "Healer";
            }
            if(char_name.Text.Length > 10)
            {
                MessageBox.Show("you cannot have a name that long");
            }
            else
            {
                createCharacter(charClass, char_name.Text);
            }
            /*
            StreamWriter File = new StreamWriter("saves\\playerStats.txt");
            File.Write("");
            File.Close();
            MessageBox.Show("");
            */
            
        }
        public void createCharacter(string Class, string name)
        {
           
            int hp = 0;
            int mp = 0;
            int white = 0;
            int dark = 0;
            int damage = 1;

            if(Class == "Warrior")
            {
                hp = ran.Next(5) + 10;
                damage = ran.Next(3) + 5;
            }
            else if(Class == "Mage")
            {
                hp = ran.Next(2) + 4;
                mp = ran.Next(3) + 2;
                dark = ran.Next(3) + 6;
            }
            else if (Class == "Ranger")
            {
                hp = ran.Next(3) + 6;
                damage = ran.Next(4) + 6;
            }
            else if (Class == "Necromancer")
            {
                hp = ran.Next(2) + 3;
                mp = ran.Next(3) + 5;
                dark = ran.Next(2) + 4;
                white = ran.Next(3) + 2;
            }
            else if (Class == "Rogue")
            {
                hp = ran.Next(4) + 4;
                mp = ran.Next(2) + 1;
                damage = ran.Next(3) + 4;
                dark = ran.Next(5) + 2;
            }
            else if (Class == "Healer")
            {
                hp = ran.Next(3) + 4;
                mp = ran.Next(3) + 2;
                damage = ran.Next(4) + 3;
                white = ran.Next(5) + 6;
            }

            character ch1 = new character(hp, mp, Class, name, white, dark, damage);
            Save.JSONSeralize(ch1);
            //Application.Restart();

            Close();
        }
    }
}
