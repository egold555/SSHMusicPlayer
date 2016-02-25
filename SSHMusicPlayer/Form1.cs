using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SSHMusicPlayer
{
    public partial class Setup : Form
    {
        Renci.SshNet.SshClient cSSH = null;
        int repeat = 0;
        int shuffle = 0;
        int mute = 0;
        Boolean connected = false;

        public Setup()
        {
            InitializeComponent();

        }
        public void printInfo(String i)
        {
         

            String time = DateTime.Now.ToShortTimeString();

            ConsoleWindow.Text += "[Info] " + time + ": " + i + "\r\n";
        }
        public void printError(String e)
        {       
            String time = DateTime.Now.ToShortTimeString();

            ConsoleWindow.Text += "[Error] " + time + ": " + e  + "\r\n";

            statusLabel.ForeColor = Color.Red;
            statusLabel.Text = "An error occured. Please check console for details.";
        }
        public void button1_Click(object sender, EventArgs e)
        {
            

            int port = int.Parse(userInputPort.Text);
            //Renci.SshNet.SshClient cSSH = new SshClient("192.168.10.144", 22, "root", "pacaritambo");
            try
            {
                cSSH = new SshClient(userInputIP.Text, port, userInputUsername.Text, userInputPassword.Text);
            }
            catch (Exception ex)
            {
                printError(ex.ToString() + " happened in Renci.SshNet.SshClient");
                return;
            }


            try
            {
                cSSH.Connect();                
            }

            catch (Exception ex)
            {
                printError(ex.ToString() + " happened in cSSH.Connect()");
                return;
            }

            if (connected == true)
            {
                //disconnect
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Disconnected";
                printInfo("Disconnected by user.");
                connected = false;
                buttonConnect.Text = "Connect to device";
                cSSH.Disconnect();
                cSSH.Dispose();
                return;
            }

            if (connected == false)
            {
                //connect
                statusLabel.ForeColor = Color.DarkGreen;
                statusLabel.Text = "Connected";
                printInfo("Successfully connected.");
                connected = true;
                buttonConnect.Text = "Disconnect from device";
            }
            
            

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media vol" + volumeControl.Value.ToString());
                printInfo("Volume changed to: " + volumeControl.Value.ToString());
                
            }
        }

        public void playPause_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media p");
                printInfo("Issued Command: Media p");
            }
            
        }

        private void stopMusic_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media stop");
                printInfo("Issued Command: Media stop");
            }
            
        }

        private void repeatMusic_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media repeat");
                printInfo("Issued Command: Media repeat");
                repeat++;
                if (repeat == 1)
                {
                    //song
                    repeatSong.Text = "Repeat: Song";
                    printInfo("Repeat: Song");
                }
                if (repeat == 2)
                {
                    //playlist
                    repeatSong.Text = "Repeat: Playlist";
                    printInfo("Repeat: Playlist");
                }
                if (repeat >= 3)
                {
                    //set back to 0
                    //off
                    repeat = 0;
                    repeatSong.Text = "Repeat: Off";
                    printInfo("Repeat: Off");
                }

            }
        }

        private void shuffleSong_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media shuffle");
                printInfo("Issued Command: Media shuffle");
                shuffle++;
                if (shuffle == 1)
                {
                    //song
                    shuffleSong.Text = "Shuffle: On";
                    printInfo("Shuffle: On");
                }
                if (shuffle >= 2)
                {
                    //set back to 0
                    //off
                    shuffle = 0;
                    shuffleSong.Text = "Shuffle: Off";
                    printInfo("Shuffle: Off");
                }
            }            
        }

        private void muteSong_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media mute");
                printInfo("Issued Command: Media mute");
                mute++;
                if (mute == 1)
                {
                    //song
                    muteSong.Text = "Mute: On";
                    printInfo("Mute: On");
                }
                if (mute >= 2)
                {
                    //set back to 0
                    //off
                    mute = 0;
                    muteSong.Text = "Mute: Off";
                    printInfo("Mute: Off");
                }
            }
            
        }

        private void nextSong_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media next");
                printInfo("Issued Command: Media next");
            }
           
        }

        private void prevSong_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media prev");
                printInfo("Issued Command: Media prev");
            }
            
        }

        private void likeSong_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media like");
                printInfo("Issued Command: Media like");
            }
            
        }

        private void hateSong_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media hate");
                printInfo("Issued Command: Media hate");
            }
            
        }

        private void wishSong_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                SshCommand x = cSSH.RunCommand("media wish");
                printInfo("Issued Command: Media wish");
            }
            
        }

        private void syncPhoneData_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                label7.Text = cSSH.RunCommand("media getVol").Result;
            }
            
        }

    }
}
