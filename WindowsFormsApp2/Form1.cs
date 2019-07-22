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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_rpg create = new Form_rpg();
            create.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string h;
            h = characters.Text;
            Save.JSONDeseralize(h);
            world start = new world();
            start.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo("saves");
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles();

            foreach (FileInfo foundFile in filesInDir)
            {
                string fullName = foundFile.FullName;
                characters.Items.Add(foundFile);
            }
            
        }
    }
}
