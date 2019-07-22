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
            
            /*
            StreamWriter File = new StreamWriter("saves\\playerStats.txt");
            File.Write("");
            File.Close();
            MessageBox.Show("");
            */
            createCharacter(charClass, char_name.Text);
            
        }
        public void createCharacter(string Class, string name)
        {
            int hp = 0;
            int mp = 0;

            if(Class == "Warrior")
            {
                hp = 10;
                mp = 0;
            }
            else if(Class == "Mage")
            {
                hp = 4;
                mp = 2;
            }
            else if (Class == "Ranger")
            {
                hp = 6;
                mp = 0;
            }
            else if (Class == "Necromancer")
            {
                hp = 2;
                mp = 5;
            }
            else if (Class == "Rogue")
            {
                hp = 5;
                mp = 1;
            }
            else if (Class == "Healer")
            {
                hp = 4;
                mp = 2;
            }

            character ch1 = new character(hp, mp, Class, name);
            Save.JSONSeralize(ch1);
            Application.Restart();
        }
    }
}
