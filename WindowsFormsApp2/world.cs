using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class world : Form
    {

        public bool aPress = false;
        public bool bPress = false;
        public bool inFight = false;
        character player = new character(0, 0, "", "", 0, 0, 0);
        public world()
        {
            InitializeComponent();
            player = Save.getCharacter();
            PlayerStats.Text = player.printInfo();

            if (!player.TutorialComplete)
            {
                player.tree = 1;
                AdventureDialogue.Text = "do you want to do the tutorial? (you will get bonus exp for doing so)";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void world_Load(object sender, EventArgs e)
        {

        }

        private void aButton_Click(object sender, EventArgs e)
        {

            aPress = true;
            checkTree();
            aPress = false;
        }


        private void bButton_Click(object sender, EventArgs e)
        {
            bPress = true;
            checkTree();
            bPress = false;
        }

        private void AdventureDialogue_TextChanged(object sender, EventArgs e)
        {


        }
        public void LoadTutorial()
        {


            if (aPress)
            {
                yes();
                player.tree++;
            }
            else if (bPress)
            {
                no();
                player.tree += 2;
            }
        }
        void checkTree()
        {
            if (!inFight)
            {
                if (player.tree == 1)
                {
                    LoadTutorial();
                }
                else if (player.tree == 2)
                {

                }
            }
        }
        void Tutorial()
        {

        }
        public void yes()
        {
            if (player.tree == 1)
            {
                AdventureDialogue.Text = "ok.";
                
            }
            if(player.tree == 2)
            {
                player.TutorialComplete = true;
            }
        }
        public void no()
        {
            if (player.tree == 1)
            {
                AdventureDialogue.Text = "nevermind then";
                player.TutorialComplete = true;
            }
        }

        public void dialogueChange(string d)
        {
            AdventureDialogue.Text = d;
        }

        public void tutorialFight()
        {
            inFight = true;

            AdventureDialogue.Text = "You start the fight with the sample enemy.";
            if (inFight)
            {
                tutorialFight();
            }
            else
            {
                return;
            }
        }
    }
}
