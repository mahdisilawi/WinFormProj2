using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class musicPlayerApp : Form
    {
        public musicPlayerApp()
        {
            InitializeComponent();
        }

        string[] names, paths;

        private void btn_selectMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog();
            //select multiple songs 
            openF.Multiselect = true;

            if (openF.ShowDialog() == DialogResult.OK)
            {
                names = openF.SafeFileNames;
                paths = openF.FileNames;
                for (int i = 0; i < names.Length; i++)
                {
                    //Display Names on List Box
                    listBox_songList.Items.Add(names[i]);
                }
            }
        }

        private void listBox_songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmp_playSong.URL = paths[listBox_songList.SelectedIndex];
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // A Botton to Close the MusicPlayer
            this.Close();
        }
    }
}
