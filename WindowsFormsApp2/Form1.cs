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
    public partial class MainMenu : Form
    {
        public static world start;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_rpg create = new Form_rpg();
            create.ShowDialog();
            reloadUsers();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string h;
            h = characters.Text;
            Save.JSONDeseralize(h);
            start = new world();
            start.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void MainMenu_Load(object sender, EventArgs e)
        {
            reloadUsers();
            Item.makeItems();
        }

        public void reloadUsers()
        {
            characters.Items.Clear();

            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo("saves");
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles();

            foreach (FileInfo foundFile in filesInDir)
            {
                string fullName = foundFile.FullName;
                characters.Items.Add(foundFile.Name);
            }

            characters.Text = "";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("are you sure you want to delete this character?", "Delete character?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Save.Delete(characters.Text);
                dialogResult = MessageBox.Show("", "File has been deleted", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    //Application.Restart();
                    reloadUsers();
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("File has not been deleted");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item.sMagPot.printInfo();
        }
    }
}
