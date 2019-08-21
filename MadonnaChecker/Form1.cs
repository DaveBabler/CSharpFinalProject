using System.Media;
using System;
using System.Timers;
using System.IO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadonnaChecker
{
    public partial class Form1 : Form

    {
        public void pauseProg()
        {
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            aTimer = new System.Timers.Timer();
            System.Threading.Thread.Sleep(1000);
            aTimer.Interval = 10000;
            //await Task.Delay(1000);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }
        public Form1()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '♪';
            PasswordBox.MaxLength = 14;
            ballDoneImage.Visible = false;

        }
        private static System.Timers.Timer aTimer;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        public static class login
        {
            public static string user;
            public static string pass;
            public static string con = @"server=localhost;userid=" + login.user + ";password=" + login.pass + ";database=music";
            //the above is for this page only, and made from laziness
            //the next set is going to be used to pass around to different forms
            public static string c1 = @"server=localhost;userid=";
            public static string c3 = ";password=";
            public static string c5 = ";database=music";

       



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //begin login scripts
            login.user = UserNameBox.Text;
            login.pass = PasswordBox.Text;
            MySqlConnection mycon = null;
            string connector = @"server=localhost;userid=" + login.user + ";password=" + login.pass + ";database=music";
;

            try
            {
                mycon = new MySqlConnection(connector);
                mycon.Open();
                // -- here is where the next form will load and this one will close*/     
                //close this form and open a new one upon successful connection; after a delay 
                
                PassLabel.Visible = false;
                PasswordBox.Visible = false;
                UserLabel.Visible = false;
                UserNameBox.Visible = false;
                button1.Visible = false;
                   
                pauseProg(); pauseProg();
                ballOpeningImage.Visible = true;
                pauseProg(); pauseProg();
                ballOpeningImage.Visible = false;
                ballDoneImage.Visible = true;
                pauseProg(); pauseProg(); pauseProg(); pauseProg();
               


                //end fun little load screen get to business

                this.Hide();
                var DataLoading = new DataLoading();
                DataLoading.Closed += (s, args) => this.Close();
                DataLoading.Show();

            }
            catch (MySqlException ex)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\Users\Dabab\Documents\School Sync\COP-2360-06330 Programming in C#\Project\Babler-Project_full\Final Version of Project\MadonnaChecker\MadonnaChecker\Media\exception.wav";
                player.Play();
                MessageBox.Show("Your Password or Username is invalid /n Or, you're just an idiot.", ex.ToString());
              
            }
            finally
            {
                if (mycon != null)
                {
                    mycon.Close();
                }
            }
 
         
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ballOpeningImage_Click(object sender, EventArgs e)
        {

        }
    }
}
