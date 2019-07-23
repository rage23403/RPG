using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class world : Form
    {
        bool aPress = false;
        bool bPress = false;
        character player = new character(0,0,"","",0,0,0);
        public world()
        {
            InitializeComponent();
            player = Save.getCharacter();
            PlayerStats.Text = player.printInfo();
            LoadTutorial();
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
            System.Threading.Thread.Sleep(100);
            aPress = false;
        }
        void LoadTutorial()
        {
            if (!player.TutorialComplete)
            {
                AdventureDialogue.Text = "do you want to do the tutorial? (you will get bonus exp for doing so)";
                while (!aPress && !bPress)
                {
                    if (aPress)
                    {
                        AdventureDialogue.Text = "ok.";
                    }
                    else if (bPress)
                    {
                        AdventureDialogue.Text = "nevermind then";
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            bPress = true;
            System.Threading.Thread.Sleep(100);
            bPress = false;
        }
    }
}
