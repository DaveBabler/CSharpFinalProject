using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadonnaChecker
{
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//play some music
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\Users\Dabab\Documents\School Sync\COP-2360-06330 Programming in C#\Project\Babler-Project_full\Final Version of Project\MadonnaChecker\MadonnaChecker\Media\opener.mp3";
                wplayer.controls.play();
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
