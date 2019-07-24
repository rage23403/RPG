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
        private int tree = 0;
        character player = new character(0, 0, "", "", 0, 0, 0);
        public world()
        {
            InitializeComponent();
            player = Save.getCharacter();
            PlayerStats.Text = player.printInfo();

            if (!player.TutorialComplete)
            {
                tree = 1;
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
        }


        private void bButton_Click(object sender, EventArgs e)
        {
            bPress = true;
            checkTree();
        }

        private void AdventureDialogue_TextChanged(object sender, EventArgs e)
        {


        }
        public void LoadTutorial()
        {


            if (aPress)
            {
                yes();
                tree++;
                aPress = false;
            }
            else if (bPress)
            {
                no();
                tree += 2;
                bPress = false;
            }


        }
        void checkTree()
        {
            if(tree == 1)
            {
                LoadTutorial();
            }
        }
        public void yes()
        {
            if (!player.TutorialComplete)
            {
                AdventureDialogue.Text = "ok.";
            }
        }
        public void no()
        {
            if (!player.TutorialComplete)
            {
                AdventureDialogue.Text = "nevermind then";
            }

        }

    }
}
