using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Save
    {
        public static character ch1;
        public static void JSONSeralize(character ch)
        {
            string filename = ch.Name + ".json";
            string file ="";
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo("saves");
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles();
            foreach (FileInfo foundFile in filesInDir)
            {
                string fullName = foundFile.FullName;
                file = foundFile.Name;
                
            }
            if (file == filename)
            {
                MessageBox.Show("You can't have the same name twice");
            }
            else
            {
                File.WriteAllText("saves\\" + filename, JsonConvert.SerializeObject(ch));
            }
        }
        public static void JSONDeseralize(string name)
        {
            ch1 = JsonConvert.DeserializeObject<character>(File.ReadAllText("saves\\"+ name));
        }
    }
}
